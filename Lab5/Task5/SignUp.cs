using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Signup : Form
    {
        string a;
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtmatkhau.Clear();
            txtemail.Clear();
            txtfirst.Clear();
            txtlast.Clear();
            txtphone.Clear();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Male")
            {
                a = "1";
            }
            else
            {
                a = "0";
            }
            var userData = new
            {
                username = txtname.Text,
                email = txtemail.Text,
                password = txtmatkhau.Text,
                first_name = txtfirst.Text,
                last_name = txtlast.Text,
                sex = a,
                birthday = dateTimePicker1.Text,
                language = comboBox1.SelectedItem.ToString(),
                phone = txtphone.Text
            };

            // Chuyển đổi dữ liệu thành chuỗi JSON
            string jsonData = JsonConvert.SerializeObject(userData);

            // Đường dẫn API
            string apiUrl = "https://nt106.uitiot.vn/api/v1/user/signup";

            // Tạo đối tượng HttpClient
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Tạo nội dung yêu cầu từ chuỗi JSON
                    var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

                    // Thực hiện yêu cầu POST
                    var response = await httpClient.PostAsync(apiUrl, content);

                    // Đọc nội dung phản hồi
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Hiển thị mã phản hồi và nội dung phản hồi
                    Console.WriteLine($"HTTP Status Code: {response.StatusCode}");
                    Console.WriteLine($"Response Content: {responseContent}");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
