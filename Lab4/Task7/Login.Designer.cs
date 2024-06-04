namespace Task7
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
            label1 = new Label();
            btn_login = new Button();
            label2 = new Label();
            label3 = new Label();
            tb_user = new TextBox();
            tb_pass = new TextBox();
            label4 = new Label();
            btn_signup = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(274, 52);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 0;
            label1.Text = "Hôm nay ăn gì?";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(559, 171);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(153, 141);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 175);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 274);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // tb_user
            // 
            tb_user.Location = new Point(220, 171);
            tb_user.Margin = new Padding(3, 4, 3, 4);
            tb_user.Multiline = true;
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(303, 42);
            tb_user.TabIndex = 4;
            // 
            // tb_pass
            // 
            tb_pass.Location = new Point(220, 270);
            tb_pass.Margin = new Padding(3, 4, 3, 4);
            tb_pass.Multiline = true;
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(303, 42);
            tb_pass.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 362);
            label4.Name = "label4";
            label4.Size = new Size(226, 25);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account yet?";
            // 
            // btn_signup
            // 
            btn_signup.AutoSize = true;
            btn_signup.ForeColor = Color.FromArgb(0, 192, 0);
            btn_signup.Location = new Point(440, 362);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(73, 25);
            btn_signup.TabIndex = 7;
            btn_signup.Text = "Sign up";
            btn_signup.Click += btn_signup_Click;
            // 
            // Login
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 439);
            Controls.Add(btn_signup);
            Controls.Add(label4);
            Controls.Add(tb_pass);
            Controls.Add(tb_user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_login);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label btn_signup;
    }
}