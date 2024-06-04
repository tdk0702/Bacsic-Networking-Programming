using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Lab3.Form2
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private static Thread serverThread = null;
        //private static
        private void btnListen_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = false;
            btnStop.Enabled = true;
            if (serverThread != null)
            {
                serverThread.Resume();
                return;
            }
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            tbxListen.Text = "Telnet running on 127.0.0.1:8080 \r\n";
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            listenerSocket.Bind(ipepServer);
            serverThread = new Thread(() => StartUnsafeThread(ref listenerSocket));
            //serverThread = new Thread(() => StartUnsafeThread());
            serverThread.Start();
            //Thread.CurrentThread.Interrupt();
        }
        private void StartUnsafeThread(ref Socket listenerSocket)
        {
            try
            {
                int bytesReceived = 0;
                byte[] recv = new byte[1];
                Socket clientSocket;
                listenerSocket.Listen(-1);
                clientSocket = listenerSocket.Accept();
                tbxListen.Text += "New client connected" + "\r\n";
                while (clientSocket.Connected)
                {
                    string text = "";
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text += Encoding.ASCII.GetString(recv);
                    } while (text[text.Length - 1] != '\n');
                    tbxListen.Text += text;
                    if (text.Contains("exit")) { clientSocket.Close(); break; }
                }
                listenerSocket.Close();
                btnStop_Click(this, new EventArgs());
            }
            catch (ThreadAbortException)
            {
                MessageBox.Show("Đóng TCP.");
                return;
            }
        }

        private void Server_Load(object sender, EventArgs e)
        {
            btnListen.Enabled = true;
            btnStop.Enabled = false;
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            //serverThread.Abort();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnListen.Enabled = true;
            btnStop.Enabled = false;
            serverThread.Suspend();
        }
    }
}
