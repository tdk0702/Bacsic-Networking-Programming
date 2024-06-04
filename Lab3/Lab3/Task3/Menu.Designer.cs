namespace Lab3.Task3
{
    partial class Menu
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
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.Location = new System.Drawing.Point(43, 96);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(106, 55);
            this.btnServer.TabIndex = 0;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.Location = new System.Drawing.Point(177, 96);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(106, 55);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "TCP Client Server";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
    }
}