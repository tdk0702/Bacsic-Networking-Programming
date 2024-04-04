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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private List<Menu.User> UserList = new List<Menu.User>();
        private void upData(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Form6.Menu.Connectpath);
            SQLConnect.Open();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            try { cmd.ExecuteNonQuery(); }
            catch (SqlException expt) { MessageBox.Show("Tài khoản trùng lập. Err: " + expt.ToString()); return; }
            SQLConnect.Close();
            MessageBox.Show("Đã thêm tài khoản thành công.");
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Form6.Menu.MainUser = UserList[cbxChoose.SelectedIndex];
                this.Close();

                if (cbxChoose.SelectedIndex == UserList.Count)
                {
                    string[] str = tbxData.Text.Trim().Split(' ');
                    int per = -1;
                    try { per = int.Parse(str[str.Length - 1]); if (per > 2 || per < 0) throw new FormatException(); }
                    catch (FormatException expt)
                    {
                        MessageBox.Show("Vui lòng nhập quyền hạn là số" + expt.ToString());
                        return;
                    }
                    string id = UserList.Count.ToString(), name = string.Empty;
                    while (id.Length < 3) id = "0" + id;
                    id = "PS" + id;
                    for (int i = 0; i < str.Length - 1; i++) name += str[i] + " ";
                    string query = string.Format("Insert into PERSON VALUES('{0}',N'{1}',{2})", id, name.Trim(), per.ToString());
                    upData(query);
                    /*UserList.Add(new Menu.User(id, name.Trim(), per));
                    setComboBox();*/
                }
            }
        }

        private DataTable getData(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Form6.Menu.Connectpath);
            SQLConnect.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SQLConnect.Close();
            return dt;
        }

        private void loadData(DataTable dt)
        {
            Menu.User user;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                user = new Menu.User();
                user.ID = dt.Rows[i]["IDNCC"].ToString();
                user.name = dt.Rows[i]["PName"].ToString();
                user.permit = int.Parse(dt.Rows[i]["Permit"].ToString());
                UserList.Add(user);
            }
        }

        private void setComboBox()
        {
            string line = string.Empty;
            foreach(Menu.User user in UserList)
            {
                line = user.ID + " " + user.name;
                switch (user.permit)
                {
                    case 0:
                        line += " Admin";
                        break;
                    case 1:
                        line += " Editor";
                        break;
                    case 2:
                        line += " Member";
                        break;
                }
                cbxChoose.Items.Add(line);
            }
            cbxChoose.Items.Add("Thêm tài khoản...");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string query = "Select * from PERSON";
            loadData(getData(query));
            setComboBox();
        }

        private void cbxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxChoose.SelectedIndex == UserList.Count)
            {
                tbxData.ReadOnly = false;
            }
            else tbxData.ReadOnly = true;
        }

        private void tbxData_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
