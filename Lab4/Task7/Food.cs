using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class Food : UserControl
    {
        public Food()
        {
            InitializeComponent();
        }
        public void Settenmonan(string s)
        {
            label1.Text = s;
        }
        public void Setgiamonan(string s)
        {
            label5.Text = s;
        }
        public void Setdiachi(string s)
        {
            label6.Text = s;
        }
        public void Setnguoidonggop(string s)
        {
            label7.Text = s;
        }
        public void SetPictureBox(PictureBox picturebox)
        {
            if (picturebox.Image != null)
            {
                pictureBox1.Image = (Image)picturebox.Image.Clone();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Visible = true; // Đảm bảo PictureBox được hiển thị
            }
        }
    }
}
