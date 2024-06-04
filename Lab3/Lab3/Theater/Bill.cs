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


namespace Lab3.Theater
{
    public partial class Bill : Form
    {
        private string clientname;
        public Bill()
        {
            InitializeComponent();
        }
        public Bill(string clname)
        {
            InitializeComponent();
            clientname = clname;
        }



        private long getPrice()
        {
            long temp = 0;
            temp += Seat.seatCount.normal*MoviePrice.normal;
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
           MessageBox.Show("Đã xong.");
            this.Close();
        }

        private void Bill_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
