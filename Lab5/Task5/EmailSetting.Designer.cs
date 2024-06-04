namespace Task5
{
    partial class EmailSetting
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtimap = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtnickname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Config";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.txtsmtp);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.txtimap);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email server configuration";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(384, 82);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(142, 26);
            this.numericUpDown2.TabIndex = 3;
            // 
            // txtsmtp
            // 
            this.txtsmtp.Location = new System.Drawing.Point(355, 28);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(171, 26);
            this.txtsmtp.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 82);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 2;
            // 
            // txtimap
            // 
            this.txtimap.Location = new System.Drawing.Point(74, 28);
            this.txtimap.Name = "txtimap";
            this.txtimap.Size = new System.Drawing.Size(165, 26);
            this.txtimap.TabIndex = 6;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(288, 131);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 24);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Require SSL";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Require SSL";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "SMTP Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "SMTP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "IMAP Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "IMAP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmatkhau);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.txtnickname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(21, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(116, 122);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(217, 26);
            this.txtmatkhau.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(116, 78);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(217, 26);
            this.txtname.TabIndex = 4;
            // 
            // txtnickname
            // 
            this.txtnickname.Location = new System.Drawing.Point(116, 33);
            this.txtnickname.Name = "txtnickname";
            this.txtnickname.Size = new System.Drawing.Size(217, 26);
            this.txtnickname.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ninkname";
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(431, 321);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(150, 35);
            this.btn_test.TabIndex = 6;
            this.btn_test.Text = "Test connection";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(431, 371);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 93);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save and exit";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmailSetting
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 505);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "EmailSetting";
            this.Text = "EmailSetting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtimap;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtnickname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_save;
    }
}