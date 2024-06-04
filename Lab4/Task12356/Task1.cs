using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task12356
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            rb_show.Text = getHTML(tb_url.Text);
        }

        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            var task2 = new Task2();
            task2.Show();
        }
    }
}
