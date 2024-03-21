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
    public partial class Quest9 : Form
    {
        public Quest9()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbxInput.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập món ăn");
                return;
            }
            lsbShow.Items.Add(tbxInput.Text.Trim());
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int idx = rand.Next(0, lsbShow.Items.Count);
            tbxTemp.Text = lsbShow.Items[idx].ToString();
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) btnAdd_Click(this, new EventArgs());
        }

        private void btnDel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lsbShow.SelectedIndex != -1)
                lsbShow.Items.RemoveAt(lsbShow.SelectedIndex);
        }

        private void btnDel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult drs = MessageBox.Show("Bạn có chắc muốn xoá tất cả ?", "Lưu ý", MessageBoxButtons.YesNo);
                if (drs == DialogResult.Yes) lsbShow.Items.Clear();
            }
        }
    }
}
