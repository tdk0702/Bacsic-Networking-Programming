using System.Drawing;
using System.Windows.Forms;

namespace Task5
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(220, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hôm nay ăn gì?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Firstname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lastname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Birthday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Language";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Sex";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(48, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 141);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign up";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(100, 90);
            this.txtmatkhau.Multiline = true;
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(454, 29);
            this.txtmatkhau.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 31);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(454, 29);
            this.txtname.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtlast);
            this.groupBox2.Controls.Add(this.txtfirst);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(48, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 335);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User information";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox2.Location = new System.Drawing.Point(100, 299);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(454, 28);
            this.comboBox2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(454, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Việt Nam"});
            this.comboBox1.Location = new System.Drawing.Point(100, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(454, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(100, 168);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(454, 29);
            this.txtphone.TabIndex = 14;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(100, 120);
            this.txtlast.Multiline = true;
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(454, 29);
            this.txtlast.TabIndex = 13;
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(100, 78);
            this.txtfirst.Multiline = true;
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(454, 29);
            this.txtfirst.TabIndex = 12;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(100, 34);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(454, 29);
            this.txtemail.TabIndex = 6;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(386, 630);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(98, 34);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(511, 630);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(97, 34);
            this.btn_submit.TabIndex = 15;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Signup
            // 
            this.AcceptButton = this.btn_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 676);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Sign up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}