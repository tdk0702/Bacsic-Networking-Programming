
namespace Lab1
{
    partial class Quest7
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
            this.lbInput = new System.Windows.Forms.Label();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.btnTemp = new System.Windows.Forms.Button();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(13, 13);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(110, 13);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Ngày tháng năm sinh:";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(16, 30);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(118, 20);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(140, 12);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(56, 38);
            this.btnTemp.TabIndex = 2;
            this.btnTemp.Text = "OK";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // tbxTemp
            // 
            this.tbxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTemp.Location = new System.Drawing.Point(16, 56);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.ReadOnly = true;
            this.tbxTemp.Size = new System.Drawing.Size(180, 54);
            this.tbxTemp.TabIndex = 1;
            this.tbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Quest7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 122);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.tbxTemp);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lbInput);
            this.Name = "Quest7";
            this.Text = "Quest7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.TextBox tbxTemp;
    }
}