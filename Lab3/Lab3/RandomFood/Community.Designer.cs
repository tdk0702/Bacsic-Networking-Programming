using System.Drawing;
using System.Windows.Forms;

namespace Lab3.RandomFood
{
    partial class Community
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
            this.cb_image = new System.Windows.Forms.CheckBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_food = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_image
            // 
            this.cb_image.AutoSize = true;
            this.cb_image.Enabled = false;
            this.cb_image.Location = new System.Drawing.Point(234, 270);
            this.cb_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_image.Name = "cb_image";
            this.cb_image.Size = new System.Drawing.Size(22, 21);
            this.cb_image.TabIndex = 65;
            this.cb_image.UseVisualStyleBackColor = true;
            // 
            // btn_image
            // 
            this.btn_image.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_image.Location = new System.Drawing.Point(66, 256);
            this.btn_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(162, 39);
            this.btn_image.TabIndex = 3;
            this.btn_image.Text = "Chọn ảnh";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(67, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 32);
            this.label4.TabIndex = 63;
            this.label4.Text = "Tên món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(67, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "Họ và tên";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_name.Location = new System.Drawing.Point(66, 127);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(275, 38);
            this.tb_name.TabIndex = 1;
            // 
            // tb_food
            // 
            this.tb_food.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_food.Location = new System.Drawing.Point(66, 206);
            this.tb_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_food.Multiline = true;
            this.tb_food.Name = "tb_food";
            this.tb_food.Size = new System.Drawing.Size(275, 38);
            this.tb_food.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_add.Location = new System.Drawing.Point(66, 299);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(274, 39);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm món ăn";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 32);
            this.label2.TabIndex = 66;
            this.label2.Text = "Cộng đồng đóng góp món ăn";
            // 
            // Community
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_image);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_food);
            this.Controls.Add(this.btn_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Community";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Community";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Community_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cb_image;
        private Button btn_image;
        private Label label4;
        private Label label1;
        private TextBox tb_name;
        private TextBox tb_food;
        private Button btn_add;
        private Label label2;
    }
}