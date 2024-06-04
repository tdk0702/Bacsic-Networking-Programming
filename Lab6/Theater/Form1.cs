using System.Net;
using System.Net.Mail;
using HtmlAgilityPack;
namespace Theater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Function();
        }

        private void Function()
        {
            string path = Application.StartupPath + @"db\HtmlText.txt";
            StreamReader sr = new StreamReader(path);
            string html = sr.ReadToEnd();
            sr.Close();
        }
    }
}
