using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Mail : Form
    {
        private readonly ImapClient client;
        public Mail()
        {
            InitializeComponent();
            client = new ImapClient();
            buttonRefresh.Enabled = false;
            buttonSendMail.Enabled = false;
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (buttonSignIn.Text == "Đăng xuất")
            {
                DisconnectFromServer();
            }
            else
            {
                ConnectToServer();
            }
        }
        private void ConnectToServer()
        {
            if (string.IsNullOrEmpty(txtimap.Text))
                txtimap.Text = "imap.gmail.com";
            if (string.IsNullOrEmpty(txtimapport.Text))
                txtimapport.Text = "993";
            if (string.IsNullOrEmpty(txtsmtp.Text))
                txtsmtp.Text = "smtp.gmail.com";
            if (string.IsNullOrEmpty(txtsmtpport.Text))
                txtsmtpport.Text = "465";

            try
            {
                client.Connect(txtimap.Text, int.Parse(txtimapport.Text), true);
                client.Authenticate(txtEmail.Text.Trim(), txtmatkhau.Text.Trim());
                LoadEmails();
                EnableControlsAfterLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisconnectFromServer()
        {
            try
            {
                if (client.IsConnected)
                {
                    client.Disconnect(true);
                    MessageBox.Show("Đã đăng xuất");
                }
                else
                {
                    MessageBox.Show("Không có kết nối đến server");
                }
                ResetLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void LoadEmails()
        {
            listView1.Clear();
            listView1.Columns.Add("Email", 300);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Date", 150);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            int numberOfEmailsToLoad = 20;
            for (int i = 0; i < numberOfEmailsToLoad; i++)
            {
                var message = inbox.GetMessage(i);
                var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString(), message.HtmlBody });
                listView1.Items.Add(item);
            }
        }

        private void EnableControlsAfterLogin()
        {
            txtEmail.ReadOnly = true;
            txtmatkhau.ReadOnly = true;
            txtimap.ReadOnly = true;
            txtimapport.ReadOnly = true;
            txtsmtpport.ReadOnly = true;
            txtsmtp.ReadOnly = true;
            buttonRefresh.Enabled = true;
            buttonSendMail.Enabled = true;
            buttonSignIn.Text = "Đăng xuất";
        }

        private void ResetLoginForm()
        {
            txtEmail.ReadOnly = false;
            txtmatkhau.ReadOnly = false;
            txtimap.ReadOnly = false;
            txtimapport.ReadOnly = false;
            txtsmtpport.ReadOnly = false;
            txtsmtp.ReadOnly = false;
            buttonRefresh.Enabled = false;
            buttonSendMail.Enabled = false;
            txtEmail.Clear();
            txtmatkhau.Clear();
            txtimap.Clear();
            txtimapport.Clear();
            txtsmtpport.Clear();
            txtsmtp.Clear();
            listView1.Clear();
            buttonSignIn.Text = "Đăng nhập";
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem selectedItem = e.Item;
                string subject = listView1.SelectedItems[0].SubItems[0].Text;
                string From = listView1.SelectedItems[0].SubItems[1].Text;
                string emailContent = listView1.SelectedItems[0].SubItems[3].Text;
                if (listView1.SelectedItems.Count > 0)
                {
                    MailRead form2 = new MailRead(From, txtEmail.Text, subject, emailContent);
                    form2.Show();
                }
            }
        }
        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            MailSend sendMail = new MailSend(txtEmail.Text, txtmatkhau.Text, txtsmtp.Text, txtsmtpport.Text);
            sendMail.Show();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadEmails();
        }
    }
}
