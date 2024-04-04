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

namespace Lab2.Form6
{
    public partial class Menu : Form
    {
        public static string Connectpath = @"Data source=.\SQLExpress;Initial Catalog=DISHES;Integrated Security = True";
        public class User
        {
            public string ID, name;
            public int permit;
            public User()
            {
                ID = name = string.Empty;
                permit = 2; // 0: Admin(Read & Write) 1: Editor (Write) 2: Guest (Read)
            }
            public User(string id, string name, int per)
            {
                this.ID = id;
                this.name = name;
                this.permit = per;
            }
            public bool isNull()
            {
                return string.IsNullOrEmpty(this.ID);
            }
        }
        public class Dish
        {
            public string ID, name, link, userid;
            public Dish() { ID = name = link = userid = string.Empty; }
            public Dish(string id, string name, string link, string user)
            {
                this.ID = id;
                this.name = name;
                this.link = link;
                this.userid = user;
            }
        }

        public static List<Dish> DishesList = new List<Dish>();
        public static User MainUser = new User();
        public Menu()
        {
            InitializeComponent();
        }

        private DataTable getData(string query)
        {
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
        public void loadData(DataTable dt)
        {
            DishesList = new List<Dish>(); 
            Dish dish;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dish = new Dish();
                dish.ID = dt.Rows[i]["IDMA"].ToString();
                dish.name = dt.Rows[i]["DName"].ToString();
                dish.link = dt.Rows[i]["DImage"].ToString();
                dish.userid = dt.Rows[i]["IDNCC"].ToString();
                DishesList.Add(dish);
            }

        }
        private void upData(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Connectpath);
            SQLConnect.Open();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            SQLConnect.Close();
        }

        private void loadListbox()
        {
            lsbShow.Items.Clear();
            foreach (Dish d in DishesList)
            {
                lsbShow.Items.Add(d.name);
            }
        }

        private void setPermit()
        {
            lbUser.Text = MainUser.name + " - ";
            switch (MainUser.permit)
            {
                case 0:
                    lbUser.Text += "Admin";
                    btnAdd.Enabled = true;
                    btnFind.Enabled = true;
                    break;
                case 1:
                    lbUser.Text += "Editor";
                    btnAdd.Enabled = true;
                    btnFind.Enabled = false;
                    break;
                case 2:
                    lbUser.Text += "Member";
                    btnAdd.Enabled = false;
                    btnFind.Enabled = true;
                    break;
            }
        }

        private void update_query(string name)
        {
            string id = DishesList.Count.ToString();
            while (id.Length < 3) id = '0' + id;
            DishesList.Add(new Dish(id, name, "ImageLink", MainUser.ID));
            string query = string.Format("Insert into DISH values (N'{0}', N'{1}', '{2}')", name, "ImageLink", MainUser.ID);
            upData(query);
        }

        private void delData(int pos)
        {
            string query = string.Format("DELETE FROM DISH WHERE IDMA={0}", DishesList[pos].ID);
            upData(query);
            DishesList.RemoveAt(pos);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxInput.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập món ăn");
                return;
            }
            update_query(tbxInput.Text.Trim());
            loadListbox();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            if (lsbShow.Items.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống.");
                return;
            }
            Random rand = new Random();
            int idx = rand.Next(0, lsbShow.Items.Count);
            tbxTemp.Text = lsbShow.Items[idx].ToString();
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) btnAdd_Click(this, new EventArgs());
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            while (MainUser.isNull())
            {
                Login log = new Login();
                log.ShowDialog();
            }
            setPermit();
            string query = "Select * from DISH";
            loadData(getData(query));
            loadListbox();
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.P)
            {
                Login log = new Login();
                log.ShowDialog();
                string query = "Select * from DISH";
                loadData(getData(query));
                loadListbox();
            }
            if (e.KeyCode == Keys.Delete && lsbShow.SelectedIndex != -1)
            {
                delData(lsbShow.SelectedIndex);
                loadListbox();
            }
            if (e.Shift && e.KeyCode == Keys.Delete)
            {
                DialogResult drs = MessageBox.Show("Bạn có chắc muốn xoá tất cả ?", "Lưu ý", MessageBoxButtons.YesNo);
                if (drs == DialogResult.Yes) { 
                    lsbShow.Items.Clear();
                    string query = "DELETE FROM DISH;";
                    upData(query);
                }
            }
        }
    }
}
