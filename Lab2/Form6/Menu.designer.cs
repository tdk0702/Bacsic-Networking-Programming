
namespace Lab2.Form6
{
    partial class Menu
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
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pInput = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lsbShow = new System.Windows.Forms.ListBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.pInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxTemp
            // 
            this.tbxTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTemp.Location = new System.Drawing.Point(0, 280);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.ReadOnly = true;
            this.tbxTemp.Size = new System.Drawing.Size(379, 51);
            this.tbxTemp.TabIndex = 99;
            this.tbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 23);
            this.label1.TabIndex = 99;
            this.label1.Text = "Hôm nay ăn món:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pInput
            // 
            this.pInput.Controls.Add(this.btnAdd);
            this.pInput.Controls.Add(this.tbxInput);
            this.pInput.Controls.Add(this.lbInput);
            this.pInput.Controls.Add(this.lbUser);
            this.pInput.Controls.Add(this.lsbShow);
            this.pInput.Controls.Add(this.btnFind);
            this.pInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInput.Location = new System.Drawing.Point(0, 0);
            this.pInput.Name = "pInput";
            this.pInput.Padding = new System.Windows.Forms.Padding(5);
            this.pInput.Size = new System.Drawing.Size(379, 198);
            this.pInput.TabIndex = 100;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(5, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(196, 29);
            this.btnAdd.TabIndex = 113;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxInput.Location = new System.Drawing.Point(5, 41);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(196, 20);
            this.tbxInput.TabIndex = 112;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInput.Location = new System.Drawing.Point(5, 28);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(74, 13);
            this.lbInput.TabIndex = 111;
            this.lbInput.Text = "Nhập món ăn:";
            // 
            // lbUser
            // 
            this.lbUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUser.Location = new System.Drawing.Point(5, 5);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(196, 23);
            this.lbUser.TabIndex = 110;
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsbShow
            // 
            this.lsbShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsbShow.FormattingEnabled = true;
            this.lsbShow.Location = new System.Drawing.Point(201, 5);
            this.lsbShow.Name = "lsbShow";
            this.lsbShow.ScrollAlwaysVisible = true;
            this.lsbShow.Size = new System.Drawing.Size(173, 161);
            this.lsbShow.TabIndex = 103;
            // 
            // btnFind
            // 
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFind.Location = new System.Drawing.Point(5, 166);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(369, 27);
            this.btnFind.TabIndex = 100;
            this.btnFind.Text = "Tìm món ăn";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 331);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTemp);
            this.KeyPreview = true;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.Text = "Chọn món ăn";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form6_KeyDown);
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lsbShow;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnAdd;
    }
}