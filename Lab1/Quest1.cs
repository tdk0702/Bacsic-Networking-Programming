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
    public partial class Quest1 : Form
    {
        public Quest1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            long sum;
            if (!int.TryParse(tbxNum1.Text, out num1)|| !int.TryParse(tbxNum2.Text.Trim(), out num2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên !");
            }
            else
            {
                sum = num1 + num2;
                tbxSum.Text = sum.ToString();
            }
        }
    }
}
