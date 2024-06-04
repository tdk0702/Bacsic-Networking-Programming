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

namespace Lab2.Form5
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void upDate(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(Home.Connectpath);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private DataTable get_DataTable(string query)
        {
            SqlConnection SQLConnect = new SqlConnection(Home.Connectpath);
            SQLConnect.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, SQLConnect);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SQLConnect.Close();
            return dt;
        }
        private void inputData(string name, string origin, int price, List<int> arr)
        {
            string insertcmd = string.Format("INSERT INTO INFO VALUES(N'{0}',N'{1}',{2})",name, origin, price.ToString());
            upDate(insertcmd);
            DataTable dt = get_DataTable(string.Format("Select Id from INFO where Mname = N'{0}',Origin=N'{1}',Price={3}", name, origin, price.ToString()));
            string id = dt.Rows[0]["Id"].ToString();
            foreach (int num in arr)
            {
                insertcmd = string.Format("INSERT INTO THEATERS VALUES({0},{1})",id, num.ToString());
                upDate(insertcmd);
            }
            MessageBox.Show("Đã thêm dữ liệu Movie");
        }
        private void getDataFormtbxData(string data)
        {
            List<int> arr = new List<int>();
            string[] dataArr = data.Split(' ');
            if (dataArr.Length<4)
            {
                MessageBox.Show("Nhập không đủ dữ liệu.");
                return;
            }
            int price = 0;
            try { price = int.Parse(dataArr[2]); }
            catch (FormatException expt)
            {
                MessageBox.Show("Giá vé phải là một số nguyên. Err: " + expt.ToString());
            }
            try
            {
                for (int i = 3; i < dataArr.Length; i++)
                    arr.Add(int.Parse(dataArr[i]));
            }
            catch (FormatException expt)
            {
                MessageBox.Show("Tên phòng chiếu phải là một số nguyên. Err: " + expt.ToString());
            }
            string insertcmd = string.Format("INSERT INTO INFO VALUES(N'{0}',N'{1}',{2})", dataArr[0], dataArr[1], price.ToString());
            upDate(insertcmd);
            DataTable dt = get_DataTable(string.Format("Select Id from INFO where Mname = N'{0}',Origin=N'{1}',Price={3}", dataArr[0], dataArr[1], price));
            string id = dt.Rows[0]["Id"].ToString();
            foreach (int num in arr)
            {
                insertcmd = string.Format("INSERT INTO THEATERS VALUES({0},{1})", id, num.ToString());
                upDate(insertcmd);
            }
            MessageBox.Show("Đã thêm dữ liệu Movie");
        }
        private void tbxData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(tbxData.Text)) getDataFormtbxData(tbxData.Text.Trim());
                List<int> theaArr = new List<int>();
                int price=0;
                try
                {
                    price = int.Parse(tbxPrice.Text.Trim());
                }
                catch (FormatException expt)
                {
                    MessageBox.Show("Giá tiền phải có giá trị là số nguyên. Err:" + expt.ToString());
                    return;
                }
                string[] theaternum = tbxTheater.Text.Trim().Split(' ');
                try
                {
                    int num = 0;
                    foreach(string str in theaternum)
                    {
                        num = int.Parse(str);
                        theaArr.Add(num);
                    }
                }
                catch (FormatException expt)
                {
                    MessageBox.Show("Phòng chiếu phải là mảng số nguyên. Err:" + expt.ToString());
                    return;
                }
                inputData(tbxName.Text.Trim(),tbxOrigin.Text.Trim(), price, theaArr);
            }
        }
    }
}
