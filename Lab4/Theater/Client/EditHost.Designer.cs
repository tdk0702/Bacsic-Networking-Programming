namespace Theater.Client
{
    partial class EditHost
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
            this.lbhost = new System.Windows.Forms.Label();
            this.tbxIP = new System.Windows.Forms.TextBox();
            this.lbtxt = new System.Windows.Forms.Label();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbhost
            // 
            this.lbhost.AutoSize = true;
            this.lbhost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhost.Location = new System.Drawing.Point(12, 9);
            this.lbhost.Name = "lbhost";
            this.lbhost.Size = new System.Drawing.Size(87, 20);
            this.lbhost.TabIndex = 0;
            this.lbhost.Text = "Hostname:";
            // 
            // tbxIP
            // 
            this.tbxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxIP.Location = new System.Drawing.Point(12, 32);
            this.tbxIP.Name = "tbxIP";
            this.tbxIP.Size = new System.Drawing.Size(163, 26);
            this.tbxIP.TabIndex = 1;
            // 
            // lbtxt
            // 
            this.lbtxt.AutoSize = true;
            this.lbtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxt.Location = new System.Drawing.Point(181, 35);
            this.lbtxt.Name = "lbtxt";
            this.lbtxt.Size = new System.Drawing.Size(13, 20);
            this.lbtxt.TabIndex = 2;
            this.lbtxt.Text = ":";
            // 
            // tbxPort
            // 
            this.tbxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPort.Location = new System.Drawing.Point(197, 32);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(83, 26);
            this.tbxPort.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(199, 64);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 30);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Xong";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // EditHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 106);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.lbtxt);
            this.Controls.Add(this.tbxIP);
            this.Controls.Add(this.lbhost);
            this.KeyPreview = true;
            this.Name = "EditHost";
            this.Text = "Điều chỉnh IP";
            this.Load += new System.EventHandler(this.EditHost_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditHost_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbhost;
        private System.Windows.Forms.TextBox tbxIP;
        private System.Windows.Forms.Label lbtxt;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnAccept;
    }
}