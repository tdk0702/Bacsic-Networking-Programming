using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Lab3.Task6.Communicator;

namespace Lab3.Task6.Server
{
    public partial class Server : Form
    {
        private bool active = true;
        private IPEndPoint iep;
        private TcpListener server;
        private Dictionary<String, TcpClient> CLIENT;

        public Server()
        {
            InitializeComponent();
        }
        private void Server_Load(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            //string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            //var host = Dns.GetHostByName(Dns.GetHostName());
            string IP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                IP = endPoint.Address.ToString();
            }
            textIP.Text = IP;
            userInitialize();
        }

        private void userInitialize()
        {
            CLIENT = new Dictionary<String, TcpClient>();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int port;
            try { port = int.Parse(textPort.Text); }
            catch
            {
                MessageBox.Show("Invalid port number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            iep = new IPEndPoint(IPAddress.Parse(textIP.Text), int.Parse(textPort.Text));
            server = new TcpListener(iep);
            server.Start();

            Thread ServerThread = new Thread(new ThreadStart(ServerStart));
            ServerThread.IsBackground = true;
            ServerThread.Start();
        }

        private void ServerStart()
        {
            try
            {
                AppendRichTextBox("Start accept connect from client.");
                changeButtonEnable(btnStart, false);
                changeButtonEnable(btnStop, true);
                //Clipboard.SetText(textIP.Text);
                //MessageBox.Show("IP address copied: " + textIP.Text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (active)
                {
                    TcpClient client = server.AcceptTcpClient();
                    var clientThread = new Thread(() => clientService(client));
                    clientThread.Start();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clientService(TcpClient client)
        {
            StreamReader streamReader = new StreamReader(client.GetStream());
            String s = streamReader.ReadLine();
            Json infoJson = JsonSerializer.Deserialize<Json>(s);

            if (infoJson.type == "LOGIN")
            {
                reponseLogin(infoJson, client);
            }

            try
            {
                bool threadActive = true;
                while (threadActive && client != null)
                {
                    s = streamReader.ReadLine();
                    infoJson = JsonSerializer.Deserialize<Json>(s);
                    if (infoJson != null && infoJson.content != null)
                    {
                        switch (infoJson.type)
                        {
                            case "MESSAGE":
                                if (infoJson.content != null)
                                {
                                    reponseMessage(infoJson);
                                }
                                break;
                            case "FILE":
                                if (infoJson.content != null)
                                {
                                    reponseFile(infoJson, client);
                                }
                                break;
                            case "LOGOUT":
                                if (infoJson.content != null)
                                {
                                    CLIENT[infoJson.content].Close();
                                    CLIENT.Remove(infoJson.content);
                                    AppendRichTextBox(infoJson.content + " logged out.");
                                    threadActive = false;

                                    foreach (String key in CLIENT.Keys)
                                    {
                                        startupClient(CLIENT[key], key);
                                    }
                                }
                                break;
                        }
                    }
                }
            }
            catch
            {
                //client.Close();
            }
        }

        private void reponseLogin(Json infoJson, TcpClient client)
        {
            Account account = JsonSerializer.Deserialize<Account>(infoJson.content);
            if (account.userName != null && !CLIENT.ContainsKey(account.userName))
            {
                string time = DateTime.Now.ToString("HH:mm:ss");
                Json notification = new Json("LOGIN_FEEDBACK", "TRUE");
                sendJson(notification, client);
                AppendRichTextBox(time + " " + account.userName + " logged in!");

                CLIENT.Add(account.userName, client);

                foreach (String key in CLIENT.Keys)
                {
                    startupClient(CLIENT[key], key);
                }
            }
            else
            {
                string time = DateTime.Now.ToString("HH:mm:ss");
                Json notification = new Json("LOGIN_FEEDBACK", "FALSE");
                sendJson(notification, client);
                AppendRichTextBox(time + " " + account.userName + " can not login!");
            }
        }

        private void startupClient(TcpClient client, String name)
        {
            List<String> onlUser = new List<string>(CLIENT.Keys);
            //onlUser.Remove(name);

            string jsonUser = JsonSerializer.Serialize<List<String>>(onlUser);

            Startup startup = new Startup(jsonUser);
            String startupJson = JsonSerializer.Serialize(startup);
            Json json = new Json("STARTUP_FEEDBACK", startupJson);
            sendJson(json, client);
        }

        private void reponseMessage(Json infoJson)
        {
            Messages messages = JsonSerializer.Deserialize<Messages>(infoJson.content);

            string time = DateTime.Now.ToString("HH:mm:ss");
            if (messages != null)
            {
                if (CLIENT.ContainsKey(messages.receiver))
                {
                    AppendRichTextBox(time + " " + messages.sender + " to " + messages.receiver + ": " + messages.message);

                    TcpClient receiver = CLIENT[messages.receiver];
                    sendJson(infoJson, receiver);
                    receiver = CLIENT[messages.sender];
                    sendJson(infoJson, receiver);
                }
                else if (messages.receiver == "")
                {
                    AppendRichTextBox(time + " " + messages.sender + " to ALL: " + messages.message);

                    foreach (String key in CLIENT.Keys)
                    {
                        TcpClient receiver = CLIENT[key];
                        sendJson(infoJson, receiver);
                    }
                }
            }
        }

        private void reponseFile(Json infoJson, TcpClient client)
        {
            FileMessage fileMessage = JsonSerializer.Deserialize<FileMessage>(infoJson.content);

            try
            {
                int length = Convert.ToInt32(fileMessage.lenght);
                byte[] buffer = new byte[length];
                int received = 0;
                int read = 0;
                int size = 1024;
                int remaining = 0;

                // Read bytes from the client using the length sent from the client    
                while (received < length)
                {
                    remaining = length - received;
                    if (remaining < size)
                    {
                        size = remaining;
                    }

                    read = client.GetStream().Read(buffer, received, size);
                    received += read;
                }

                BufferFile bufferFile = new BufferFile(fileMessage.sender, fileMessage.receiver, buffer, fileMessage.extension);

                String jsonString = JsonSerializer.Serialize(bufferFile);
                Json json = new Json("FILE", jsonString);

                if (CLIENT.ContainsKey(fileMessage.receiver))
                {
                    TcpClient receiver = CLIENT[fileMessage.receiver];
                    sendJson(json, receiver);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
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

        private void AppendRichTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendRichTextBox), new object[] { value });
                return;
            }
            rtbDialog.AppendText(value);
            rtbDialog.AppendText(Environment.NewLine);
        }

        private void changeButtonEnable(Button btn, bool enable)
        {
            btn.BeginInvoke(new MethodInvoker(() =>
            {
                btn.Enabled = enable;
            }));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (CLIENT.Count() > 0)
            {
                MessageBox.Show("The server has " + CLIENT.Count + " user(s) logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            active = false;
            Environment.Exit(0);
        }

        public void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CLIENT.Count() > 0)
            {
                MessageBox.Show("The server has " + CLIENT.Count + " user(s) logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            active = false;
            Environment.Exit(0);
        }
    }
}
