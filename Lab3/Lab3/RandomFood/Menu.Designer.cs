namespace Lab3.RandomFood
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
            this.btn_person = new System.Windows.Forms.Button();
            this.btn_community = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_person
            // 
            this.btn_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_person.Location = new System.Drawing.Point(433, 49);
            this.btn_person.Name = "btn_person";
            this.btn_person.Size = new System.Drawing.Size(258, 78);
            this.btn_person.TabIndex = 0;
            this.btn_person.Text = "Person";
            this.btn_person.UseVisualStyleBackColor = true;
            this.btn_person.Click += new System.EventHandler(this.btn_person_Click);
            // 
            // btn_community
            // 
            this.btn_community.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_community.Location = new System.Drawing.Point(433, 144);
            this.btn_community.Name = "btn_community";
            this.btn_community.Size = new System.Drawing.Size(258, 78);
            this.btn_community.TabIndex = 1;
            this.btn_community.Text = "Community";
            this.btn_community.UseVisualStyleBackColor = true;
            this.btn_community.Click += new System.EventHandler(this.btn_community_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(220, 90);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(151, 33);
            this.tb_name.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.Location = new System.Drawing.Point(220, 136);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(151, 33);
            this.tb_pass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "--Chỉ dành cho Person--";
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(220, 175);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(151, 47);
            this.btn_register.TabIndex = 7;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 286);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btn_community);
            this.Controls.Add(this.btn_person);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_person;
        private System.Windows.Forms.Button btn_community;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_register;
    }
}