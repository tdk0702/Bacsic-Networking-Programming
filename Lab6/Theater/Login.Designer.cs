
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
            tcMain = new TabControl();
            tabPage1 = new TabPage();
            btnLogin = new Button();
            tbxPass = new TextBox();
            lbPass = new Label();
            tbxName = new TextBox();
            lbName = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            tbxGuestEmail = new TextBox();
            lbGuestEmail = new Label();
            tbxGuestName = new TextBox();
            lbGuestName = new Label();
            lbGuestTittle = new Label();
            btnGuestLogin = new Button();
            tcMain.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tabPage1);
            tcMain.Controls.Add(tabPage2);
            tcMain.Dock = DockStyle.Fill;
            tcMain.Location = new Point(0, 0);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(429, 249);
            tcMain.TabIndex = 25;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLogin);
            tabPage1.Controls.Add(tbxPass);
            tabPage1.Controls.Add(lbPass);
            tabPage1.Controls.Add(tbxName);
            tabPage1.Controls.Add(lbName);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(10);
            tabPage1.Size = new Size(421, 221);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Dock = DockStyle.Bottom;
            btnLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(10, 179);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(401, 32);
            btnLogin.TabIndex = 30;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxPass
            // 
            tbxPass.Dock = DockStyle.Top;
            tbxPass.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPass.Location = new Point(10, 113);
            tbxPass.Margin = new Padding(4, 3, 4, 3);
            tbxPass.Name = "tbxPass";
            tbxPass.PasswordChar = '*';
            tbxPass.Size = new Size(401, 24);
            tbxPass.TabIndex = 29;
            tbxPass.KeyDown += tbxInput_KeyDown;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Dock = DockStyle.Top;
            lbPass.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPass.Location = new Point(10, 95);
            lbPass.Margin = new Padding(4, 0, 4, 0);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(82, 18);
            lbPass.TabIndex = 28;
            lbPass.Text = "Mật khẩu:";
            // 
            // tbxName
            // 
            tbxName.Dock = DockStyle.Top;
            tbxName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxName.Location = new Point(10, 71);
            tbxName.Margin = new Padding(4, 3, 4, 3);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(401, 24);
            tbxName.TabIndex = 27;
            tbxName.KeyDown += tbxInput_KeyDown;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Dock = DockStyle.Top;
            lbName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(10, 53);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(123, 18);
            lbName.TabIndex = 26;
            lbName.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(401, 43);
            label1.TabIndex = 25;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tbxGuestEmail);
            tabPage2.Controls.Add(lbGuestEmail);
            tabPage2.Controls.Add(tbxGuestName);
            tabPage2.Controls.Add(lbGuestName);
            tabPage2.Controls.Add(lbGuestTittle);
            tabPage2.Controls.Add(btnGuestLogin);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(10);
            tabPage2.Size = new Size(421, 221);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Khách";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxGuestEmail
            // 
            tbxGuestEmail.Dock = DockStyle.Top;
            tbxGuestEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxGuestEmail.Location = new Point(10, 113);
            tbxGuestEmail.Margin = new Padding(4, 3, 4, 3);
            tbxGuestEmail.Name = "tbxGuestEmail";
            tbxGuestEmail.Size = new Size(401, 24);
            tbxGuestEmail.TabIndex = 40;
            // 
            // lbGuestEmail
            // 
            lbGuestEmail.AutoSize = true;
            lbGuestEmail.Dock = DockStyle.Top;
            lbGuestEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGuestEmail.Location = new Point(10, 95);
            lbGuestEmail.Margin = new Padding(4, 0, 4, 0);
            lbGuestEmail.Name = "lbGuestEmail";
            lbGuestEmail.Size = new Size(55, 18);
            lbGuestEmail.TabIndex = 39;
            lbGuestEmail.Text = "Email:";
            // 
            // tbxGuestName
            // 
            tbxGuestName.Dock = DockStyle.Top;
            tbxGuestName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxGuestName.Location = new Point(10, 71);
            tbxGuestName.Margin = new Padding(4, 3, 4, 3);
            tbxGuestName.Name = "tbxGuestName";
            tbxGuestName.Size = new Size(401, 24);
            tbxGuestName.TabIndex = 38;
            // 
            // lbGuestName
            // 
            lbGuestName.AutoSize = true;
            lbGuestName.Dock = DockStyle.Top;
            lbGuestName.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGuestName.Location = new Point(10, 53);
            lbGuestName.Margin = new Padding(4, 0, 4, 0);
            lbGuestName.Name = "lbGuestName";
            lbGuestName.Size = new Size(128, 18);
            lbGuestName.TabIndex = 37;
            lbGuestName.Text = "Tên người dùng:";
            // 
            // lbGuestTittle
            // 
            lbGuestTittle.Dock = DockStyle.Top;
            lbGuestTittle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGuestTittle.Location = new Point(10, 10);
            lbGuestTittle.Margin = new Padding(4, 0, 4, 0);
            lbGuestTittle.Name = "lbGuestTittle";
            lbGuestTittle.Size = new Size(401, 43);
            lbGuestTittle.TabIndex = 36;
            lbGuestTittle.Text = "TÀI KHOẢN KHÁCH";
            lbGuestTittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuestLogin
            // 
            btnGuestLogin.AutoSize = true;
            btnGuestLogin.Dock = DockStyle.Bottom;
            btnGuestLogin.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuestLogin.Location = new Point(10, 179);
            btnGuestLogin.Margin = new Padding(4, 3, 4, 3);
            btnGuestLogin.Name = "btnGuestLogin";
            btnGuestLogin.Size = new Size(401, 32);
            btnGuestLogin.TabIndex = 35;
            btnGuestLogin.Text = "Đăng nhập";
            btnGuestLogin.UseVisualStyleBackColor = true;
            btnGuestLogin.Click += btnGuestLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 249);
            Controls.Add(tcMain);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            KeyDown += Login_KeyDown;
            tcMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMain;
        private TabPage tabPage1;
        private Button btnLogin;
        private TextBox tbxPass;
        private Label lbPass;
        private TextBox tbxName;
        private Label lbName;
        private Label label1;
        private TabPage tabPage2;
        private Button btnGuestLogin;
        private TextBox tbxGuestEmail;
        private Label lbGuestEmail;
        private TextBox tbxGuestName;
        private Label lbGuestName;
        private Label lbGuestTittle;
    }
}