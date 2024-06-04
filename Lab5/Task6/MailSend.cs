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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit.Net.Smtp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Task6
{
    public partial class MailSend : Form
    {
        public MailSend(string From, string Pass, string addrSMTP, string portSMTP)
        {
            InitializeComponent();
            txtfrom.ReadOnly = true;
            txtfile.ReadOnly = true;
            txtfrom.Text = From;
            this.Pass = Pass;
            this.addrSMTP = addrSMTP;
            this.portSMTP = portSMTP;
        }
        string Pass;
        string addrSMTP, portSMTP;
        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect(addrSMTP, int.Parse(portSMTP), true);
                client.Authenticate(txtfrom.Text.Trim(), Pass);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(txtname.Text, txtfrom.Text.Trim()));
                message.To.Add(new MailboxAddress("", txtto.Text.Trim()));
                message.Subject = txtsubject.Text.Trim();

                message.Body = new TextPart();
                var bodyBuilder = new BodyBuilder();
                if (checkBoxHtml.Checked == true)
                {
                    bodyBuilder.HtmlBody = richTextBox1.Text;
                }
                else
                {
                    bodyBuilder.TextBody = richTextBox1.Text;
                }
                string filePath = txtfile.Text;
                if (!string.IsNullOrEmpty(filePath))
                {
                    bodyBuilder.Attachments.Add(filePath);
                }
                message.Body = bodyBuilder.ToMessageBody();

                client.Send(message);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtfile.Text = filePath;
            }
        }
    }
}
