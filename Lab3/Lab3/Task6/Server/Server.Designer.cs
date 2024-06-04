using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3.Task6.Server
{
    partial class Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbDialog = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Address";
            // 
            // textIP
            // 
            this.textIP.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.textIP.Location = new System.Drawing.Point(12, 84);
            this.textIP.Name = "textIP";
            this.textIP.ReadOnly = true;
            this.textIP.Size = new System.Drawing.Size(225, 22);
            this.textIP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Port";
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.textPort.Location = new System.Drawing.Point(12, 132);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(225, 22);
            this.textPort.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnStart.ForeColor = System.Drawing.Color.Maroon;
            this.btnStart.Location = new System.Drawing.Point(12, 171);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbDialog
            // 
            this.rtbDialog.Enabled = false;
            this.rtbDialog.Location = new System.Drawing.Point(12, 229);
            this.rtbDialog.Name = "rtbDialog";
            this.rtbDialog.Size = new System.Drawing.Size(225, 248);
            this.rtbDialog.TabIndex = 4;
            this.rtbDialog.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Firebrick;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(12, 489);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(225, 32);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(12, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Log";
            // 
            // Server
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(249, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbDialog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textIP;
        private Label label3;
        private TextBox textPort;
        private Button btnStart;
        private RichTextBox rtbDialog;
        private Button btnStop;
        private Label label4;
    }
}