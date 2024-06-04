
namespace Lab2.Form5
{
    partial class AddMovie
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxOrigin = new System.Windows.Forms.TextBox();
            this.lvName = new System.Windows.Forms.Label();
            this.lvOrigin = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lvTheater = new System.Windows.Forms.Label();
            this.tbxTheater = new System.Windows.Forms.TextBox();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(15, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 0;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // tbxOrigin
            // 
            this.tbxOrigin.Location = new System.Drawing.Point(15, 66);
            this.tbxOrigin.Name = "tbxOrigin";
            this.tbxOrigin.Size = new System.Drawing.Size(100, 20);
            this.tbxOrigin.TabIndex = 1;
            this.tbxOrigin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // lvName
            // 
            this.lvName.AutoSize = true;
            this.lvName.Location = new System.Drawing.Point(12, 11);
            this.lvName.Name = "lvName";
            this.lvName.Size = new System.Drawing.Size(54, 13);
            this.lvName.TabIndex = 2;
            this.lvName.Text = "Tên phim:";
            // 
            // lvOrigin
            // 
            this.lvOrigin.AutoSize = true;
            this.lvOrigin.Location = new System.Drawing.Point(12, 50);
            this.lvOrigin.Name = "lvOrigin";
            this.lvOrigin.Size = new System.Drawing.Size(50, 13);
            this.lvOrigin.TabIndex = 3;
            this.lvOrigin.Text = "Tên gốc:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(120, 11);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(82, 13);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Giá vé: (*.000đ)";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(123, 27);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxPrice.TabIndex = 4;
            this.tbxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // lvTheater
            // 
            this.lvTheater.AutoSize = true;
            this.lvTheater.Location = new System.Drawing.Point(12, 89);
            this.lvTheater.Name = "lvTheater";
            this.lvTheater.Size = new System.Drawing.Size(91, 13);
            this.lvTheater.TabIndex = 7;
            this.lvTheater.Text = "Các phòng chiếu:";
            // 
            // tbxTheater
            // 
            this.tbxTheater.Location = new System.Drawing.Point(15, 105);
            this.tbxTheater.Name = "tbxTheater";
            this.tbxTheater.Size = new System.Drawing.Size(208, 20);
            this.tbxTheater.TabIndex = 6;
            this.tbxTheater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // tbxData
            // 
            this.tbxData.Location = new System.Drawing.Point(13, 132);
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.Size = new System.Drawing.Size(210, 162);
            this.tbxData.TabIndex = 8;
            this.tbxData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 306);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.lvTheater);
            this.Controls.Add(this.tbxTheater);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lvOrigin);
            this.Controls.Add(this.lvName);
            this.Controls.Add(this.tbxOrigin);
            this.Controls.Add(this.tbxName);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxOrigin;
        private System.Windows.Forms.Label lvName;
        private System.Windows.Forms.Label lvOrigin;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lvTheater;
        private System.Windows.Forms.TextBox tbxTheater;
        private System.Windows.Forms.TextBox tbxData;
    }
}