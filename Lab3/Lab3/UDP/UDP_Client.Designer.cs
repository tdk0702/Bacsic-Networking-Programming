using System.Drawing;
using System.Windows.Forms;

namespace Lab3.UDP
{
    partial class UDP_Client
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
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_messa = new System.Windows.Forms.TextBox();
            this.btn_sent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ip
            // 
            this.tb_ip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_ip.Location = new System.Drawing.Point(231, 89);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ip.Multiline = true;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(315, 43);
            this.tb_ip.TabIndex = 0;
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_port.Location = new System.Drawing.Point(700, 89);
            this.tb_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_port.Multiline = true;
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(164, 43);
            this.tb_port.TabIndex = 1;
            // 
            // tb_messa
            // 
            this.tb_messa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_messa.Location = new System.Drawing.Point(231, 174);
            this.tb_messa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_messa.Multiline = true;
            this.tb_messa.Name = "tb_messa";
            this.tb_messa.Size = new System.Drawing.Size(633, 199);
            this.tb_messa.TabIndex = 2;
            // 
            // btn_sent
            // 
            this.btn_sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sent.Location = new System.Drawing.Point(231, 399);
            this.btn_sent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sent.Name = "btn_sent";
            this.btn_sent.Size = new System.Drawing.Size(158, 50);
            this.btn_sent.TabIndex = 3;
            this.btn_sent.Text = "Sent";
            this.btn_sent.UseVisualStyleBackColor = true;
            this.btn_sent.Click += new System.EventHandler(this.btn_sent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(694, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP Remote host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // UDP_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sent);
            this.Controls.Add(this.tb_messa);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UDP_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP_Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_ip;
        private TextBox tb_port;
        private TextBox tb_messa;
        private Button btn_sent;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}