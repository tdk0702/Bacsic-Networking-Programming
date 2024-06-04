using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Task3
{
    public partial class Client : Form
    {
        TcpClient tcpClient;
        IPEndPoint iep;
        NetworkStream ns;

        public Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            tcpClient.Connect(iep);
            ns = tcpClient.GetStream();

            btnConnect.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes(rtbMessage.Text);
            ns.Write(data, 0, data.Length);
            rtbMessage.Clear();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Byte[] data = System.Text.Encoding.ASCII.GetBytes("quit");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
        }
    }
}
