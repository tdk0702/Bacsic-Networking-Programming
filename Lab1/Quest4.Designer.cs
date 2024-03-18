
namespace LTMCB_Lab1
{
    partial class Quest4
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.lbTemp = new System.Windows.Forms.Label();
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.lbNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 158);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 31);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(104, 158);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(86, 31);
            this.btnDel.TabIndex = 21;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 158);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 31);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Hiện chữ";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxTemp
            // 
            this.tbxTemp.Location = new System.Drawing.Point(12, 73);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.ReadOnly = true;
            this.tbxTemp.Size = new System.Drawing.Size(270, 79);
            this.tbxTemp.TabIndex = 18;
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(12, 57);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(47, 13);
            this.lbTemp.TabIndex = 16;
            this.lbTemp.Text = "Kết quả:";
            // 
            // tbxNum
            // 
            this.tbxNum.Location = new System.Drawing.Point(12, 25);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 20);
            this.tbxNum.TabIndex = 19;
            this.tbxNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum_KeyDown);
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Location = new System.Drawing.Point(12, 9);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(100, 13);
            this.lbNum.TabIndex = 17;
            this.lbNum.Text = "Nhập số 12 chữ số:";
            // 
            // Quest4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 195);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbxTemp);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.lbNum);
            this.Name = "Quest4";
            this.Text = "Quest4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxTemp;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Label lbNum;
    }
}