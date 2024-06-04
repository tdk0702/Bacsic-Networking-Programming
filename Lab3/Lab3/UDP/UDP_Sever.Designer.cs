using System.Drawing;
using System.Windows.Forms;

namespace Lab3.UDP
{
    partial class UDP_Sever
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
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_listen = new System.Windows.Forms.Button();
            this.rich_data = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_port.Location = new System.Drawing.Point(245, 44);
            this.tb_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_port.Multiline = true;
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(199, 38);
            this.tb_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // btn_listen
            // 
            this.btn_listen.Location = new System.Drawing.Point(461, 44);
            this.btn_listen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(167, 37);
            this.btn_listen.TabIndex = 4;
            this.btn_listen.Text = "Start Listening";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // rich_data
            // 
            this.rich_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rich_data.Location = new System.Drawing.Point(184, 120);
            this.rich_data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rich_data.Name = "rich_data";
            this.rich_data.Size = new System.Drawing.Size(785, 306);
            this.rich_data.TabIndex = 5;
            this.rich_data.Text = "";
            // 
            // UDP_Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 515);
            this.Controls.Add(this.rich_data);
            this.Controls.Add(this.btn_listen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_port);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UDP_Sever";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UDP_Sever";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UDP_Sever_FormClosing);
            this.Load += new System.EventHandler(this.UDP_Sever_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tb_port;
        private Label label1;
        private Button btn_listen;
        private RichTextBox rich_data;
    }
}