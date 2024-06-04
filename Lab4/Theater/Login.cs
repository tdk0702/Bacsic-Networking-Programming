﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Theater
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static Class.Admin User;

        private void Login_Load(object sender, EventArgs e)
        {
        }


        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
                btnLogin_Click(this, new EventArgs());
        }

        private void openForm()
        {
            if (User.permit == 0)
            {
                //this.Hide();
                Server.Admin ad = new Server.Admin();
                ad.Show();
                ad.FormClosing += (s, arg) => this.Close();
            }
            else
            {
                Thread thread = new Thread(() => { Application.Run(new Client.Home()); });
                thread.Start();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control && e.KeyCode == Keys.M)
            {
                MessageBox.Show("Đăng nhập nhanh - Admin");
                User = new Class.Admin("admin",0);
                openForm();
            }
            if (e.Shift && e.Control && e.KeyCode == Keys.S)
            {
                MessageBox.Show("Đăng nhập nhanh - Staff");
                User = new Class.Admin("staff", 1);
                openForm();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = tbxName.Text;
            string query = string.Format("SELECT * FROM USERS WHERE Username = '{0}';", uname);
            DataTable dt = Server.Admin.getData(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Đăng nhập thất bại. Tài khoản không hợp lệ.");
                return;
            }
            if (dt.Rows[0]["Pass"].ToString() == tbxPass.Text)
            {
                MessageBox.Show("Đăng nhập thành công. Chào mừng " + uname);
                User = new Class.Admin(uname, int.Parse(dt.Rows[0]["Permit"].ToString()));
                openForm();
            }
            else MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại mật khẩu");
        }
    }
}