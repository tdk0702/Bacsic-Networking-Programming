namespace Lab3.Task3
{
    partial class Server
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
            this.btnListen = new System.Windows.Forms.Button();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(441, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 32);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(34, 75);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(498, 340);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.btnListen);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.RichTextBox rtbMessage;
    }
}