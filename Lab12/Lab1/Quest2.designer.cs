
namespace Lab1
{
    partial class Quest2
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
            this.lbNum1 = new System.Windows.Forms.Label();
            this.tbxNum1 = new System.Windows.Forms.TextBox();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.tbxNum2 = new System.Windows.Forms.TextBox();
            this.lbNum3 = new System.Windows.Forms.Label();
            this.tbxNum3 = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.lbMin = new System.Windows.Forms.Label();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(12, 9);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(50, 13);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Số thứ 1:";
            // 
            // tbxNum1
            // 
            this.tbxNum1.Location = new System.Drawing.Point(12, 25);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(100, 20);
            this.tbxNum1.TabIndex = 1;
            this.tbxNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum1_KeyDown);
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(12, 61);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(50, 13);
            this.lbNum2.TabIndex = 0;
            this.lbNum2.Text = "Số thứ 2:";
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(12, 77);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(100, 20);
            this.tbxNum2.TabIndex = 1;
            this.tbxNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum2_KeyDown);
            // 
            // lbNum3
            // 
            this.lbNum3.AutoSize = true;
            this.lbNum3.Location = new System.Drawing.Point(12, 113);
            this.lbNum3.Name = "lbNum3";
            this.lbNum3.Size = new System.Drawing.Size(50, 13);
            this.lbNum3.TabIndex = 0;
            this.lbNum3.Text = "Số thứ 3:";
            // 
            // tbxNum3
            // 
            this.tbxNum3.Location = new System.Drawing.Point(12, 129);
            this.tbxNum3.Name = "tbxNum3";
            this.tbxNum3.Size = new System.Drawing.Size(100, 20);
            this.tbxNum3.TabIndex = 1;
            this.tbxNum3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum3_KeyDown);
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(182, 9);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(64, 13);
            this.lbMax.TabIndex = 0;
            this.lbMax.Text = "Số lớn nhất:";
            // 
            // tbxMax
            // 
            this.tbxMax.Location = new System.Drawing.Point(182, 25);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.ReadOnly = true;
            this.tbxMax.Size = new System.Drawing.Size(100, 20);
            this.tbxMax.TabIndex = 1;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(182, 61);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(68, 13);
            this.lbMin.TabIndex = 0;
            this.lbMin.Text = "Số nhỏ nhất:";
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(182, 77);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.ReadOnly = true;
            this.tbxMin.Size = new System.Drawing.Size(100, 20);
            this.tbxMin.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 166);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 31);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(104, 166);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 31);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Quest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 204);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbxNum3);
            this.Controls.Add(this.lbNum3);
            this.Controls.Add(this.tbxMin);
            this.Controls.Add(this.tbxMax);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.tbxNum1);
            this.Controls.Add(this.lbNum1);
            this.Name = "Quest2";
            this.Text = "Quest2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.Label lbNum3;
        private System.Windows.Forms.TextBox tbxNum3;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
    }
}