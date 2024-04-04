using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Form5
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        public class Price
        {
            Home.Movie movie;
            public long normal, vip, sweet;
            public Price()
            {
                movie = new Home.Movie();
                normal = vip = sweet = 0;
            }
            public Price(Home.Movie m)
            {
                this.movie = m;
                this.normal = m.price;
                this.vip = m.price +10; 
                this.sweet = m.price*2 + 30;
            }
        }

        private long getPrice()
        {
            long temp = 0;
            temp += Seat.seatCount.normal*MoviePrice.normal;
            temp += Seat.seatCount.vip * MoviePrice.vip;
            temp += Seat.seatCount.sweet * MoviePrice.sweet;
            return temp;
        }
        static Price MoviePrice = new Price(Seat.MovieChosen);
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
            lvi.SubItems.Add(count.ToString());
            lvi.SubItems.Add(price.ToString());
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
    }
}
