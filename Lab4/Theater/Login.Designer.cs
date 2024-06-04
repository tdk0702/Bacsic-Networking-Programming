
namespace Theater
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "ĐĂNG NHẬP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPass
            // 
            this.tbxPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPass.Location = new System.Drawing.Point(10, 107);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.PasswordChar = '*';
            this.tbxPass.Size = new System.Drawing.Size(303, 24);
            this.tbxPass.TabIndex = 21;
            this.tbxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(10, 89);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(82, 18);
            this.lbPass.TabIndex = 20;
            this.lbPass.Text = "Mật khẩu:";
            // 
            // tbxName
            // 
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(10, 65);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(303, 24);
            this.tbxName.TabIndex = 19;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(10, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(123, 18);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Tên đăng nhập:";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(10, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(303, 28);
            this.btnLogin.TabIndex = 24;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 182);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnLogin;
    }
}