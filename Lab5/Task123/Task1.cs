using MimeKit;

namespace Task123
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private string SMTPHost = "smtp.gmail.com";
        private const int SMTPPort = 465;
        private string smtp_password = "yvpkonoeexzevugz";
        private string username = "22520702@gm.uit.edu.vn";

        private void btnSend_Click(object sender, EventArgs e)
        {

            MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient();
            client.Connect(SMTPHost, SMTPPort, true);
            client.Authenticate(username, smtp_password);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("name", tbxFrom.Text));
            message.To.Add(new MailboxAddress("", tbxTo.Text));
            message.Subject = tbxSubject.Text;
            message.Body = new TextPart("plain")
            {
                Text = tbxBody.Text
            };
            client.Send(message);
        }
    }
}
