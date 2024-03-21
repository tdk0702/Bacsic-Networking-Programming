
namespace LTMCB_Lab1
{
    partial class Quest9
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
            this.lsbShow = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(13, 13);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(74, 13);
            this.lbInput.TabIndex = 99;
            this.lbInput.Text = "Nhập món ăn:";
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(13, 30);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(175, 20);
            this.tbxInput.TabIndex = 1;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // lsbShow
            // 
            this.lsbShow.FormattingEnabled = true;
            this.lsbShow.Location = new System.Drawing.Point(194, 12);
            this.lsbShow.Name = "lsbShow";
            this.lsbShow.ScrollAlwaysVisible = true;
            this.lsbShow.Size = new System.Drawing.Size(173, 121);
            this.lsbShow.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(175, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(13, 97);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(175, 34);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xoá món";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDel_MouseClick);
            this.btnDel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDel_MouseDown);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 139);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(355, 22);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm món ăn";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxTemp
            // 
            this.tbxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTemp.Location = new System.Drawing.Point(12, 190);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.ReadOnly = true;
            this.tbxTemp.Size = new System.Drawing.Size(355, 48);
            this.tbxTemp.TabIndex = 99;
            this.tbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Hôm nay ăn món:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quest9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTemp);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsbShow);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.lbInput);
            this.Name = "Quest9";
            this.ShowIcon = false;
            this.Text = "Quest9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.ListBox lsbShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxTemp;
        private System.Windows.Forms.Label label1;
    }
}