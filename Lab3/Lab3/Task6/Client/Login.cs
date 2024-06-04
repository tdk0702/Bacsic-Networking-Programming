using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Task6.Communicator;

namespace Lab3.Task6.Client
{
    public partial class Login : Form
    {
        private IPEndPoint ipe;
        private TcpClient server;
        private StreamReader streamReader;
        private StreamWriter streamWriter;
        private String usrName;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textIP.Text == "" || textPort.Text == "" || textUsername.Text == "")
            {
                MessageBox.Show("Empty Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ipe = new IPEndPoint(IPAddress.Parse(textIP.Text), Int32.Parse(textPort.Text));
                server = new TcpClient();

                server.Connect(ipe);

                usrName = textUsername.Text;
                streamReader = new StreamReader(server.GetStream());
                streamWriter = new StreamWriter(server.GetStream());

                var threadLog = new Thread(new ThreadStart(waitForLoginFeedback));
                threadLog.IsBackground = true;
                threadLog.Start();
            }
            catch
            {
                MessageBox.Show("Cannot connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void waitForLoginFeedback()
        {
            Account account = new Account(usrName);
            String accountJson = JsonSerializer.Serialize(account);
            Json json = new Json("LOGIN", accountJson);

            sendJson(json, server);

            accountJson = streamReader.ReadLine();
            Json? feedback = JsonSerializer.Deserialize<Json?>(accountJson);

            try
            {
                if (feedback != null)
                {
                    if (feedback.type == "LOGIN_FEEDBACK")
                    {
                        if (feedback.content == "TRUE")
                        {
                            new Thread(() => Application.Run(new ChatBox(server, this.usrName))).Start();
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.Close();
                            });
                        }
                        else if (feedback.content == "FALSE")
                        {
                            MessageBox.Show("Login failed!!", "Notification");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sendJson(Json json, TcpClient client)
        {
            byte[] jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(json);
            StreamWriter streamWriter = new StreamWriter(client.GetStream());
            String S = Encoding.ASCII.GetString(jsonUtf8Bytes, 0, jsonUtf8Bytes.Length);
            streamWriter.WriteLine(S);
            streamWriter.Flush();
        }

    }
}
