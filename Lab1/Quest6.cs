using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Quest6 : Form
    {
        public Quest6()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbxNum1.Text = "";
            tbxNum2.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calMultiTable(long n1)
        {
            string text = "Bảng cửu chương " + n1.ToString() + " :" + Environment.NewLine;
            for (int i = 1; i <= 9; i++)
                text += n1.ToString() + " x " + i.ToString() + " = " + (n1*i).ToString() + Environment.NewLine;
            tbxTemp.Text = text;
        }

        private string calFactory(long n1, long n2)
        {
            long temp = 1;
            for (int i = 1; i <= Math.Abs(n1 - n2); i++) temp *= i;
            return "(A-B)! = " + temp.ToString() + Environment.NewLine;
        }
        private string calExpSum(long n1, long n2)
        {
            long temp = 0;
            for (long i = 1; i <= n2; i++)
                temp += Convert.ToInt64(Math.Pow((double)n1, (double)i));
            return "S = " + temp.ToString() + Environment.NewLine;
        }

        private void calValue(long n1, long n2)
        {
            tbxTemp.Text = "Tính các giá trị:" + Environment.NewLine + calFactory(n1, n2) + calExpSum(n1, n2) + Environment.NewLine;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            long n1 = 0, n2 = 0;
            try
            {
                n1 = long.Parse(tbxNum1.Text.Trim());
                n2 = long.Parse(tbxNum2.Text.Trim());
            }
            catch (OverflowException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên !");
            }

            switch (cbxChoose.SelectedIndex) {
                case 0:
                    calMultiTable(n2-n1);
                    break;
                case 1:
                    calValue(n1, n2);
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn cách tính !");
                    break;
            };
        }

        private void tbxNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind_Click(this, new EventArgs());
        }

        private void tbxNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind_Click(this, new EventArgs());
        }

        private void cbxChoose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind_Click(this, new EventArgs());
        }
    }
}
