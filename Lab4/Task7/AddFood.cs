using Newtonsoft.Json.Linq;
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

namespace Task7
{
    public partial class AddFood : Form
    {
        private string tokentype;
        private string accesstoken;
        public AddFood(string tokenType, string accessToken)
        {
            InitializeComponent();
            tokentype = tokenType;
            accesstoken = accessToken;
        }

        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            tb_price.Clear();
            tb_adrr.Clear();
            tb_image.Clear();
            tb_describe.Clear();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/add";
            var requestData = new
            {
                ten_mon_an = tb_name.Text,
                gia = tb_price.Text,
                mo_ta = tb_describe.Text,
                hinh_anh = tb_image.Text,
                dia_chi = tb_adrr.Text
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokentype, accesstoken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                if(pct_food.Image == null)
                {
                    MessageBox.Show("Địa chỉ hình ảnh bị lỗi");
                    return;
                }
                MessageBox.Show("Bạn đã thêm món ăn thành công");
            }
            else
            {
                MessageBox.Show("Món ăn chưa được thêm");
            }
        }

        private void tb_image_TextChanged(object sender, EventArgs e)
        {
            string imageUrl = tb_image.Text;
            pct_food.ImageLocation = imageUrl;
        }
    }
}
