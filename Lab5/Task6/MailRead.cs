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
    public partial class MailRead : Form
    {
        private string EmailContent;
        public MailRead(string From, string to, string title, string EmailContent)
        {
            InitializeComponent();
            labelFromName.Text = From;
            labelToMail.Text = to;
            labelTitle.Text = title;
            this.EmailContent = EmailContent;
        }
        private void ReadMail_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = EmailContent;
        }
    }
}

