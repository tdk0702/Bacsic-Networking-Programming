namespace Task7
{
    partial class AddFood
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_name = new TextBox();
            tb_price = new TextBox();
            tb_adrr = new TextBox();
            tb_image = new TextBox();
            tb_describe = new TextBox();
            btn_clear = new Button();
            btn_add = new Button();
            pct_food = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pct_food).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.Location = new Point(210, 56);
            label1.Name = "label1";
            label1.Size = new Size(216, 37);
            label1.TabIndex = 0;
            label1.Text = "Thêm món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 145);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên món ăn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 211);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 2;
            label3.Text = "Giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 272);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 3;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 336);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 4;
            label5.Text = "Hình ảnh";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 401);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 5;
            label6.Text = "Mô tả";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(218, 141);
            tb_name.Margin = new Padding(3, 4, 3, 4);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(411, 31);
            tb_name.TabIndex = 6;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(218, 208);
            tb_price.Margin = new Padding(3, 4, 3, 4);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(411, 31);
            tb_price.TabIndex = 7;
            // 
            // tb_adrr
            // 
            tb_adrr.Location = new Point(218, 269);
            tb_adrr.Margin = new Padding(3, 4, 3, 4);
            tb_adrr.Name = "tb_adrr";
            tb_adrr.Size = new Size(411, 31);
            tb_adrr.TabIndex = 8;
            // 
            // tb_image
            // 
            tb_image.Location = new Point(218, 332);
            tb_image.Margin = new Padding(3, 4, 3, 4);
            tb_image.Name = "tb_image";
            tb_image.Size = new Size(411, 31);
            tb_image.TabIndex = 9;
            tb_image.TextChanged += tb_image_TextChanged;
            // 
            // tb_describe
            // 
            tb_describe.Location = new Point(218, 398);
            tb_describe.Margin = new Padding(3, 4, 3, 4);
            tb_describe.Multiline = true;
            tb_describe.Name = "tb_describe";
            tb_describe.Size = new Size(411, 149);
            tb_describe.TabIndex = 10;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(738, 488);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(111, 59);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Xóa";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(887, 488);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(111, 59);
            btn_add.TabIndex = 12;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // pct_food
            // 
            pct_food.BackgroundImageLayout = ImageLayout.Stretch;
            pct_food.Location = new Point(725, 145);
            pct_food.Name = "pct_food";
            pct_food.Size = new Size(273, 263);
            pct_food.SizeMode = PictureBoxSizeMode.StretchImage;
            pct_food.TabIndex = 13;
            pct_food.TabStop = false;
            // 
            // AddFood
            // 
            AcceptButton = btn_add;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 683);
            Controls.Add(pct_food);
            Controls.Add(btn_add);
            Controls.Add(btn_clear);
            Controls.Add(tb_describe);
            Controls.Add(tb_image);
            Controls.Add(tb_adrr);
            Controls.Add(tb_price);
            Controls.Add(tb_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddFood";
            Text = "Themmonan";
            ((System.ComponentModel.ISupportInitialize)pct_food).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_adrr;
        private System.Windows.Forms.TextBox tb_image;
        private System.Windows.Forms.TextBox tb_describe;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private PictureBox pct_food;
    }
}