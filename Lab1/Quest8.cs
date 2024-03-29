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

namespace Lab1
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

        private int checkRank(float scr)
        {
            if (scr >= (float)6.5) return 0;
            if (scr >= (float)5) return 1;
            if (scr >= (float)3.5) return 2;
            if (scr >= (float)2) return 3;
            return 4;
        }
        private int checkAvgRank(float scr)
        {
            if (scr >= (float)8) return 0;
            if (scr >= (float)6.5) return 1;
            if (scr >= (float)5) return 2;
            if (scr >= (float)3.5) return 3;
            return 4;
        }
        private string Ranking(float avg, int check)
        {
            int avgcheck = Math.Max(checkAvgRank(avg),check);

            switch (avgcheck)
            {
                case 0:
                    return "Giỏi";
                case 1:
                    return "Khá";
                case 2:
                    return "Trung Bình";
                case 3:
                    return "Yếu";
                case 4:
                    return "Kém";
                default:
                    MessageBox.Show("Dữ liệu nhập vào có sai xót");
                    return "Invalid!";
            }
            //return "Invalid!";
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string text = tbxInput.Text + ",",
                name = splitInfo(ref text, ',');
            float score = 0, avg = 0, max = 0, min = 10;
            int i = 0, check = -1, rankcheck = -1;
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
                check = checkRank(score);
                if (rankcheck < check) rankcheck = check;
                avg += score;
                if (max < score) max = score;
                if (min > score) min = score;
                temp += "Môn " + i.ToString() + ": " + score.ToString() 
                    + " " + isPassed(score) + Environment.NewLine;
            }
            while (text.IndexOf(',') != -1);
            temp += "Điểm trung bình: " + avg / ((float)i) + " (" + Ranking(avg, rankcheck) + ")" + Environment.NewLine;
            temp += "Điểm cao nhất: " + max + Environment.NewLine;
            temp += "Điểm nhỏ nhất: " + min + Environment.NewLine;
            tbxTemp.Text = temp;
        }
    }
}
