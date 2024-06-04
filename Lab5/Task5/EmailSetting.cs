using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace Task5
{
    public partial class EmailSetting : Form
    {
        public EmailSetting()
        {
            InitializeComponent();
            txtimap.Text = "imap.gmail.com";
            txtsmtp.Text = "smtp.gmail.com";
            numericUpDown1.Value = 993;
            numericUpDown2.Value = 465;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (checkBox2.Checked)
            {
                b = true;
            }
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect(txtsmtp.Text, (int)numericUpDown2.Value, b);
            try
            {
                smtpClient.Authenticate(txtname.Text, txtmatkhau.Text);
                MimeMessage mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(txtnickname.Text, txtname.Text));
                mimeMessage.To.Add(new MailboxAddress("", "d0905206126@gmail.com"));
                mimeMessage.Body = new TextPart("plain")
                {
                    Text = "Test",
                };
                smtpClient.Send(mimeMessage);
                MessageBox.Show("Connection successful");
            }
            catch
            {
                MessageBox.Show("Connection failed");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string a = "false";
            if (checkBox2.Checked)
            {
                a = "true";
            }
            string mailServer = txtsmtp.Text;
            int port = (int)numericUpDown2.Value;
            string username = txtname.Text;
            string password = txtmatkhau.Text;
            string nickname = txtnickname.Text;
            // Lưu thông tin cấu hình vào SQLite
            ConfigHelper.SaveConfig(mailServer, port, username, password, a, nickname);
            MessageBox.Show("Config saved successfully!");
            this.Hide();
            this.Close();
        }
    }
}
