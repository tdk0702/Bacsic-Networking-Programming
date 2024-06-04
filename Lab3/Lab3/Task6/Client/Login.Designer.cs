using System.Drawing;
using System.Windows.Forms;

namespace Lab3.Task6.Client
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogin.Location = new System.Drawing.Point(86, 288);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(144, 47);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label8.Location = new System.Drawing.Point(20, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "Username";
            // 
            // textUsername
            // 
            this.textUsername.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textUsername.Location = new System.Drawing.Point(20, 212);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(278, 35);
            this.textUsername.TabIndex = 2;
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textIP.Location = new System.Drawing.Point(20, 145);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(206, 35);
            this.textIP.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label9.Location = new System.Drawing.Point(20, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 44;
            this.label9.Text = "Server IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.ForeColor = System.Drawing.Color.IndianRed;
            this.label11.Location = new System.Drawing.Point(39, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(264, 43);
            this.label11.TabIndex = 40;
            this.label11.Text = "Client Chat-app";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Server IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.label1.Location = new System.Drawing.Point(231, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 45;
            this.label1.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.textPort.Location = new System.Drawing.Point(231, 145);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(77, 35);
            this.textPort.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 390);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private Label label8;
        private TextBox textUsername;
        private TextBox textIP;
        private Label label9;
        private Label label11;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textPort;
    }
}