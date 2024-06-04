namespace Task123
{
    partial class Task3
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
            lvEmail = new ListView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            Date = new ColumnHeader();
            SuspendLayout();
            // 
            // lvEmail
            // 
            lvEmail.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, Date });
            lvEmail.Location = new Point(27, 149);
            lvEmail.Name = "lvEmail";
            lvEmail.Size = new Size(440, 278);
            lvEmail.TabIndex = 25;
            lvEmail.UseCompatibleStateImageBehavior = false;
            lvEmail.View = View.Details;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 117);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 21;
            label4.Text = "Recent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 117);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 22;
            label3.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 23;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 24;
            label1.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(113, 54);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 23);
            txtPassword.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 25);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 23);
            txtEmail.TabIndex = 20;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(354, 28);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 48);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "From";
            // 
            // Date
            // 
            Date.Text = "Date";
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 450);
            Controls.Add(lvEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Name = "Task3";
            Text = "Task3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader Date;
    }
}