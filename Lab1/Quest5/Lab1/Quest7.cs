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
    public partial class Quest7 : Form
    {
        public Quest7()
        {
            InitializeComponent();
        }

        private int getVal(DateTime dt)
        {

            switch (dt.Month)
            {
                case 1:
                    if (dt.Day < 21) return 9;
                    return 10;
                    //break;
                case 2:
                    if (dt.Day < 20) return 10;
                    return 11;
                    //break;
                case 3:
                    if (dt.Day < 21) return 11;
                    return 0;
                    //break;
                case 4:
                    if (dt.Day < 21) return 0;
                    return 1;
                    //break;
                case 5:
                    if (dt.Day < 22) return 1;
                    return 2;
                    //break;
                case 6:
                    if (dt.Day < 22) return 2;
                    return 3;
                    //break;
                case 7:
                    if (dt.Day < 23) return 3;
                    return 4;
                    //break;
                case 8:
                    if (dt.Day < 23) return 4;
                    return 5;
                    //break;
                case 9:
                    if (dt.Day < 24) return 5;
                    return 6;
                    //break;
                case 10:
                    if (dt.Day < 24) return 6;
                    return 7;
                    //break;
                case 11:
                    if (dt.Day < 23) return 7;
                    return 8;
                    //break;
                case 12:
                    if (dt.Day < 22) return 8;
                    return 9;
                    //break;
                default:
                    MessageBox.Show("Vui lòng nhập đúng ngày sinh");
                    tbxTemp.Text = string.Empty;
                    break;
            }
            return -1;
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            string[] astrology = {"Bạch Dương", "Kim Ngưu", "Song Tử", "Cự Giải", "Sư Tử",
                "Xử Nữ", "Thiên Bình", "Thần Nông", "Nhân Mã", "Ma Kết", "Bảo Bình", "Song Ngư"};
            DateTime dt = new DateTime();
            try
            {
                dt = DateTime.Parse(tbxInput.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                tbxTemp.Text = string.Empty;
            }
            tbxTemp.Text = astrology[getVal(dt)];
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnTemp_Click(this, new EventArgs());
        }
    }
}
