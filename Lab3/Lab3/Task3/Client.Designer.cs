namespace Lab3.Task3
{
    partial class Client
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
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(12, 12);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(296, 131);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(328, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 33);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(328, 60);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(328, 110);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 33);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 165);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.rtbMessage);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnDisconnect;
    }
}