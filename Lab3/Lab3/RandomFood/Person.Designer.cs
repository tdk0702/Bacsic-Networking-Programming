using System.Drawing;
using System.Windows.Forms;

namespace Lab3.RandomFood
{
    partial class Person
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_helo = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.result_text = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cb_image = new System.Windows.Forms.CheckBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_food = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.picture_food = new System.Windows.Forms.PictureBox();
            this.list_item = new System.Windows.Forms.ListView();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_food)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 33);
            this.label3.TabIndex = 64;
            this.label3.Text = "Món ăn hôm nay là:";
            // 
            // lb_helo
            // 
            this.lb_helo.AutoSize = true;
            this.lb_helo.BackColor = System.Drawing.Color.Transparent;
            this.lb_helo.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_helo.Location = new System.Drawing.Point(346, 23);
            this.lb_helo.Name = "lb_helo";
            this.lb_helo.Size = new System.Drawing.Size(371, 51);
            this.lb_helo.TabIndex = 63;
            this.lb_helo.Text = "Hôm nay bạn ăn gì";
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(981, 454);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(127, 41);
            this.btn_exit.TabIndex = 62;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // result_text
            // 
            this.result_text.BackColor = System.Drawing.Color.White;
            this.result_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_text.Location = new System.Drawing.Point(374, 398);
            this.result_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.ReadOnly = true;
            this.result_text.Size = new System.Drawing.Size(343, 79);
            this.result_text.TabIndex = 61;
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_find.Location = new System.Drawing.Point(159, 398);
            this.btn_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(151, 59);
            this.btn_find.TabIndex = 5;
            this.btn_find.Text = "Tìm món ăn";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cb_image
            // 
            this.cb_image.AutoSize = true;
            this.cb_image.Enabled = false;
            this.cb_image.Location = new System.Drawing.Point(202, 215);
            this.cb_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_image.Name = "cb_image";
            this.cb_image.Size = new System.Drawing.Size(22, 21);
            this.cb_image.TabIndex = 73;
            this.cb_image.UseVisualStyleBackColor = true;
            // 
            // btn_image
            // 
            this.btn_image.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_image.Location = new System.Drawing.Point(35, 202);
            this.btn_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(162, 49);
            this.btn_image.TabIndex = 3;
            this.btn_image.Text = "Chọn ảnh";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(35, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 32);
            this.label4.TabIndex = 71;
            this.label4.Text = "Tên món ăn";
            // 
            // tb_food
            // 
            this.tb_food.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_food.Location = new System.Drawing.Point(36, 136);
            this.tb_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_food.Multiline = true;
            this.tb_food.Name = "tb_food";
            this.tb_food.Size = new System.Drawing.Size(275, 49);
            this.tb_food.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_add.Location = new System.Drawing.Point(36, 267);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(162, 48);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm món ăn";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // picture_food
            // 
            this.picture_food.Location = new System.Drawing.Point(806, 102);
            this.picture_food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_food.Name = "picture_food";
            this.picture_food.Size = new System.Drawing.Size(310, 252);
            this.picture_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_food.TabIndex = 66;
            this.picture_food.TabStop = false;
            // 
            // list_item
            // 
            this.list_item.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_item.HideSelection = false;
            this.list_item.Location = new System.Drawing.Point(350, 102);
            this.list_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(450, 252);
            this.list_item.TabIndex = 65;
            this.list_item.UseCompatibleStateImageBehavior = false;
            this.list_item.View = System.Windows.Forms.View.List;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_delete.Location = new System.Drawing.Point(216, 267);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 48);
            this.btn_delete.TabIndex = 60;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 515);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_helo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.cb_image);
            this.Controls.Add(this.btn_image);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_food);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.picture_food);
            this.Controls.Add(this.list_item);
            this.Controls.Add(this.btn_delete);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Person_FormClosed);
            this.Load += new System.EventHandler(this.Person_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label lb_helo;
        private Button btn_exit;
        private TextBox result_text;
        private Button btn_find;
        private ErrorProvider errorProvider1;
        private CheckBox cb_image;
        private Button btn_image;
        private Label label4;
        private TextBox tb_food;
        private Button btn_add;
        private PictureBox picture_food;
        private ListView list_item;
        private Button btn_delete;
    }
}