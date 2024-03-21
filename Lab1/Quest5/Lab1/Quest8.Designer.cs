
namespace LTMCB_Lab1
{
    partial class Quest8
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(89, 10);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(293, 20);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(13, 13);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(70, 13);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Nhập dữ liệu:";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(16, 37);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(366, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Xử lý dữ liệu";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tbxTemp
            // 
            this.tbxTemp.Location = new System.Drawing.Point(16, 66);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.ReadOnly = true;
            this.tbxTemp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTemp.Size = new System.Drawing.Size(366, 211);
            this.tbxTemp.TabIndex = 99;
            this.tbxTemp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // Quest8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 289);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.tbxTemp);
            this.Controls.Add(this.tbxInput);
            this.Name = "Quest8";
            this.Text = "Quest8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox tbxTemp;
    }
}