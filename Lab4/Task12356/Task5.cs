using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Task12356
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://nt106.uitiot.vn/")
        };

        private async void btn_login_Click(object sender, EventArgs e)
        {
            rtb_data.Clear();
            string username = tb_user.Text;
            string password = tb_password.Text;

            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            HttpResponseMessage response = await client.PostAsync("/auth/token", formContent);
            using (HttpContent content = response.Content)
            {
                string data = await content.ReadAsStringAsync();
                JObject jsonObj = JObject.Parse(data);
                if (response.IsSuccessStatusCode)
                {
                    if (jsonObj["access_token"] != null)
                    {
                        rtb_data.Text = "Login success\n";
                        string token_type = (string)jsonObj["token_type"];
                        string access_token = (string)jsonObj["access_token"];
                        rtb_data.AppendText("Token type: " + token_type + "\n");
                        rtb_data.AppendText("Access token: " + access_token + "\n");

                    }
                    else
                    {
                        rtb_data.Text = "Login failed";
                    }
                }
                else
                {
                    rtb_data.AppendText("Detail: " + jsonObj["detail"]);
                }
            }
        }

        private void btn_default_Click(object sender, EventArgs e)
        {
            tb_user.Text = "admin";
            tb_password.Text = "admin";
        }
    }
}
