namespace Theater.Server
{
    partial class LockClient
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
            btnLock = new Button();
            lbxClient = new ListBox();
            SuspendLayout();
            // 
            // btnLock
            // 
            btnLock.AutoSize = true;
            btnLock.Dock = DockStyle.Bottom;
            btnLock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLock.Location = new Point(10, 147);
            btnLock.Margin = new Padding(2, 2, 2, 2);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(469, 30);
            btnLock.TabIndex = 1;
            btnLock.Text = "Lock/Unlock";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // lbxClient
            // 
            lbxClient.Dock = DockStyle.Fill;
            lbxClient.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxClient.FormattingEnabled = true;
            lbxClient.ItemHeight = 23;
            lbxClient.Location = new Point(10, 10);
            lbxClient.Margin = new Padding(2, 2, 2, 2);
            lbxClient.Name = "lbxClient";
            lbxClient.ScrollAlwaysVisible = true;
            lbxClient.Size = new Size(469, 137);
            lbxClient.TabIndex = 2;
            // 
            // LockClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 187);
            Controls.Add(lbxClient);
            Controls.Add(btnLock);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LockClient";
            Padding = new Padding(10);
            Text = "LockClient";
            Load += LockClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLock;
        private ListBox lbxClient;
    }
}