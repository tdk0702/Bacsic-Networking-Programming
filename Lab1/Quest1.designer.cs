
namespace Lab1
{
    partial class Quest1
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
            this.lbSum = new System.Windows.Forms.Label();
            this.tbxSum = new System.Windows.Forms.TextBox();
            this.lbHead = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.Location = new System.Drawing.Point(12, 58);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(50, 13);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "Số thứ 1:";
            // 
            // tbxNum1
            // 
            this.tbxNum1.Location = new System.Drawing.Point(68, 55);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(100, 20);
            this.tbxNum1.TabIndex = 1;
            this.tbxNum1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum1_KeyDown);
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.Location = new System.Drawing.Point(12, 84);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(50, 13);
            this.lbNum2.TabIndex = 0;
            this.lbNum2.Text = "Số thứ 2:";
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(68, 81);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(100, 20);
            this.tbxNum2.TabIndex = 1;
            this.tbxNum2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxNum2_KeyDown);
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(12, 110);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(47, 13);
            this.lbSum.TabIndex = 0;
            this.lbSum.Text = "Kết quả:";
            // 
            // tbxSum
            // 
            this.tbxSum.Location = new System.Drawing.Point(68, 107);
            this.tbxSum.Name = "tbxSum";
            this.tbxSum.ReadOnly = true;
            this.tbxSum.Size = new System.Drawing.Size(100, 20);
            this.tbxSum.TabIndex = 1;
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHead.Location = new System.Drawing.Point(13, 13);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(198, 24);
            this.lbHead.TabIndex = 2;
            this.lbHead.Text = "CỘNG 2 SỐ NGUYÊN";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(93, 133);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Tính toán";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // Quest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 173);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lbHead);
            this.Controls.Add(this.tbxSum);
            this.Controls.Add(this.lbSum);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.tbxNum1);
            this.Controls.Add(this.lbNum1);
            this.Name = "Quest1";
            this.Text = "Câu 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.TextBox tbxSum;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Button btnCal;
    }
}