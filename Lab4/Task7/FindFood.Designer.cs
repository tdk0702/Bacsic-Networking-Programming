namespace Task7
{
    partial class FindFood
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
            btn_find = new Button();
            btn_add = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btn_all = new Button();
            btn_byme = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(299, 46);
            label1.TabIndex = 0;
            label1.Text = "Hôm nay ăn gì?";
            // 
            // btn_find
            // 
            btn_find.Location = new Point(482, 82);
            btn_find.Margin = new Padding(3, 4, 3, 4);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(150, 68);
            btn_find.TabIndex = 1;
            btn_find.Text = "Ăn gì giờ?";
            btn_find.UseVisualStyleBackColor = true;
            btn_find.Click += btn_find_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(670, 82);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(133, 68);
            btn_add.TabIndex = 2;
            btn_add.Text = "Thêm món ăn";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 949);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 3;
            label2.Text = "Page";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(650, 949);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 4;
            label3.Text = "Page Size";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox1.Location = new Point(549, 948);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(53, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox2.Location = new Point(750, 945);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(53, 33);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btn_all
            // 
            btn_all.Location = new Point(27, 175);
            btn_all.Margin = new Padding(3, 4, 3, 4);
            btn_all.Name = "btn_all";
            btn_all.Size = new Size(72, 39);
            btn_all.TabIndex = 7;
            btn_all.Text = "All";
            btn_all.UseVisualStyleBackColor = true;
            btn_all.Click += btn_all_Click;
            // 
            // btn_byme
            // 
            btn_byme.Location = new Point(93, 175);
            btn_byme.Margin = new Padding(3, 4, 3, 4);
            btn_byme.Name = "btn_byme";
            btn_byme.Size = new Size(131, 39);
            btn_byme.TabIndex = 8;
            btn_byme.Text = "Tôi đóng góp";
            btn_byme.UseVisualStyleBackColor = true;
            btn_byme.Click += btn_byme_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(31, 211);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(771, 720);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // FindFood
            // 
            AcceptButton = btn_find;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 1002);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btn_byme);
            Controls.Add(btn_all);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_add);
            Controls.Add(btn_find);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FindFood";
            Text = "FindFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_byme;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}