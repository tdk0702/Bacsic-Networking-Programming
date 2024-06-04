namespace Task123
{
    partial class Task2
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "", "H1", "H2", "H3" }, -1);
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            lvEmail = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 111);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 13;
            label4.Text = "Recent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 111);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 14;
            label3.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 47);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 15;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 16;
            label1.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(121, 48);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(198, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 19);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 23);
            txtEmail.TabIndex = 12;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(362, 22);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(95, 48);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lvEmail
            // 
            lvEmail.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvEmail.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvEmail.Location = new Point(35, 143);
            lvEmail.Name = "lvEmail";
            lvEmail.Size = new Size(440, 278);
            lvEmail.TabIndex = 17;
            lvEmail.UseCompatibleStateImageBehavior = false;
            lvEmail.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "From";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Date";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(lvEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Name = "Task2";
            Text = "Task2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
        private ListView lvEmail;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}