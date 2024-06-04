using System;
using System.Net;
using System.Security.Policy;

namespace Task12356
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        string url;

        private void btn_Click(object sender, EventArgs e)
        {
            url = tb_url.Text;
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            myClient.DownloadFile(url, tb_down.Text);
            response.Close();
            try
            {
                rb_show.Text = File.ReadAllText(tb_down.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var task3 = new Task3();
            task3.Show();
        }
    }
}
