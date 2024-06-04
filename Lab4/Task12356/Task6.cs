using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Task12356
{
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://nt106.uitiot.vn/")
        };

        private async void btn_get_Click(object sender, EventArgs e)
        {
            rtb_data.Clear();
            client.DefaultRequestHeaders.Clear();
            string token = tb_token.Text;

            // Add token to header
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "/api/v1/user/me");

            HttpResponseMessage response = await client.SendAsync(request);

            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();
                JObject jsonObj = JObject.Parse(data);
                if (response.IsSuccessStatusCode)
                {
                    rtb_data.Text = "Get user info success\n";
                    // Get all fields
                    foreach (var item in jsonObj)
                    {
                        rtb_data.AppendText(item.Key + ": " + item.Value + "\n");
                    }
                }
                else
                {
                    rtb_data.Text = "Get user info failed";
                }
            }
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            tb_token.Text = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6ImFkbWluIiwiZXhwIjoxNzE1ODUxOTk1fQ.7nLNz3CfNr76HjaULA7ueIofeuDn47akCFm-CSf-xSc";
        }
    }
}
