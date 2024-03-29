
namespace Lab2
{
    partial class Form3
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
            this.btnRead = new System.Windows.Forms.Button();
            this.tbxRead = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRead.Location = new System.Drawing.Point(5, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(369, 32);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "ĐỌC FILE";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbxRead
            // 
            this.tbxRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxRead.Location = new System.Drawing.Point(5, 37);
            this.tbxRead.Multiline = true;
            this.tbxRead.Name = "tbxRead";
            this.tbxRead.Size = new System.Drawing.Size(369, 92);
            this.tbxRead.TabIndex = 1;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(5, 135);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(96, 32);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "TÍNH";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // tbxResult
            // 
            this.tbxResult.Location = new System.Drawing.Point(165, 135);
            this.tbxResult.Multiline = true;
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(209, 32);
            this.tbxResult.TabIndex = 3;
            this.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 187);
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.tbxRead);
            this.Controls.Add(this.btnRead);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Câu 3";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbxRead;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox tbxResult;
    }
}