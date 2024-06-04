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
using System.Security.Principal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab3.RandomFood
{
    public partial class Menu : Form
    {
        public static string person = string.Empty;
        public Menu()
        {
            InitializeComponent();
        }

        // Tạo danh sách tài khoản và mật khẩu
        List<string> accountList = new List<string>();
        private void btn_person_Click(object sender, EventArgs e)
        {
            bool check = false;
            accountList.Clear();
            // Lấy thông tin tài khoản và mật khẩu từ file
            string filePath = "profile.txt";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                string[] lines = content.Split('\n');
                foreach (string line in lines)
                {
                    accountList.Add(line);
                }
                foreach (string accout in accountList)
                {                    
                    string[] infor = accout.Split(' ');
                    if (tb_name.Text == "" || tb_pass.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (tb_name.Text == infor[0].Trim() && tb_pass.Text == infor[1].Trim())
                    {
                        person = tb_name.Text;
                        tb_name.Clear();
                        tb_pass.Clear();
                        var formperson = new Person();
                        formperson.Show();
                        check = true;
                        break;
                    }
                }
            }
            if (!check)
            {
                tb_pass.Clear();
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản và mật khẩu từ file
            accountList.Clear();
            bool check = false;
            string filePath = "profile.txt";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                string[] lines = content.Split('\n');
                foreach (string line in lines)
                {
                    accountList.Add(line.Trim());
                }
                foreach (string accout in accountList)
                {
                    string[] infor = accout.Split(' ');
                    if (tb_name.Text == "" || tb_pass.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (tb_name.Text == infor[0].Trim())
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check)
            {
                tb_pass.Clear();
                MessageBox.Show("Tài khoản đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
                return;
            }
            accountList.Add($"{tb_name.Text} {tb_pass.Text}");
            tb_name.Clear();
            tb_pass.Clear();
            string dataregister = "";
            foreach (string account in accountList)
            {
                dataregister += $"{account}\n";
            }
            File.WriteAllText("profile.txt", dataregister);
        }

        private void btn_community_Click(object sender, EventArgs e)
        {
            var formcommunity = new Community();
            formcommunity.Show();
        }
    }
}
