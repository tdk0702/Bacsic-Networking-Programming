using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit.Net.Smtp;
using MimeKit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Task123
{
    public partial class Navigator : Form
    {
        public Navigator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 task3 = new Task3();
            task3.Show();
        }
    }
}
