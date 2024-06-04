namespace Task12356
{
    partial class Task1
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
            btn_next = new Button();
            rb_show = new RichTextBox();
            tb_url = new TextBox();
            btn_get = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_next
            // 
            btn_next.Location = new Point(717, 44);
            btn_next.Margin = new Padding(2, 2, 2, 2);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(99, 33);
            btn_next.TabIndex = 9;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // rb_show
            // 
            rb_show.Location = new Point(8, 80);
            rb_show.Margin = new Padding(2, 2, 2, 2);
            rb_show.Name = "rb_show";
            rb_show.Size = new Size(809, 300);
            rb_show.TabIndex = 7;
            rb_show.Text = "";
            // 
            // tb_url
            // 
            tb_url.Location = new Point(63, 7);
            tb_url.Margin = new Padding(2, 2, 2, 2);
            tb_url.Multiline = true;
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(652, 35);
            tb_url.TabIndex = 6;
            // 
            // btn_get
            // 
            btn_get.Location = new Point(717, 7);
            btn_get.Margin = new Padding(2, 2, 2, 2);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(99, 33);
            btn_get.TabIndex = 5;
            btn_get.Text = "Get";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 10;
            label1.Text = "URL:";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 386);
            Controls.Add(label1);
            Controls.Add(btn_next);
            Controls.Add(rb_show);
            Controls.Add(tb_url);
            Controls.Add(btn_get);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_next;
        private RichTextBox rb_show;
        private TextBox tb_url;
        private Button btn_get;
        private Label label1;
    }
}