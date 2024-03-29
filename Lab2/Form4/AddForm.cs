using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Form4
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            double n1, n2, n3;
            try {
                n1 = double.Parse(tbxScore1.Text.Trim());
                n2 = double.Parse(tbxScore2.Text.Trim());
                n3 = double.Parse(tbxScore3.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập điểm là số");
                return;
            }
            FormWrite.Student st = new FormWrite.Student(tbxName.Text.Trim(),
                tbxID.Text.Trim(),tbxPhone.Text.Trim(),n1,n2,n3);
            FormWrite.StData.Add(st);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doDel()
        {
            tbxName.Text = string.Empty;
            tbxID.Text = string.Empty;
            tbxPhone.Text = string.Empty;
            tbxScore1.Text = string.Empty;
            tbxScore2.Text = string.Empty;
            tbxScore3.Text = string.Empty;
        }

        private void AddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd_Click(this, new EventArgs());
            if (e.KeyCode == Keys.Delete)
                doDel();
        }
    }
}
