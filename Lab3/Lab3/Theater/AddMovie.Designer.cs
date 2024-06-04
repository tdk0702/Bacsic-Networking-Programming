
namespace Lab3.Theater
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Tên phim",
            "99.999đ"}, -1);
            this.pData = new System.Windows.Forms.Panel();
            this.lvData = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pInput = new System.Windows.Forms.Panel();
            this.clbTheater = new System.Windows.Forms.CheckedListBox();
            this.lvTheater = new System.Windows.Forms.Label();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbxOrigin = new System.Windows.Forms.TextBox();
            this.lvOrigin = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lvName = new System.Windows.Forms.Label();
            this.pData.SuspendLayout();
            this.pInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // pData
            // 
            this.pData.Controls.Add(this.lvData);
            this.pData.Dock = System.Windows.Forms.DockStyle.Right;
            this.pData.Location = new System.Drawing.Point(241, 5);
            this.pData.Name = "pData";
            this.pData.Padding = new System.Windows.Forms.Padding(5);
            this.pData.Size = new System.Drawing.Size(274, 296);
            this.pData.TabIndex = 9;
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Mname,
            this.Price});
            this.lvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvData.HideSelection = false;
            this.lvData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvData.Location = new System.Drawing.Point(5, 5);
            this.lvData.Name = "lvData";
            this.lvData.ShowGroups = false;
            this.lvData.ShowItemToolTips = true;
            this.lvData.Size = new System.Drawing.Size(264, 286);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            this.lvData.SelectedIndexChanged += new System.EventHandler(this.lvData_SelectedIndexChanged);
            this.lvData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvData_KeyDown);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 28;
            // 
            // Mname
            // 
            this.Mname.Text = "Tên phim";
            this.Mname.Width = 165;
            // 
            // Price
            // 
            this.Price.Text = "Giá";
            this.Price.Width = 85;
            // 
            // pInput
            // 
            this.pInput.Controls.Add(this.clbTheater);
            this.pInput.Controls.Add(this.lvTheater);
            this.pInput.Controls.Add(this.tbxInfo);
            this.pInput.Controls.Add(this.lbInfo);
            this.pInput.Controls.Add(this.tbxPrice);
            this.pInput.Controls.Add(this.lbPrice);
            this.pInput.Controls.Add(this.tbxOrigin);
            this.pInput.Controls.Add(this.lvOrigin);
            this.pInput.Controls.Add(this.tbxName);
            this.pInput.Controls.Add(this.lvName);
            this.pInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pInput.Location = new System.Drawing.Point(5, 5);
            this.pInput.Name = "pInput";
            this.pInput.Padding = new System.Windows.Forms.Padding(5);
            this.pInput.Size = new System.Drawing.Size(219, 296);
            this.pInput.TabIndex = 10;
            // 
            // clbTheater
            // 
            this.clbTheater.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbTheater.FormattingEnabled = true;
            this.clbTheater.Location = new System.Drawing.Point(5, 150);
            this.clbTheater.Name = "clbTheater";
            this.clbTheater.ScrollAlwaysVisible = true;
            this.clbTheater.Size = new System.Drawing.Size(209, 94);
            this.clbTheater.TabIndex = 28;
            this.clbTheater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // lvTheater
            // 
            this.lvTheater.AutoSize = true;
            this.lvTheater.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvTheater.Location = new System.Drawing.Point(5, 137);
            this.lvTheater.Name = "lvTheater";
            this.lvTheater.Size = new System.Drawing.Size(91, 13);
            this.lvTheater.TabIndex = 27;
            this.lvTheater.Text = "Các phòng chiếu:";
            // 
            // tbxInfo
            // 
            this.tbxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxInfo.Location = new System.Drawing.Point(5, 117);
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.Size = new System.Drawing.Size(209, 20);
            this.tbxInfo.TabIndex = 26;
            this.tbxInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInfo.Location = new System.Drawing.Point(5, 104);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(81, 13);
            this.lbInfo.TabIndex = 25;
            this.lbInfo.Text = "Thông tin thêm:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxPrice.Location = new System.Drawing.Point(5, 84);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(209, 20);
            this.tbxPrice.TabIndex = 21;
            this.tbxPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPrice.Location = new System.Drawing.Point(5, 71);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(82, 13);
            this.lbPrice.TabIndex = 20;
            this.lbPrice.Text = "Giá vé: (*.000đ)";
            // 
            // tbxOrigin
            // 
            this.tbxOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxOrigin.Location = new System.Drawing.Point(5, 51);
            this.tbxOrigin.Name = "tbxOrigin";
            this.tbxOrigin.Size = new System.Drawing.Size(209, 20);
            this.tbxOrigin.TabIndex = 19;
            this.tbxOrigin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // lvOrigin
            // 
            this.lvOrigin.AutoSize = true;
            this.lvOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvOrigin.Location = new System.Drawing.Point(5, 38);
            this.lvOrigin.Name = "lvOrigin";
            this.lvOrigin.Size = new System.Drawing.Size(50, 13);
            this.lvOrigin.TabIndex = 18;
            this.lvOrigin.Text = "Tên gốc:";
            // 
            // tbxName
            // 
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxName.Location = new System.Drawing.Point(5, 18);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(209, 20);
            this.tbxName.TabIndex = 17;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxData_KeyDown);
            // 
            // lvName
            // 
            this.lvName.AutoSize = true;
            this.lvName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvName.Location = new System.Drawing.Point(5, 5);
            this.lvName.Name = "lvName";
            this.lvName.Size = new System.Drawing.Size(54, 13);
            this.lvName.TabIndex = 16;
            this.lvName.Text = "Tên phim:";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 306);
            this.Controls.Add(this.pInput);
            this.Controls.Add(this.pData);
            this.KeyPreview = true;
            this.Name = "AddMovie";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.pData.ResumeLayout(false);
            this.pInput.ResumeLayout(false);
            this.pInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Panel pInput;
        private System.Windows.Forms.TextBox tbxOrigin;
        private System.Windows.Forms.Label lvOrigin;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lvName;
        private System.Windows.Forms.CheckedListBox clbTheater;
        private System.Windows.Forms.Label lvTheater;
        private System.Windows.Forms.TextBox tbxInfo;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Mname;
        private System.Windows.Forms.ColumnHeader Price;
    }
}