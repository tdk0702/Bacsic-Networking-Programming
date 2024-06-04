using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class ShowFood : Form
    {
        int a = 0;
        string in4 = "";
        public ShowFood(Control selectedControl, string s, int dem)
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(selectedControl);
            in4 = s;
            a = dem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                MessageBox.Show("Bạn cần cài đặt Email Server để sử dụng tính năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EmailSetting emailSetting = new EmailSetting();
                emailSetting.Show();
            }
            else
            {
                Control controlToMove = flowLayoutPanel1.Controls[0];
                Invite invite = new Invite(controlToMove, in4);
                invite.Show();
                this.Hide();
            }
            a++;
        }
    }
}
