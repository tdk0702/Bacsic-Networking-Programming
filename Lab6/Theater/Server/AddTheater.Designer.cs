namespace Theater.Server
{
    partial class AddTheater
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Rạp 0",
            "99",
            "99",
            "99"}, -1);
            this.pInput = new System.Windows.Forms.Panel();
            this.nudSweet = new System.Windows.Forms.NumericUpDown();
            this.lbSweet = new System.Windows.Forms.Label();
            this.nudVip = new System.Windows.Forms.NumericUpDown();
            this.lbVip = new System.Windows.Forms.Label();
            this.nudNormal = new System.Windows.Forms.NumericUpDown();
            this.lbNormal = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pData = new System.Windows.Forms.Panel();
            this.lvData = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Normal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sweet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSweet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormal)).BeginInit();
            this.pData.SuspendLayout();
            this.SuspendLayout();
            // 
            // pInput
            // 
            this.pInput.Controls.Add(this.nudSweet);
            this.pInput.Controls.Add(this.lbSweet);
            this.pInput.Controls.Add(this.nudVip);
            this.pInput.Controls.Add(this.lbVip);
            this.pInput.Controls.Add(this.nudNormal);
            this.pInput.Controls.Add(this.lbNormal);
            this.pInput.Controls.Add(this.tbxName);
            this.pInput.Controls.Add(this.lbName);
            this.pInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pInput.Location = new System.Drawing.Point(0, 0);
            this.pInput.Name = "pInput";
            this.pInput.Padding = new System.Windows.Forms.Padding(5);
            this.pInput.Size = new System.Drawing.Size(175, 177);
            this.pInput.TabIndex = 2;
            // 
            // nudSweet
            // 
            this.nudSweet.AutoSize = true;
            this.nudSweet.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudSweet.Location = new System.Drawing.Point(5, 117);
            this.nudSweet.Name = "nudSweet";
            this.nudSweet.Size = new System.Drawing.Size(165, 20);
            this.nudSweet.TabIndex = 9;
            // 
            // lbSweet
            // 
            this.lbSweet.AutoSize = true;
            this.lbSweet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSweet.Location = new System.Drawing.Point(5, 104);
            this.lbSweet.Name = "lbSweet";
            this.lbSweet.Size = new System.Drawing.Size(95, 13);
            this.lbSweet.TabIndex = 8;
            this.lbSweet.Text = "Số ghế SweetBox:";
            // 
            // nudVip
            // 
            this.nudVip.AutoSize = true;
            this.nudVip.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudVip.Location = new System.Drawing.Point(5, 84);
            this.nudVip.Name = "nudVip";
            this.nudVip.Size = new System.Drawing.Size(165, 20);
            this.nudVip.TabIndex = 7;
            // 
            // lbVip
            // 
            this.lbVip.AutoSize = true;
            this.lbVip.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbVip.Location = new System.Drawing.Point(5, 71);
            this.lbVip.Name = "lbVip";
            this.lbVip.Size = new System.Drawing.Size(64, 13);
            this.lbVip.TabIndex = 6;
            this.lbVip.Text = "Số ghế VIP:";
            // 
            // nudNormal
            // 
            this.nudNormal.AutoSize = true;
            this.nudNormal.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudNormal.Location = new System.Drawing.Point(5, 51);
            this.nudNormal.Name = "nudNormal";
            this.nudNormal.Size = new System.Drawing.Size(165, 20);
            this.nudNormal.TabIndex = 5;
            // 
            // lbNormal
            // 
            this.lbNormal.AutoSize = true;
            this.lbNormal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNormal.Location = new System.Drawing.Point(5, 38);
            this.lbNormal.Name = "lbNormal";
            this.lbNormal.Size = new System.Drawing.Size(80, 13);
            this.lbNormal.TabIndex = 4;
            this.lbNormal.Text = "Số ghế thường:";
            // 
            // tbxName
            // 
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxName.Location = new System.Drawing.Point(5, 18);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(165, 20);
            this.tbxName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(5, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 13);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Tên:";
            // 
            // pData
            // 
            this.pData.Controls.Add(this.lvData);
            this.pData.Dock = System.Windows.Forms.DockStyle.Right;
            this.pData.Location = new System.Drawing.Point(181, 0);
            this.pData.Name = "pData";
            this.pData.Padding = new System.Windows.Forms.Padding(5);
            this.pData.Size = new System.Drawing.Size(287, 177);
            this.pData.TabIndex = 3;
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.TName,
            this.Normal,
            this.Vip,
            this.Sweet});
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HideSelection = false;
            this.lvData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvData.Location = new System.Drawing.Point(5, 5);
            this.lvData.Name = "lvData";
            this.lvData.ShowGroups = false;
            this.lvData.ShowItemToolTips = true;
            this.lvData.Size = new System.Drawing.Size(277, 167);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            this.lvData.SelectedIndexChanged += new System.EventHandler(this.lvData_SelectedIndexChanged);
            this.lvData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvData_KeyDown);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 23;
            // 
            // TName
            // 
            this.TName.Text = "Tên";
            this.TName.Width = 55;
            // 
            // Normal
            // 
            this.Normal.Text = "Ghế thường";
            // 
            // Vip
            // 
            this.Vip.Text = "Ghế VIP";
            // 
            // Sweet
            // 
            this.Sweet.Text = "SweetBox";
            // 
            // AddTheater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 177);
            this.Controls.Add(this.pData);
            this.Controls.Add(this.pInput);
            this.KeyPreview = true;
            this.Name = "AddTheater";
            this.Text = "AddTheaters";
            this.Load += new System.EventHandler(this.AddTheater_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddTheater_KeyDown);
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSweet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormal)).EndInit();
            this.pData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.NumericUpDown nudSweet;
        private System.Windows.Forms.Label lbSweet;
        private System.Windows.Forms.NumericUpDown nudVip;
        private System.Windows.Forms.Label lbVip;
        private System.Windows.Forms.NumericUpDown nudNormal;
        private System.Windows.Forms.Label lbNormal;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader TName;
        private System.Windows.Forms.ColumnHeader Normal;
        private System.Windows.Forms.ColumnHeader Vip;
        private System.Windows.Forms.ColumnHeader Sweet;
    }
}