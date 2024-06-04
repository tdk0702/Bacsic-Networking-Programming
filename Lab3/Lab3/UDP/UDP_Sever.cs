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

namespace Lab3.UDP
{
    public partial class UDP_Sever : Form
    {
        Socket udpSocket;
        private bool isListening;
        private byte[] buffer = new byte[1024];

        public UDP_Sever()
        {
            InitializeComponent();
        }

        private void UDP_Sever_Load(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            CheckForIllegalCrossThreadCalls = false;
            isListening = false;
        }

        private void StartListening()
        {
            udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            int port = Convert.ToInt32(tb_port.Text);
            udpSocket.Bind(new IPEndPoint(IPAddress.Any, port));
            EndPoint ipRec = new IPEndPoint(IPAddress.Any, 0);
            udpSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipRec, ReceiveCallback, null);
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                EndPoint ipRec = new IPEndPoint(IPAddress.Any, 0);
                int bytesRead = udpSocket.EndReceiveFrom(ar, ref ipRec);

                string data = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                rich_data.AppendText(data + "\r\n"); // Thêm chuỗi vào RichTextBox

                EndPoint newIpRec = new IPEndPoint(IPAddress.Any, 0);
                udpSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref newIpRec, ReceiveCallback, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        private void UDP_Sever_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpSocket.Close();
            isListening = false;
            btn_listen.Text = "Start Listening";
        }

        private void btn_listen_Click(object sender, EventArgs e)
        {
            if (isListening)
            {
                udpSocket.Close();
                isListening = false;
                btn_listen.Text = "Start Listening";
            }
            else
            {
                StartListening();
                isListening = true;
                btn_listen.Text = "Stop Listening";
            }
        }
    }
}
