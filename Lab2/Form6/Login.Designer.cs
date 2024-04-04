
namespace Lab2.Form6
{
    partial class Login
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
            this.cbxChoose = new System.Windows.Forms.ComboBox();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbxChoose
            // 
            this.cbxChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxChoose.FormattingEnabled = true;
            this.cbxChoose.Location = new System.Drawing.Point(5, 5);
            this.cbxChoose.Name = "cbxChoose";
            this.cbxChoose.Size = new System.Drawing.Size(284, 21);
            this.cbxChoose.TabIndex = 0;
            this.cbxChoose.SelectedIndexChanged += new System.EventHandler(this.cbxChoose_SelectedIndexChanged);
            // 
            // tbxData
            // 
            this.tbxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxData.Location = new System.Drawing.Point(5, 26);
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.ReadOnly = true;
            this.tbxData.Size = new System.Drawing.Size(284, 128);
            this.tbxData.TabIndex = 1;
            this.tbxData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 159);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.cbxChoose);
            this.KeyPreview = true;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxChoose;
        private System.Windows.Forms.TextBox tbxData;
    }
}