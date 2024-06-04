namespace Task5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_byme = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hôm nay ăn gì?";
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(434, 66);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(135, 54);
            this.btn_find.TabIndex = 1;
            this.btn_find.Text = "Ăn gì giờ?";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(603, 66);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 54);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm món ăn";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 759);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 759);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Page Size";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(494, 758);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(48, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox2.Location = new System.Drawing.Point(675, 756);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(48, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(24, 140);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(65, 31);
            this.btn_all.TabIndex = 7;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_byme
            // 
            this.btn_byme.Location = new System.Drawing.Point(84, 140);
            this.btn_byme.Name = "btn_byme";
            this.btn_byme.Size = new System.Drawing.Size(118, 31);
            this.btn_byme.TabIndex = 8;
            this.btn_byme.Text = "Tôi đóng góp";
            this.btn_byme.UseVisualStyleBackColor = true;
            this.btn_byme.Click += new System.EventHandler(this.btn_byme_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 576);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // FindFood
            // 
            this.AcceptButton = this.btn_find;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 802);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_byme);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.label1);
            this.Name = "FindFood";
            this.Text = "FindFood";
            this.ResumeLayout(false);
            this.PerformLayout();

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