namespace Task12356
{
    partial class Task6
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
            btn_get = new Button();
            rtb_data = new RichTextBox();
            tb_token = new TextBox();
            label1 = new Label();
            btn_default = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_get
            // 
            btn_get.Font = new Font("Segoe UI", 12F);
            btn_get.Location = new Point(75, 78);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(151, 39);
            btn_get.TabIndex = 0;
            btn_get.Text = "Get information";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // rtb_data
            // 
            rtb_data.Font = new Font("Segoe UI", 12F);
            rtb_data.Location = new Point(75, 154);
            rtb_data.Name = "rtb_data";
            rtb_data.Size = new Size(636, 259);
            rtb_data.TabIndex = 1;
            rtb_data.Text = "";
            // 
            // tb_token
            // 
            tb_token.Font = new Font("Segoe UI", 12F);
            tb_token.Location = new Point(133, 40);
            tb_token.Name = "tb_token";
            tb_token.Size = new Size(578, 29);
            tb_token.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(75, 43);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 3;
            label1.Text = "Token:";
            // 
            // btn_default
            // 
            btn_default.Font = new Font("Segoe UI", 12F);
            btn_default.Location = new Point(474, 79);
            btn_default.Name = "btn_default";
            btn_default.Size = new Size(237, 38);
            btn_default.TabIndex = 4;
            btn_default.Text = "Click to use admin token";
            btn_default.UseVisualStyleBackColor = true;
            btn_default.Click += btn_default_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(75, 136);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 5;
            label2.Text = "User data:";
            // 
            // Task6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btn_default);
            Controls.Add(label1);
            Controls.Add(tb_token);
            Controls.Add(rtb_data);
            Controls.Add(btn_get);
            Name = "Task6";
            Text = "Task 6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_get;
        private RichTextBox rtb_data;
        private TextBox tb_token;
        private Label label1;
        private Button btn_default;
        private Label label2;
    }
}