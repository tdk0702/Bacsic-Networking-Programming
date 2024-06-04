
namespace Theater.Server
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "0", "Tên phim", "99.999đ" }, -1);
            pData = new Panel();
            lvData = new ListView();
            Id = new ColumnHeader();
            Mname = new ColumnHeader();
            Price = new ColumnHeader();
            pInput = new Panel();
            clbTheater = new CheckedListBox();
            lvTheater = new Label();
            tbxPrice = new TextBox();
            lbPrice = new Label();
            tbxOrigin = new TextBox();
            lvOrigin = new Label();
            tbxName = new TextBox();
            lvName = new Label();
            pUrl = new Panel();
            btnGet = new Button();
            tbxUrl = new TextBox();
            pData.SuspendLayout();
            pInput.SuspendLayout();
            pUrl.SuspendLayout();
            SuspendLayout();
            // 
            // pData
            // 
            pData.Controls.Add(lvData);
            pData.Dock = DockStyle.Right;
            pData.Location = new Point(281, 6);
            pData.Margin = new Padding(4, 3, 4, 3);
            pData.Name = "pData";
            pData.Padding = new Padding(6);
            pData.Size = new Size(320, 376);
            pData.TabIndex = 9;
            // 
            // lvData
            // 
            lvData.Columns.AddRange(new ColumnHeader[] { Id, Mname, Price });
            lvData.Dock = DockStyle.Fill;
            lvData.FullRowSelect = true;
            lvData.GridLines = true;
            lvData.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvData.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvData.Location = new Point(6, 6);
            lvData.Margin = new Padding(4, 3, 4, 3);
            lvData.Name = "lvData";
            lvData.ShowGroups = false;
            lvData.ShowItemToolTips = true;
            lvData.Size = new Size(308, 364);
            lvData.TabIndex = 0;
            lvData.UseCompatibleStateImageBehavior = false;
            lvData.View = View.Details;
            lvData.SelectedIndexChanged += lvData_SelectedIndexChanged;
            lvData.KeyDown += lvData_KeyDown;
            // 
            // Id
            // 
            Id.Text = "ID";
            Id.Width = 28;
            // 
            // Mname
            // 
            Mname.Text = "Tên phim";
            Mname.Width = 165;
            // 
            // Price
            // 
            Price.Text = "Giá";
            Price.Width = 85;
            // 
            // pInput
            // 
            pInput.Controls.Add(clbTheater);
            pInput.Controls.Add(lvTheater);
            pInput.Controls.Add(tbxPrice);
            pInput.Controls.Add(lbPrice);
            pInput.Controls.Add(tbxOrigin);
            pInput.Controls.Add(lvOrigin);
            pInput.Controls.Add(tbxName);
            pInput.Controls.Add(lvName);
            pInput.Dock = DockStyle.Top;
            pInput.Location = new Point(6, 6);
            pInput.Margin = new Padding(4, 3, 4, 3);
            pInput.Name = "pInput";
            pInput.Padding = new Padding(6);
            pInput.Size = new Size(275, 308);
            pInput.TabIndex = 10;
            // 
            // clbTheater
            // 
            clbTheater.Dock = DockStyle.Top;
            clbTheater.FormattingEnabled = true;
            clbTheater.Location = new Point(6, 188);
            clbTheater.Margin = new Padding(4, 3, 4, 3);
            clbTheater.Name = "clbTheater";
            clbTheater.ScrollAlwaysVisible = true;
            clbTheater.Size = new Size(263, 94);
            clbTheater.TabIndex = 28;
            clbTheater.KeyDown += tbxData_KeyDown;
            // 
            // lvTheater
            // 
            lvTheater.AutoSize = true;
            lvTheater.Dock = DockStyle.Top;
            lvTheater.Location = new Point(6, 173);
            lvTheater.Margin = new Padding(4, 0, 4, 0);
            lvTheater.Name = "lvTheater";
            lvTheater.Size = new Size(100, 15);
            lvTheater.TabIndex = 27;
            lvTheater.Text = "Các phòng chiếu:";
            // 
            // tbxPrice
            // 
            tbxPrice.Dock = DockStyle.Top;
            tbxPrice.Location = new Point(6, 150);
            tbxPrice.Margin = new Padding(4, 3, 4, 3);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(263, 23);
            tbxPrice.TabIndex = 21;
            tbxPrice.KeyDown += tbxData_KeyDown;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Dock = DockStyle.Top;
            lbPrice.Location = new Point(6, 135);
            lbPrice.Margin = new Padding(4, 0, 4, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(86, 15);
            lbPrice.TabIndex = 20;
            lbPrice.Text = "Giá vé: (*.000đ)";
            // 
            // tbxOrigin
            // 
            tbxOrigin.Dock = DockStyle.Top;
            tbxOrigin.Location = new Point(6, 59);
            tbxOrigin.Margin = new Padding(4, 3, 4, 3);
            tbxOrigin.Multiline = true;
            tbxOrigin.Name = "tbxOrigin";
            tbxOrigin.ScrollBars = ScrollBars.Vertical;
            tbxOrigin.Size = new Size(263, 76);
            tbxOrigin.TabIndex = 19;
            tbxOrigin.KeyDown += tbxData_KeyDown;
            // 
            // lvOrigin
            // 
            lvOrigin.AutoSize = true;
            lvOrigin.Dock = DockStyle.Top;
            lvOrigin.Location = new Point(6, 44);
            lvOrigin.Margin = new Padding(4, 0, 4, 0);
            lvOrigin.Name = "lvOrigin";
            lvOrigin.Size = new Size(97, 15);
            lvOrigin.TabIndex = 18;
            lvOrigin.Text = "Thông tin chi tiết";
            // 
            // tbxName
            // 
            tbxName.Dock = DockStyle.Top;
            tbxName.Location = new Point(6, 21);
            tbxName.Margin = new Padding(4, 3, 4, 3);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(263, 23);
            tbxName.TabIndex = 17;
            tbxName.KeyDown += tbxData_KeyDown;
            // 
            // lvName
            // 
            lvName.AutoSize = true;
            lvName.Dock = DockStyle.Top;
            lvName.Location = new Point(6, 6);
            lvName.Margin = new Padding(4, 0, 4, 0);
            lvName.Name = "lvName";
            lvName.Size = new Size(59, 15);
            lvName.TabIndex = 16;
            lvName.Text = "Tên phim:";
            // 
            // pUrl
            // 
            pUrl.Controls.Add(btnGet);
            pUrl.Controls.Add(tbxUrl);
            pUrl.Dock = DockStyle.Bottom;
            pUrl.Location = new Point(6, 320);
            pUrl.Name = "pUrl";
            pUrl.Padding = new Padding(5);
            pUrl.Size = new Size(275, 62);
            pUrl.TabIndex = 11;
            // 
            // btnGet
            // 
            btnGet.Dock = DockStyle.Top;
            btnGet.Location = new Point(5, 28);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(265, 23);
            btnGet.TabIndex = 32;
            btnGet.Text = "Lấy từ URL và nhận phòng chiếu ngẫu nhiên";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // tbxUrl
            // 
            tbxUrl.Dock = DockStyle.Top;
            tbxUrl.Location = new Point(5, 5);
            tbxUrl.Name = "tbxUrl";
            tbxUrl.Size = new Size(265, 23);
            tbxUrl.TabIndex = 31;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 388);
            Controls.Add(pUrl);
            Controls.Add(pInput);
            Controls.Add(pData);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddMovie";
            Padding = new Padding(6);
            Text = "AddMovie";
            Load += AddMovie_Load;
            pData.ResumeLayout(false);
            pInput.ResumeLayout(false);
            pInput.PerformLayout();
            pUrl.ResumeLayout(false);
            pUrl.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Mname;
        private System.Windows.Forms.ColumnHeader Price;
        private Panel pUrl;
        private Button btnGet;
        private TextBox tbxUrl;
    }
}