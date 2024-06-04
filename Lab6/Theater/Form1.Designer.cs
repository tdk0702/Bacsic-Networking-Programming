namespace Theater
{
    partial class Form1
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
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Dock = DockStyle.Bottom;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(0, 391);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(604, 32);
            btnLogin.TabIndex = 31;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 423);
            Controls.Add(btnLogin);
            Enabled = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
    }
}
