
namespace LTMCB_Lab1
{
    partial class Quest6
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
            this.lbNum2 = new System.Windows.Forms.Label();
            this.tbxNum1 = new System.Windows.Forms.TextBox();
            this.tbxNum2 = new System.Windows.Forms.TextBox();
            this.cbxChoose = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(13, 13);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(46, 13);
            this.lbNum1.TabIndex = 99;
            this.lbNum1.Text = "Nhập A:";
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(13, 53);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(46, 13);
            this.lbNum2.TabIndex = 99;
            this.lbNum2.Text = "Nhập B:";
            // 
            // tbxNum1
            // 
            this.tbxNum1.Location = new System.Drawing.Point(16, 30);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(100, 20);
            this.tbxNum1.TabIndex = 1;
            this.tbxNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum1_KeyDown);
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(16, 69);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(100, 20);
            this.tbxNum2.TabIndex = 2;
            this.tbxNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum2_KeyDown);
            // 
            // cbxChoose
            // 
            this.cbxChoose.FormattingEnabled = true;
            this.cbxChoose.Items.AddRange(new object[] {
            "Bảng cửu chương",
            "Tính toán giá trị"});
            this.cbxChoose.Location = new System.Drawing.Point(156, 29);
            this.cbxChoose.Name = "cbxChoose";
            this.cbxChoose.Size = new System.Drawing.Size(121, 21);
            this.cbxChoose.TabIndex = 3;
            this.cbxChoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxChoose_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 95);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(108, 95);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 31);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(16, 95);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 31);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tính";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxTemp
            // 
            this.tbxTemp.Location = new System.Drawing.Point(16, 157);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.ReadOnly = true;
            this.tbxTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTemp.Size = new System.Drawing.Size(270, 110);
            this.tbxTemp.TabIndex = 99;
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(13, 141);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(44, 13);
            this.lbTemp.TabIndex = 0;
            this.lbTemp.Text = "Kết quả";
            // 
            // Quest6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 282);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cbxChoose);
            this.Controls.Add(this.tbxTemp);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.tbxNum1);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Name = "Quest6";
            this.ShowIcon = false;
            this.Text = "Quest6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.ComboBox cbxChoose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxTemp;
        private System.Windows.Forms.Label lbTemp;
    }
}