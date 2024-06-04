using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using static System.Windows.Forms.LinkLabel;

namespace Task5
{
    public partial class FindFood : Form
    {
        private string receivedTokenType;
        private string receivedAccessToken;
        private int count = 0;
        List<string> thongtin = new List<string>();
        private string in4 = "";
        private int dem = 0;
        public FindFood(string tokentype, string accesstoken)
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true; // Bật thanh cuộn tự động
            flowLayoutPanel1.WrapContents = false; // Không tự động xuống dòng
            receivedTokenType = tokentype;
            receivedAccessToken = accesstoken;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 5;
            SendRequestAll(0, 5);
        }
        private readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        public class MonAnResponse
        {
            public List<MonAn> Data { get; set; }
        }
        private void Addprogressbar(string monan, string gia, string diachi, string nguoidonggop, PictureBox pictureBox)
        {
            Food food = new Food();
            food.Settenmonan(monan);
            food.Setgiamonan(gia);
            food.Setdiachi(diachi);
            food.Setnguoidonggop(nguoidonggop);
            food.SetPictureBox(pictureBox);
            flowLayoutPanel1.Controls.Add(food);
        }
        public class MonAn
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("ten_mon_an")]
            public string TenMonAn { get; set; }

            [JsonProperty("gia")]
            public decimal Gia { get; set; }

            [JsonProperty("mo_ta")]
            public string MoTa { get; set; }

            [JsonProperty("hinh_anh")]
            public string HinhAnh { get; set; }

            [JsonProperty("dia_chi")]
            public string DiaChi { get; set; }

            [JsonProperty("nguoi_dong_gop")]
            public string NguoiDongGop { get; set; }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu comboBox2 chưa được chọn thì không thực hiện gì
            if (comboBox2.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            if (count == 0)
            {
                await SendRequestAll(currentPage, pageSize);
            }
            else if (count == 1)
            {
                await SendRequestByMe(currentPage, pageSize);
            }
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            if (count == 0)
            {
                await SendRequestAll(currentPage, pageSize);
            }
            else if (count == 1)
            {
                await SendRequestByMe(currentPage, pageSize);
            }
        }
        private async Task SendRequestAll(int currentPage, int pageSize)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/all";
            var requestData = new
            {
                current = currentPage,
                pageSize = pageSize,
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                MonAnResponse responseObject = JsonConvert.DeserializeObject<MonAnResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();
                thongtin.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                foreach (var monAn in responseObject.Data)
                {
                    try
                    {
                        string monan = monAn.TenMonAn;
                        string gia = monAn.Gia.ToString();
                        string diachi = monAn.DiaChi;
                        string nguoidonggop = monAn.NguoiDongGop;
                        string imgurl = monAn.HinhAnh;
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Load(imgurl);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        string information = monan + "," + gia + "," + diachi + "," + nguoidonggop + "," + imgurl + ";";
                        thongtin.Add(information);
                        // Thêm Hienthimonan vào flowLayoutPanel1 với các giá trị tương ứng
                        Addprogressbar(monan, gia, diachi, nguoidonggop, pictureBox);
                    }
                    catch { }
                }
            }
        }

        private async Task SendRequestByMe(int currentPage, int pageSize)
        {
            string apiUrl = "https://nt106.uitiot.vn/api/v1/monan/my-dishes";
            var requestData = new
            {
                current = currentPage,
                pageSize = pageSize,
            };

            string jsonData = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            // Gửi yêu cầu POST đến API và nhận phản hồi
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, apiUrl);
            request.Content = content;
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(receivedTokenType, receivedAccessToken);

            HttpResponseMessage responses = await httpClient.SendAsync(request);

            if (responses.IsSuccessStatusCode)
            {
                string responseContent = await responses.Content.ReadAsStringAsync();
                MonAnResponse responseObject = JsonConvert.DeserializeObject<MonAnResponse>(responseContent);

                // Xóa tất cả các controls trong flowLayoutPanel1
                flowLayoutPanel1.Controls.Clear();
                thongtin.Clear();

                // Hiển thị dữ liệu mới từ phản hồi
                foreach (var monAn in responseObject.Data)
                {
                    try
                    {
                        string monan = monAn.TenMonAn;
                        string gia = monAn.Gia.ToString();
                        string diachi = monAn.DiaChi;
                        string nguoidonggop = monAn.NguoiDongGop;
                        string imgurl = monAn.HinhAnh;
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Load(imgurl);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        string information = monan + "," + gia + "," + diachi + "," + nguoidonggop + "," + imgurl + ";";
                        thongtin.Add(information);
                        Addprogressbar(monan, gia, diachi, nguoidonggop, pictureBox);
                    }
                    catch { }
                }
            }
        }

        public Control GetRandomControl()
        {
            Control randomControl = null;
            List<Control> allControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();

            if (allControls.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(0, allControls.Count);
                randomControl = allControls[randomIndex];
                in4 = thongtin[randomIndex];
            }
            return randomControl;
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Control randomControl = GetRandomControl();
            if (randomControl != null)
            {
                // Gửi control đã chọn đến Form2
                ShowFood sf = new ShowFood(randomControl, in4, dem);
                sf.Show();
            }
            else
            {
                MessageBox.Show("Không có control nào để hiển thị.");
            }
            dem++;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddFood them = new AddFood(receivedTokenType, receivedAccessToken);
            them.Show();
        }

        private async void btn_all_Click(object sender, EventArgs e)
        {
            count = 0;
            if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            await SendRequestAll(currentPage, pageSize);
        }

        private async void btn_byme_Click(object sender, EventArgs e)
        {
            count = 1;
            if (comboBox2.SelectedItem == null || comboBox1.SelectedItem == null)
                return;

            int currentPage = int.Parse(comboBox1.SelectedItem.ToString());
            int pageSize = int.Parse(comboBox2.SelectedItem.ToString());
            await SendRequestByMe(currentPage, pageSize);
        }
    }
}