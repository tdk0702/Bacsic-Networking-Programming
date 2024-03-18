﻿using System;
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
    public partial class Quest4 : Form
    {
        public Quest4()
        {
            InitializeComponent();
        }

        private string str_Hungred(int n1, int n2, int n3)
        {
            string[] NumList = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            string text = "";
            if (n1 == 0 && n2 == 0 && n3 == 0) return text;
            if (n3 != 0 && n2 == 0 && n3 == 0){
                text = NumList[n3] + " Trăm";
                return text;
            }
            text = " " + NumList[n1];
            if (n2 == 1)  text = " " + "Mười" + text;
            else {
                if (n2 == 0) text = " " + "Lẻ" + text;
                else text = " " + "Mươi" + text;
                text = NumList[n2] + text;
            }
            return NumList[n3] + " " + "Trăm" + text;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string[] NumType = {"", "Ngàn", "Triệu", "Tỷ" };
            long num = 0;
            int[] NumArr = new int[12];
            if (tbxNum.Text.Trim().Length != 12 || !long.TryParse(tbxNum.Text.Trim(), out num))
            {
                MessageBox.Show("Vui lòng nhập số có 12 chữ số!");
                return;
            }
            for (int i = 0; i < 12; i++) { 
                NumArr[i] = Convert.ToInt32(num % 10); 
                num /= 10; 
            }
            string hrdtext = "", fulltext = "";
            int j = 0;
            for (int i = 0; i < 4; i++)
            {
                hrdtext = str_Hungred(NumArr[i * 3], NumArr[i * 3 + 1], NumArr[i * 3 + 2]);
                if (hrdtext == "") continue;
                fulltext = hrdtext + NumType[j] + ", " +fulltext;
                j = (j + 1) % 3;
            }
            tbxTemp.Text = fulltext;
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
