using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MailKit.Net.Smtp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Task5
{
    public partial class Invite : Form
    {
        private string in4 = "";
        public Invite(Control control, string s)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(control);
            in4 = s;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string content = textBox1.Text;
            if (!string.IsNullOrEmpty(content))
            {
                ListViewItem item = new ListViewItem(content);
                listView1.Items.Add(item);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập email của bạn bè mà bạn muốn mời");
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            bool a = false;
            Config config = ConfigHelper.GetConfig();
            if (config.SSL == "true")
            {
                a = true;
            }
            string b = config.MailServer;
            int c = config.Port;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Connect(b, c, a);
                try
                {
                    smtpClient.Authenticate(config.Username, config.Password);
                    MimeMessage mimeMessage = new MimeMessage();
                    mimeMessage.From.Add(new MailboxAddress("", config.Username));
                    mimeMessage.To.Add(new MailboxAddress("", listView1.Items[i].Text));
                    mimeMessage.Subject = "Bạn có một lời mời đi ăn";
                    string[] chuoi = in4.Split(',');
                    string monan = chuoi[0];
                    string gia = chuoi[1];
                    string diachi = chuoi[2];
                    string imgurl = chuoi[4];
                    mimeMessage.Body = new TextPart("html")
                    {
                        Text = $@"<html>
                                <head>
                                    <title>Lời Mời Đi Ăn</title>
                                    <style>
                                        .class_body {{
                                            font-family: Arial, sans-serif;
                                            text-align: center;
                                            background-color: #f8f9fa;
                                            margin: 0;
                                            padding: 20px;
                                            display: flex;
                                            justify-content: center;
                                            align-items: center;
                                            }}

                                        .invitation {{
                                            background-color: #ffffff;
                                            border-radius: 10px;
                                            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                                            display: inline-block;
                                            padding: 20px;
                                            margin-top: 20px;
                                            text-align: center;
                                            }}

                                        .invitation img {{
                                            max-width: 100%;
                                            height: auto;
                                            border-radius: 10px;
                                            }}

                                        .invitation h1 {{
                                            color: #333333;
                                        }}

                                        .invitation p {{
                                            color: #666666;
                                        }}
                                    </style>
                                </head>

                                <body>
                                    <div class='class_body'>
                                        <div class='invitation'>
                                            <h1>Lời Mời Đi Ăn</h1>
                                            <p>Xin chào,</p>
                                            <p>Tôi muốn mời bạn đi ăn tối vào cuối tuần này. Hãy cùng thưởng thức món ăn ngon và có một buổi tối tuyệt vời
                                                cùng nhau!</p>
                                            <img src='{imgurl}' alt='Món ăn ngon'>
                                            <p>Món ăn: {monan}</p>
                                            <p>Giá: {gia}</p>
                                            <p>Địa chỉ: {diachi}</p>

                                            <p>Rất mong được gặp bạn!</p>
                                        </div>
                                    </div>
                                </body>
                            </html>"
                    };
                    smtpClient.Send(mimeMessage);
                    MessageBox.Show("Connection successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed");
                }
            }
        }
    }
}
