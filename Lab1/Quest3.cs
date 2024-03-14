using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB_Lab1
{
    public partial class Quest3 : Form
    {
        public Quest3()
        {
            InitializeComponent();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string[] NumList = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            int num;
            if (!int.TryParse(tbxNum.Text.Trim(), out num) || num<0 || num>9)
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9!");
            }
            else
            {
                tbxTemp.Text = NumList[num];
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbxNum.Text = "";
            tbxTemp.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
