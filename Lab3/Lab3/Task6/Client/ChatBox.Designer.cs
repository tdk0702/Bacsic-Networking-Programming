using System.Drawing;
using System.Windows.Forms;

namespace Lab3.Task6.Client
{
    partial class ChatBox
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
            this.tblUser = new System.Windows.Forms.DataGridView();
            this.Online = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rtbDialog = new System.Windows.Forms.RichTextBox();
            this.btnPicture = new System.Windows.Forms.PictureBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).BeginInit();
            this.SuspendLayout();
            // 
            // tblUser
            // 
            this.tblUser.AllowUserToAddRows = false;
            this.tblUser.AllowUserToDeleteRows = false;
            this.tblUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Online});
            this.tblUser.Location = new System.Drawing.Point(10, 37);
            this.tblUser.Name = "tblUser";
            this.tblUser.ReadOnly = true;
            this.tblUser.RowTemplate.Height = 25;
            this.tblUser.Size = new System.Drawing.Size(130, 382);
            this.tblUser.TabIndex = 4;
            this.tblUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblUser_CellContentClick);
            // 
            // Online
            // 
            this.Online.HeaderText = "Online";
            this.Online.Name = "Online";
            this.Online.ReadOnly = true;
            this.Online.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Online.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Online.Width = 120;
            // 
            // rtbDialog
            // 
            this.rtbDialog.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.rtbDialog.Location = new System.Drawing.Point(153, 37);
            this.rtbDialog.Name = "rtbDialog";
            this.rtbDialog.ReadOnly = true;
            this.rtbDialog.Size = new System.Drawing.Size(523, 353);
            this.rtbDialog.TabIndex = 2;
            this.rtbDialog.Text = "";
            // 
            // btnPicture
            // 
            this.btnPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPicture.Image = global::Lab3.Task6.Client.Resources.Resources.file;
            this.btnPicture.Location = new System.Drawing.Point(153, 396);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(26, 26);
            this.btnPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPicture.TabIndex = 2;
            this.btnPicture.TabStop = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtMessage.Location = new System.Drawing.Point(184, 397);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(462, 29);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Image = global::Lab3.Task6.Client.Resources.Resources.send;
            this.btnSend.Location = new System.Drawing.Point(651, 396);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(26, 26);
            this.btnSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSend.TabIndex = 2;
            this.btnSend.TabStop = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblWelcome.ForeColor = System.Drawing.Color.Maroon;
            this.lblWelcome.Location = new System.Drawing.Point(10, 8);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(106, 22);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome, ...";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtReceiver.Location = new System.Drawing.Point(153, 6);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(96, 29);
            this.txtReceiver.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Location = new System.Drawing.Point(601, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 30);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 431);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.rtbDialog);
            this.Controls.Add(this.tblUser);
            this.Name = "ChatBox";
            this.Text = "ChatBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatBox_FormClosing);
            this.Load += new System.EventHandler(this.ChatBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tblUser;
        private RichTextBox rtbDialog;
        private PictureBox btnPicture;
        private TextBox txtMessage;
        private PictureBox btnSend;
        private Label lblWelcome;
        private TextBox txtReceiver;
        private Button btnLogout;
        private DataGridViewButtonColumn Online;
    }
}