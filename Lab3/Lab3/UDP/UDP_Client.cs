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
    public partial class UDP_Client : Form
    {
        public UDP_Client()
        {
            InitializeComponent();
        }

        private void btn_sent_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            IPAddress ipadd = IPAddress.Parse(tb_ip.Text);
            int port = Convert.ToInt32(tb_port.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);

                // Tạo dữ liệu theo định dạng mong muốn: "From (địa chỉ IP): (nội dung gửi)"
            string messageToSend = $"From {tb_ip.Text}: {tb_messa.Text}";

            Byte[] sendBytes = Encoding.UTF8.GetBytes(messageToSend);
            udpClient.Send(sendBytes, sendBytes.Length, ipend);
            tb_messa.Clear();
        }
    }
}
