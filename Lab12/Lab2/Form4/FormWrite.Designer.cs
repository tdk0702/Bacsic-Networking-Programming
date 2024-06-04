
namespace Lab2.Form4
{
    partial class FormWrite
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
            "1",
            "Trương Duy Khôi",
            "22520702"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.btnAddtofile = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReadfrfile = new System.Windows.Forms.Button();
            this.tcInfo = new System.Windows.Forms.TabControl();
            this.page1 = new System.Windows.Forms.TabPage();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.page2 = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.tbxScore3 = new System.Windows.Forms.TextBox();
            this.lbScore3 = new System.Windows.Forms.Label();
            this.tbxScore2 = new System.Windows.Forms.TextBox();
            this.lbScore2 = new System.Windows.Forms.Label();
            this.tbxScore1 = new System.Windows.Forms.TextBox();
            this.lbScore1 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbAvg = new System.Windows.Forms.Label();
            this.tbxAvg = new System.Windows.Forms.TextBox();
            this.tcInfo.SuspendLayout();
            this.page1.SuspendLayout();
            this.page2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddtofile
            // 
            this.btnAddtofile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddtofile.Location = new System.Drawing.Point(0, 33);
            this.btnAddtofile.Name = "btnAddtofile";
            this.btnAddtofile.Size = new System.Drawing.Size(515, 33);
            this.btnAddtofile.TabIndex = 1;
            this.btnAddtofile.Text = "Ghi dữ liệu vào tệp";
            this.btnAddtofile.UseVisualStyleBackColor = true;
            this.btnAddtofile.Click += new System.EventHandler(this.btnAddtofile_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(515, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Tạo thêm dữ liệu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReadfrfile
            // 
            this.btnReadfrfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReadfrfile.Location = new System.Drawing.Point(0, 66);
            this.btnReadfrfile.Name = "btnReadfrfile";
            this.btnReadfrfile.Size = new System.Drawing.Size(515, 33);
            this.btnReadfrfile.TabIndex = 2;
            this.btnReadfrfile.Text = "Đọc dữ liệu từ tệp";
            this.btnReadfrfile.UseVisualStyleBackColor = true;
            this.btnReadfrfile.Click += new System.EventHandler(this.btnReadfrfile_Click);
            // 
            // tcInfo
            // 
            this.tcInfo.Controls.Add(this.page1);
            this.tcInfo.Controls.Add(this.page2);
            this.tcInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcInfo.Location = new System.Drawing.Point(0, 99);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.SelectedIndex = 0;
            this.tcInfo.Size = new System.Drawing.Size(515, 336);
            this.tcInfo.TabIndex = 101;
            this.tcInfo.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcInfo_Selected);
            // 
            // page1
            // 
            this.page1.Controls.Add(this.lvInfo);
            this.page1.Location = new System.Drawing.Point(4, 22);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(3);
            this.page1.Size = new System.Drawing.Size(507, 310);
            this.page1.TabIndex = 0;
            this.page1.Text = "Danh sách";
            this.page1.UseVisualStyleBackColor = true;
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNumber,
            this.colName,
            this.colID,
            this.colPhone,
            this.colScore1,
            this.colScore2,
            this.colScore3,
            this.colAvg});
            this.lvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.HoverSelection = true;
            listViewItem1.Checked = true;
            listViewItem1.IndentCount = 2;
            listViewItem1.StateImageIndex = 1;
            listViewItem2.StateImageIndex = 0;
            this.lvInfo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvInfo.Location = new System.Drawing.Point(3, 3);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.ShowGroups = false;
            this.lvInfo.Size = new System.Drawing.Size(501, 304);
            this.lvInfo.TabIndex = 99;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            this.lvInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvInfo_KeyDown);
            // 
            // colNumber
            // 
            this.colNumber.Text = "";
            this.colNumber.Width = 15;
            // 
            // colName
            // 
            this.colName.Text = "Họ và Tên";
            this.colName.Width = 120;
            // 
            // colID
            // 
            this.colID.Text = "MSSV";
            this.colID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colID.Width = 80;
            // 
            // colPhone
            // 
            this.colPhone.Text = "SĐT";
            this.colPhone.Width = 80;
            // 
            // colScore1
            // 
            this.colScore1.Text = "Môn 1";
            this.colScore1.Width = 50;
            // 
            // colScore2
            // 
            this.colScore2.Text = "Môn 2";
            this.colScore2.Width = 50;
            // 
            // colScore3
            // 
            this.colScore3.Text = "Môn 3";
            this.colScore3.Width = 50;
            // 
            // colAvg
            // 
            this.colAvg.Text = "TB";
            this.colAvg.Width = 40;
            // 
            // page2
            // 
            this.page2.Controls.Add(this.lbInfo);
            this.page2.Controls.Add(this.btnNext);
            this.page2.Controls.Add(this.btnBack);
            this.page2.Controls.Add(this.tbxAvg);
            this.page2.Controls.Add(this.lbAvg);
            this.page2.Controls.Add(this.tbxScore3);
            this.page2.Controls.Add(this.lbScore3);
            this.page2.Controls.Add(this.tbxScore2);
            this.page2.Controls.Add(this.lbScore2);
            this.page2.Controls.Add(this.tbxScore1);
            this.page2.Controls.Add(this.lbScore1);
            this.page2.Controls.Add(this.tbxPhone);
            this.page2.Controls.Add(this.lbPhone);
            this.page2.Controls.Add(this.tbxID);
            this.page2.Controls.Add(this.lbID);
            this.page2.Controls.Add(this.tbxName);
            this.page2.Controls.Add(this.lbName);
            this.page2.Location = new System.Drawing.Point(4, 22);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(3);
            this.page2.Size = new System.Drawing.Size(507, 310);
            this.page2.TabIndex = 1;
            this.page2.Text = "Bảng";
            this.page2.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Wingdings 3", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnNext.Location = new System.Drawing.Point(410, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(94, 304);
            this.btnNext.TabIndex = 113;
            this.btnNext.Text = "u";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Enabled = false;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 304);
            this.btnBack.TabIndex = 112;
            this.btnBack.Text = "v";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbxScore3
            // 
            this.tbxScore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScore3.Location = new System.Drawing.Point(211, 199);
            this.tbxScore3.Name = "tbxScore3";
            this.tbxScore3.ReadOnly = true;
            this.tbxScore3.Size = new System.Drawing.Size(130, 22);
            this.tbxScore3.TabIndex = 105;
            // 
            // lbScore3
            // 
            this.lbScore3.AutoSize = true;
            this.lbScore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore3.Location = new System.Drawing.Point(137, 202);
            this.lbScore3.Name = "lbScore3";
            this.lbScore3.Size = new System.Drawing.Size(47, 16);
            this.lbScore3.TabIndex = 106;
            this.lbScore3.Text = "Môn 3:";
            // 
            // tbxScore2
            // 
            this.tbxScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScore2.Location = new System.Drawing.Point(211, 171);
            this.tbxScore2.Name = "tbxScore2";
            this.tbxScore2.ReadOnly = true;
            this.tbxScore2.Size = new System.Drawing.Size(130, 22);
            this.tbxScore2.TabIndex = 104;
            // 
            // lbScore2
            // 
            this.lbScore2.AutoSize = true;
            this.lbScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore2.Location = new System.Drawing.Point(137, 174);
            this.lbScore2.Name = "lbScore2";
            this.lbScore2.Size = new System.Drawing.Size(47, 16);
            this.lbScore2.TabIndex = 107;
            this.lbScore2.Text = "Môn 2:";
            // 
            // tbxScore1
            // 
            this.tbxScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScore1.Location = new System.Drawing.Point(211, 143);
            this.tbxScore1.Name = "tbxScore1";
            this.tbxScore1.ReadOnly = true;
            this.tbxScore1.Size = new System.Drawing.Size(130, 22);
            this.tbxScore1.TabIndex = 103;
            // 
            // lbScore1
            // 
            this.lbScore1.AutoSize = true;
            this.lbScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore1.Location = new System.Drawing.Point(137, 146);
            this.lbScore1.Name = "lbScore1";
            this.lbScore1.Size = new System.Drawing.Size(47, 16);
            this.lbScore1.TabIndex = 108;
            this.lbScore1.Text = "Môn 1:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhone.Location = new System.Drawing.Point(211, 115);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.ReadOnly = true;
            this.tbxPhone.Size = new System.Drawing.Size(130, 22);
            this.tbxPhone.TabIndex = 102;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(137, 118);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(38, 16);
            this.lbPhone.TabIndex = 109;
            this.lbPhone.Text = "SĐT:";
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(211, 87);
            this.tbxID.Name = "tbxID";
            this.tbxID.ReadOnly = true;
            this.tbxID.Size = new System.Drawing.Size(130, 22);
            this.tbxID.TabIndex = 101;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(137, 90);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(49, 16);
            this.lbID.TabIndex = 110;
            this.lbID.Text = "MSSV:";
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(211, 59);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(130, 22);
            this.tbxName.TabIndex = 100;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(137, 62);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(68, 16);
            this.lbName.TabIndex = 111;
            this.lbName.Text = "Họ và tên:";
            // 
            // lbInfo
            // 
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(97, 3);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(313, 29);
            this.lbInfo.TabIndex = 114;
            this.lbInfo.Tag = "0";
            this.lbInfo.Text = "SINH VIÊN 0";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAvg
            // 
            this.lbAvg.AutoSize = true;
            this.lbAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvg.Location = new System.Drawing.Point(137, 230);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(63, 16);
            this.lbAvg.TabIndex = 106;
            this.lbAvg.Text = "Điểm TB:";
            // 
            // tbxAvg
            // 
            this.tbxAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAvg.Location = new System.Drawing.Point(211, 227);
            this.tbxAvg.Name = "tbxAvg";
            this.tbxAvg.ReadOnly = true;
            this.tbxAvg.Size = new System.Drawing.Size(130, 22);
            this.tbxAvg.TabIndex = 105;
            // 
            // FormWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.tcInfo);
            this.Controls.Add(this.btnReadfrfile);
            this.Controls.Add(this.btnAddtofile);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormWrite";
            this.Text = "FormWrite";
            this.Load += new System.EventHandler(this.FormWrite_Load);
            this.tcInfo.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddtofile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReadfrfile;
        private System.Windows.Forms.TabControl tcInfo;
        private System.Windows.Forms.TabPage page1;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colScore1;
        private System.Windows.Forms.ColumnHeader colScore2;
        private System.Windows.Forms.ColumnHeader colScore3;
        private System.Windows.Forms.ColumnHeader colAvg;
        private System.Windows.Forms.TabPage page2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbxScore3;
        private System.Windows.Forms.Label lbScore3;
        private System.Windows.Forms.TextBox tbxScore2;
        private System.Windows.Forms.Label lbScore2;
        private System.Windows.Forms.TextBox tbxScore1;
        private System.Windows.Forms.Label lbScore1;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbxAvg;
        private System.Windows.Forms.Label lbAvg;
    }
}