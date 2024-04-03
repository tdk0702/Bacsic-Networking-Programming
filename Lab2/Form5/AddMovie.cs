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
        private void inputData(string name, string origin, int price, List<int> arr)
        {
            string id = Home.MovieList.Count.ToString();
            while (id.Length < 3) id = "0" + id;
            string insertcmd = string.Format("INSERT INTO INFO VALUES({0},N'{1}',N'{2}',{3})",id, name, origin, price.ToString());
            SqlConnection sqlConnection = new SqlConnection(Home.Connectpath);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(insertcmd, sqlConnection);
            cmd.ExecuteNonQuery();
            foreach (int num in arr)
            {
                insertcmd = string.Format("INSERT INTO THEATERS VALUES({0},{1})",id, num.ToString());
                cmd = new SqlCommand(insertcmd, sqlConnection);
                cmd.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }
        private void getDataFormtbxData(string data)
        {
            List<int> arr = new List<int>();
            string id = Home.MovieList.Count.ToString();
            while (id.Length < 3) id = "0" + id;
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
            string insertcmd = string.Format("INSERT INTO INFO VALUES({0},N'{1}',N'{2}',{3})",id, dataArr[0], dataArr[1], price.ToString());
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
