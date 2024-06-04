namespace Task12356
{
    partial class Task2
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
            btn_down = new Button();
            tb_url = new TextBox();
            rb_show = new RichTextBox();
            tb_down = new TextBox();
            btn_next = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_down
            // 
            btn_down.Location = new Point(717, 7);
            btn_down.Margin = new Padding(2, 2, 2, 2);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(99, 33);
            btn_down.TabIndex = 0;
            btn_down.Text = "Download";
            btn_down.UseVisualStyleBackColor = true;
            btn_down.Click += btn_Click;
            // 
            // tb_url
            // 
            tb_url.Location = new Point(149, 7);
            tb_url.Margin = new Padding(2, 2, 2, 2);
            tb_url.Multiline = true;
            tb_url.Name = "tb_url";
            tb_url.Size = new Size(564, 35);
            tb_url.TabIndex = 1;
            // 
            // rb_show
            // 
            rb_show.Location = new Point(8, 80);
            rb_show.Margin = new Padding(2, 2, 2, 2);
            rb_show.Name = "rb_show";
            rb_show.Size = new Size(809, 300);
            rb_show.TabIndex = 2;
            rb_show.Text = "";
            // 
            // tb_down
            // 
            tb_down.Location = new Point(149, 44);
            tb_down.Margin = new Padding(2, 2, 2, 2);
            tb_down.Multiline = true;
            tb_down.Name = "tb_down";
            tb_down.Size = new Size(564, 35);
            tb_down.TabIndex = 3;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(717, 44);
            btn_next.Margin = new Padding(2, 2, 2, 2);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(99, 33);
            btn_next.TabIndex = 4;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 16);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "URL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 6;
            label2.Text = "Download file (*.html_):";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 386);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_next);
            Controls.Add(tb_down);
            Controls.Add(rb_show);
            Controls.Add(tb_url);
            Controls.Add(btn_down);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_down;
        private TextBox tb_url;
        private RichTextBox rb_show;
        private TextBox tb_down;
        private Button btn_next;
        private Label label1;
        private Label label2;
    }
}
