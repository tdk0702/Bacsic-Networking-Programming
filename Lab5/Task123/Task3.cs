using MailKit.Net.Pop3;

namespace Task123
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private string pop3_password = "password";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lvEmail.Items.Clear();
            var client = new Pop3Client();
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate(txtEmail.Text, txtPassword.Text);
            int limit = 0;
            for (int i = client.Count - 1; i >= 0; i--)
            {
                var message = client.GetMessage(i);
                ListViewItem item = new ListViewItem();
                item.Text = message.From.ToString();
                item.SubItems.Add(message.Subject);
                item.SubItems.Add(message.Date.DateTime.ToString()); 
                lvEmail.Items.Add(item);
                limit++;
                if (limit == 5) break;
            }
            client.Disconnect(true);
        }
    }
}
