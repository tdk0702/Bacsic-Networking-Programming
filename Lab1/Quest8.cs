using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LTMCB_Lab1
{
    public partial class Quest8 : Form
    {
        public Quest8()
        {
            InitializeComponent();
        }



        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProcess_Click(this, new EventArgs());
            }
        }

        private string splitInfo(ref string text, char ptn)
        {
            string temp = text.Substring(0, text.IndexOf(ptn));
            text = text.Remove(0, text.IndexOf(ptn) + 1);
            return temp;
        }

        private bool isRightName(string text)
        {
            return !Regex.IsMatch(text, @"[^\w0-9 ]");
        }

        private string isPassed(float scr)
        {
            if (scr >= 5) return "(Đạt)";
            return "(Không Đạt)";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string text = tbxInput.Text + ",",
                name = splitInfo(ref text, ',');
            float score = 0, avg = 0, max = 0, min = 10;
            int i = 0;
            string temp = "Họ và tên: " + name + Environment.NewLine;
            do
            {
                try {
                    score = float.Parse(splitInfo(ref text, ',').Trim());
                }
                catch (FormatException) {
                    MessageBox.Show("Vui lòng nhập đúng cấu trúc");
                }
                i++;
                avg += score;
                if (max < score) max = score;
                if (min > score) min = score;
                temp += "Môn " + i.ToString() + ": " + score.ToString() 
                    + " " + isPassed(score) + Environment.NewLine;
            }
            while (text.IndexOf(',') != -1);
            temp += "Điểm trung bình: " + avg / ((float)i) + Environment.NewLine;
            temp += "Điểm cao nhất: " + max + Environment.NewLine;
            temp += "Điểm nhỏ nhất: " + min + Environment.NewLine;
            tbxTemp.Text = temp;
        }
    }
}
