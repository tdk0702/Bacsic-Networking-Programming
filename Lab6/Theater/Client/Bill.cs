using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.IO;
using System.Net.Mail;
using System.Net;


namespace Theater.Client
{
    public partial class Bill : Form
    {
        private string clientname;
        private Class.User ClientUser;
        public Bill()
        {
            InitializeComponent();
        }
        public Bill(Class.User user, string clname)
        {
            InitializeComponent();
            clientname = clname;
            ClientUser = user;
        }



        private long getPrice()
        {
            long temp = 0;
            temp += Seat.seatCount.normal * MoviePrice.normal;
            temp += Seat.seatCount.vip * MoviePrice.vip;
            temp += Seat.seatCount.sweet * MoviePrice.sweet;
            return temp;
        }
        static Class.Price MoviePrice = new Class.Price(Seat.MovieChosen);
        private void Bill_Load(object sender, EventArgs e)
        {
            lbName.Text = Seat.MovieChosen.name;
            tbxDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tbxPrice.Text = (getPrice().ToString() + ".000đ").ToString();
            tbxSeat.Text = string.Join(", ", Seat.seatCount.Name);
            tbxTheater.Text = Seat.seatCount.theater;
            lvLoad();
        }
        private ListViewItem addLvItem(string name, int count, long price)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(price.ToString());
            lvi.SubItems.Add(count.ToString());
            lvi.SubItems.Add((count*price).ToString());
            return lvi;
        }
        private void lvLoad()
        {
            lvPrice.Items.Clear();
            ListViewItem lvi = new ListViewItem();
            lvPrice.Items.Add(addLvItem("Ghế thường", Seat.seatCount.normal, MoviePrice.normal));
            lvPrice.Items.Add(addLvItem("Ghế VIP", Seat.seatCount.vip, MoviePrice.vip));
            lvPrice.Items.Add(addLvItem("SweetBox", Seat.seatCount.sweet, MoviePrice.sweet));
        }

        private void upData(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(Home.Connectpath);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            try { cmd.ExecuteNonQuery(); }
            catch (SqlException expt) { MessageBox.Show("Query sai định dạng. Err" + expt.ToString()); return; }
            sqlConnection.Close();
        }

        private void Bill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter) btnAccept_Click(this, new EventArgs());
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string query = string.Format("Insert into TICKER Values({0}, {1}, {2}, '{3}');", Seat.seatCount.id, Seat.MovieChosen.id, getPrice().ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
            string ack = Home.GetData(clientname, query);
            if (!ack.Contains("[ACK]")) { Console.WriteLine("Insert TICKER Err: " + ack); return; };
            query = string.Format("SELECT Id FROM TICKER WHERE Idtheater = {0} AND Idmovie = {1} AND Price = {2} AND FORMAT(Datet, 'yyyy-MM-dd') =  '{3}';", Seat.seatCount.id, Seat.MovieChosen.id, getPrice().ToString(), DateTime.Now.ToString("yyyy-MM-dd"));
            string idticker = Home.GetData(clientname, query);
            if (idticker.Contains(";")) idticker = idticker.Split(';')[0]; 
            foreach (string id in Seat.seatCount.Name)
            {
                query = string.Format("Insert into BUYED Values({0}, '{1}');", idticker, id);
                ack = Home.GetData(clientname, query);
                if (!ack.Contains("[ACK]")) { Console.WriteLine("Insert BUYED Err: " + ack); return; };
            }
            sendMail();
           MessageBox.Show("Đã xong.");
            this.Close();
        }

        private void sendMail()
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential credential = new NetworkCredential(
                "tdk.movietheater@gmail.com", "yiqesclvtxxtmvhn");
            MailMessage message = new MailMessage();
            smtp.Credentials = credential;
            smtp.EnableSsl = true;
            message.From = new MailAddress("tdk.movietheater@gmail.com", "Movie Theater");
            message.To.Add(new MailAddress(ClientUser.email));
            message.Subject = "PHẢN HỒI VÉ XEM PHIM";
            message.Body = MailText();
            message.IsBodyHtml = true;
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex) { Console.WriteLine("Lỗi gửi email!"); }
            smtp.Dispose();
        }
        private string MailText()
        {
            string path = Application.StartupPath + @"db\HtmlText.txt";
            StreamReader sr = new StreamReader(path);
            string html = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(html);
            html = html.Replace("\r\n", "");
            html = html.Replace("\t", "");
            html = html.Replace("{0}", Seat.MovieChosen.img);
            html = html.Replace("{1}", ClientUser.username);
            html = html.Replace("{2}", Seat.MovieChosen.name);
            html = html.Replace("{3}", Seat.seatCount.theater);
            html = html.Replace("{4}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            html = html.Replace("{5}", string.Join(",", Seat.seatCount.Name));
            html = html.Replace("{6}", htmlPrice());
            html = html.Replace("{7}", getPrice().ToString());
            return html;
        }
        private string htmlPrice()
        {
            string html = string.Empty;
            if (Seat.seatCount.normal > 0) 
                html += string.Format("<tr><td/><td style=\"text-align:right;font-size:13px;\">{0} x <span class=\"price\">{1}.000VNĐ</span></td></tr>\r\n"
                    ,Seat.seatCount.normal, MoviePrice.normal);
            if (Seat.seatCount.vip > 0)
                html += string.Format("<tr><td/><td style=\"text-align:right;font-size:13px;\">{0} x <span class=\"price\">{1}.000VNĐ</span></td></tr>\r\n"
                    , Seat.seatCount.vip, MoviePrice.vip);
            if (Seat.seatCount.sweet > 0)
                html += string.Format("<tr><td/><td style=\"text-align:right;font-size:13px;\">{0} x <span class=\"price\">{1}.000VNĐ</span></td></tr>\r\n"
                    , Seat.seatCount.sweet, MoviePrice.sweet);
            return html;
        }
        private void Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
