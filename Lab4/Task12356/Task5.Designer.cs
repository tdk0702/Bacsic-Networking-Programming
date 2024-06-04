namespace Task12356
{
    partial class Task5
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
            btn_login = new Button();
            tb_user = new TextBox();
            tb_password = new TextBox();
            rtb_data = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            btn_default = new Button();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 12F);
            btn_login.Location = new Point(39, 133);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(101, 39);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tb_user
            // 
            tb_user.Font = new Font("Segoe UI", 12F);
            tb_user.Location = new Point(146, 26);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(339, 29);
            tb_user.TabIndex = 1;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 12F);
            tb_password.Location = new Point(146, 85);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(339, 29);
            tb_password.TabIndex = 2;
            // 
            // rtb_data
            // 
            rtb_data.Font = new Font("Segoe UI", 12F);
            rtb_data.Location = new Point(37, 194);
            rtb_data.Name = "rtb_data";
            rtb_data.Size = new Size(448, 223);
            rtb_data.TabIndex = 3;
            rtb_data.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(56, 34);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 4;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(56, 93);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // btn_default
            // 
            btn_default.Font = new Font("Segoe UI", 12F);
            btn_default.Location = new Point(278, 133);
            btn_default.Name = "btn_default";
            btn_default.Size = new Size(207, 39);
            btn_default.TabIndex = 6;
            btn_default.Text = "Click to get admin account";
            btn_default.UseVisualStyleBackColor = true;
            btn_default.Click += btn_default_Click;
            // 
            // Task5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(btn_default);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtb_data);
            Controls.Add(tb_password);
            Controls.Add(tb_user);
            Controls.Add(btn_login);
            Name = "Task5";
            Text = "Task 5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_user;
        private TextBox tb_password;
        private RichTextBox rtb_data;
        private Label label1;
        private Label label2;
        private Button btn_default;
    }
}