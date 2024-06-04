using MailKit;
using MailKit.Net.Imap;

namespace Task123
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private string imap_password = "password";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lvEmail.Items.Clear();
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            client.Authenticate(txtEmail.Text, txtPassword.Text);
            IMailFolder inbox = client.Inbox;
            int limit = 0;
            inbox.Open(FolderAccess.ReadOnly);
            label3.Text += " " + inbox.Count;
            label4.Text += " 5";
            for (int i = inbox.Count - 1; i >= 0; i--)
            {
                var message = inbox.GetMessage(i);
                ListViewItem item = new ListViewItem();
                item.Text = message.From.ToString();
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.Date.DateTime.ToString());
                lvEmail.Items.Add(item);
                limit++;
                if (limit == 5) break;
            }
        }
    }
}
