
namespace Lab2
{
    partial class Form1
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
            this.tbxShow = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRead.Location = new System.Drawing.Point(5, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(288, 32);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "ĐỌC FILE";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // tbxShow
            // 
            this.tbxShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxShow.Location = new System.Drawing.Point(5, 69);
            this.tbxShow.Multiline = true;
            this.tbxShow.Name = "tbxShow";
            this.tbxShow.ReadOnly = true;
            this.tbxShow.Size = new System.Drawing.Size(288, 145);
            this.tbxShow.TabIndex = 1;
            // 
            // btnWrite
            // 
            this.btnWrite.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWrite.Location = new System.Drawing.Point(5, 37);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(288, 32);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "GHI FILE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 263);
            this.Controls.Add(this.tbxShow);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox tbxShow;
        private System.Windows.Forms.Button btnWrite;
    }
}