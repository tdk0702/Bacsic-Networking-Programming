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
    public partial class Quest2 : Form
    {
        public Quest2()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, Maximum, Minimum;
            if (!double.TryParse(tbxNum1.Text.Trim(), out num1) || 
                !double.TryParse(tbxNum2.Text.Trim(), out num2) ||
                !double.TryParse(tbxNum3.Text.Trim(), out num3))
            {
                MessageBox.Show("Vui lòng nhập số !");
            }
            else
            {
                Maximum = Math.Max(num1, Math.Max(num2, num3));
                Minimum = Math.Min(num1, Math.Min(num2, num3));
                tbxMax.Text = Maximum.ToString();
                tbxMin.Text = Minimum.ToString();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbxNum1.Text = "";
            tbxNum2.Text = "";
            tbxNum3.Text = "";
            tbxMax.Text = "";
            tbxMin.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind_Click(this, new EventArgs());
        }

        private void tbxNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind_Click(this, new EventArgs());
        }

        private void tbxNum3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnFind_Click(this, new EventArgs());
        }
    }
}
