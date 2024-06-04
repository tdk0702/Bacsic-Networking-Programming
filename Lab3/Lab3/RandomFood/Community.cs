using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.RandomFood
{
    public partial class Community : Form
    {
        public Community()
        {
            InitializeComponent();
            Connect();
        }

        TcpClient tcpClient;
        void Connect()
        {
            tcpClient = new TcpClient();
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
            try
            {
                tcpClient.Connect(ipEndPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối đến Server, hãy Thử lại sau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        string imageLocation = "";
        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.jpeg)|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName;
                cb_image.Checked = true;
            }
            else
            {
                MessageBox.Show("Chọn ảnh không thành công", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                imageLocation = "";
                cb_image.Checked = false;
            }
        }

        string data = "";

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_food.Text == "" || tb_name.Text == "" || cb_image.Checked == false)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data = $"@@@\n{tb_name.Text}\n{tb_food.Text}";

            NetworkStream ns = tcpClient.GetStream();
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(data);
            ns.Write(buffer, 0, buffer.Length);
            ns.Flush();

            using (FileStream fs = new FileStream(imageLocation, FileMode.Open, FileAccess.Read))
            {
                byte[] imageBytes = new byte[fs.Length];
                fs.Read(imageBytes, 0, imageBytes.Length);
                ns.Write(imageBytes, 0, imageBytes.Length);
                ns.Flush();
            }
            ns.Close();
            tb_food.Clear();
            imageLocation = "";
            cb_image.Checked = false;
        }

        private void Community_FormClosed(object sender, FormClosedEventArgs e)
        {
            tcpClient.Dispose();
            tcpClient.Close();
        }
    }
}
