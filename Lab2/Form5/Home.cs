using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Lab2.Form5
{
    public partial class Home : Form
    {

        private static string Datapath = "resources\\data.txt";
        public static string Connectpath = @"Data source=.\SQLExpress;Initial Catalog=MOVIE;Integrated Security = True";
        public class Movie
        {
            public string name, origin, id;
            public long price;
            public List<int> arrRoom;
            public Movie()
            {
                name = origin = id = string.Empty;
                price = 0;
                arrRoom = new List<int>();
            }
            public Movie(string id, string name, string origin, long price, List<int> arrRoom)
            {
                this.id = id;
                this.name = name;
                this.origin = origin;
                this.price = price;
                this.arrRoom = arrRoom;
            }
        }
        public static List<Movie> MovieList = new List<Movie>();
        public Home()
        {
            InitializeComponent();
        }

        private DataTable get_DataTable(string query) {
            SqlConnection SQLConnect = new SqlConnection(Connectpath);
            SQLConnect.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SQLConnect.Close();
            return dt;
        }
        private void readData(DataTable dt)
        {
            pgbMovie.Maximum = dt.Rows.Count;
            pgbMovie.Value = 0;
            Movie movie;
            string queryArr, name, origin, id;
            long price=0;
            List<int> arr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = dt.Rows[i]["id"].ToString();
                name = dt.Rows[i]["Mname"].ToString();
                origin = dt.Rows[i]["Origin"].ToString();
                price = long.Parse(dt.Rows[i]["Price"].ToString());
                queryArr = "SELECT idtheater FROM MOVIE.dbo.THEATERS WHERE id=" + id;
                DataTable dta = get_DataTable(queryArr);
                arr = new List<int>();
                for(int j=0;j< dta.Rows.Count;j++)
                {
                    arr.Add(int.Parse(dta.Rows[j]["Idtheater"].ToString()));
                }
                movie = new Movie(id,name, origin, price, arr);
                MovieList.Add(movie);
                pgbMovie.Value++;
            }
        }
        private void clearMovie()
        {
            gbxMovie1.Text = string.Empty;
            lbMovie1.Text = string.Empty;
            gbxMovie2.Text = string.Empty;
            lbMovie2.Text = string.Empty;
            gbxMovie3.Text = string.Empty;
            lbMovie3.Text = string.Empty;
            gbxMovie4.Text = string.Empty;
            lbMovie4.Text = string.Empty;
            btnGo1.Visible = false;
            btnGo2.Visible = false;
            btnGo3.Visible = false;
            btnGo4.Visible = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            clearMovie();
            string data = string.Empty;
            string sql = "Select * from MOVIE.dbo.INFO";
            readData(get_DataTable(sql));
            if (int.Parse(lbTitle.Tag.ToString()) >= (MovieList.Count / 4) - 1) btnNext.Enabled = false;
            showMovie(int.Parse(lbTitle.Tag.ToString()));
        }

        private string showContext(Movie m)
        {
            return string.Format("Tên gốc: {0}\r\nGiá vé chuẩn: {1}.000đ\r\nPhòng chiếu: 1, 2, 3",m.origin, m.price.ToString(), string.Join(", ", m.arrRoom));
        }
        private void showMovie(int pos)
        {
            gbxMovie1.Text = MovieList[pos * 4].name;
            lbMovie1.Text = showContext(MovieList[pos * 4]); 
            btnGo1.Visible = true;
            if (pos * 4 + 1 >= MovieList.Count) return;
            gbxMovie2.Text = MovieList[pos * 4 + 1].name;
            lbMovie2.Text = showContext(MovieList[pos * 4 + 1]);
            btnGo2.Visible = true;
            if (pos * 4 + 2 >= MovieList.Count) return;
            gbxMovie3.Text = MovieList[pos * 4 + 2].name;
            lbMovie3.Text = showContext(MovieList[pos * 4 + 2]);
            btnGo3.Visible = true;
            if (pos * 4 + 3 >= MovieList.Count) return;
            gbxMovie4.Text = MovieList[pos * 4 + 3].name;
            lbMovie4.Text = showContext(MovieList[pos * 4 + 3]);
            btnGo4.Visible = true;
        }

        private void addMovie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.N)
            {
                AddMovie am = new AddMovie();
                am.ShowDialog();
                Home_Load(this, new EventArgs());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(lbTitle.Tag.ToString());
            lbTitle.Tag = pos - 1;
            if (pos <= 0) btnBack.Enabled = false;
            if (pos < (MovieList.Count / 4)-1) btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(lbTitle.Tag.ToString());
            lbTitle.Tag = pos + 1;
            if (pos > 0) btnBack.Enabled = true;

            if (pos >= (MovieList.Count / 4)-1) btnNext.Enabled = false;
        }

        private void btnGo1_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()));
        }

        private void btnGo2_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()) + 1);
        }

        private void btnGo3_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()) + 2);
        }

        private void btnGo4_Click(object sender, EventArgs e)
        {
            openSeatForm(int.Parse(lbTitle.Tag.ToString()) + 3);
        }
        private void openSeatForm(int pos)
        {
            ChooseTicket ct = new ChooseTicket();
            ct.ShowDialog();
        }
    }
}
