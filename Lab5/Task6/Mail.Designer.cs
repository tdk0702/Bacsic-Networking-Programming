namespace Task6
{
    partial class Mail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsmtpport = new System.Windows.Forms.TextBox();
            this.txtsmtp = new System.Windows.Forms.TextBox();
            this.txtimapport = new System.Windows.Forms.TextBox();
            this.txtimap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.buttonSendMail);
            this.groupBox1.Controls.Add(this.txtmatkhau);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonSignIn);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(397, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(110, 102);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(109, 35);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.Location = new System.Drawing.Point(10, 102);
            this.buttonSendMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(93, 35);
            this.buttonSendMail.TabIndex = 7;
            this.buttonSendMail.Text = "Gửi mail";
            this.buttonSendMail.UseVisualStyleBackColor = true;
            this.buttonSendMail.Click += new System.EventHandler(this.buttonSendMail_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(108, 54);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(282, 26);
            this.txtmatkhau.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 15);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(282, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(226, 102);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(164, 35);
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Text = "Đăng nhập";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtsmtpport);
            this.groupBox2.Controls.Add(this.txtsmtp);
            this.groupBox2.Controls.Add(this.txtimapport);
            this.groupBox2.Controls.Add(this.txtimap);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(417, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(591, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt";
            // 
            // txtsmtpport
            // 
            this.txtsmtpport.Location = new System.Drawing.Point(362, 54);
            this.txtsmtpport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsmtpport.Name = "txtsmtpport";
            this.txtsmtpport.Size = new System.Drawing.Size(221, 26);
            this.txtsmtpport.TabIndex = 10;
            this.txtsmtpport.Text = "465";
            // 
            // txtsmtp
            // 
            this.txtsmtp.Location = new System.Drawing.Point(362, 15);
            this.txtsmtp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsmtp.Name = "txtsmtp";
            this.txtsmtp.Size = new System.Drawing.Size(221, 26);
            this.txtsmtp.TabIndex = 9;
            this.txtsmtp.Text = "smtp.gmail.com";
            // 
            // txtimapport
            // 
            this.txtimapport.Location = new System.Drawing.Point(63, 54);
            this.txtimapport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtimapport.Name = "txtimapport";
            this.txtimapport.Size = new System.Drawing.Size(232, 26);
            this.txtimapport.TabIndex = 8;
            this.txtimapport.Text = "993";
            // 
            // txtimap
            // 
            this.txtimap.Location = new System.Drawing.Point(63, 15);
            this.txtimap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtimap.Name = "txtimap";
            this.txtimap.Size = new System.Drawing.Size(232, 26);
            this.txtimap.TabIndex = 7;
            this.txtimap.Text = "imap.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 54);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "SMTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IMAP";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 168);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(994, 488);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // Mail
            // 
            this.AcceptButton = this.buttonSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 671);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Mail";
            this.Text = "Mail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtsmtpport;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.TextBox txtimapport;
        private System.Windows.Forms.TextBox txtimap;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSendMail;
    }
}