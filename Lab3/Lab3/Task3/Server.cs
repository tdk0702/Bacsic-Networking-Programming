using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Lab3.Task3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();

            btnListen.Enabled = false;
        }

        void StartUnsafeThread()
        {
            int bytesReceived = 0;

            byte[] recv = new byte[1024];

            Socket clientSocket;

            Socket listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            rtbMessage.AppendText("Server started!\n");

            String clientIP = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
            String clientPort = ((IPEndPoint)clientSocket.RemoteEndPoint).Port.ToString();
            rtbMessage.AppendText("Connection accepted from " + clientIP + ":" + clientPort);
            rtbMessage.AppendText(Environment.NewLine);

            while (clientSocket.Connected)
            {
                bytesReceived = clientSocket.Receive(recv);
                if (recv == System.Text.Encoding.ASCII.GetBytes("quit"))
                {
                    rtbMessage.AppendText("Connection closed\n");
                    clientSocket.Close();
                    listenerSocket.Close();
                    break;
                }
                String text = Encoding.ASCII.GetString(recv);

                rtbMessage.AppendText(text);
                rtbMessage.AppendText(Environment.NewLine);
                Array.Clear(recv, 0, recv.Length);
            }
        }
    }
}
