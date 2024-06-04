
namespace Theater.Client
{
    partial class Bill
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
            "",
            "Ghế thường",
            "70",
            "2",
            "140"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.lbName = new System.Windows.Forms.Label();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbxTheater = new System.Windows.Forms.TextBox();
            this.lbTheater = new System.Windows.Forms.Label();
            this.tbxSeat = new System.Windows.Forms.TextBox();
            this.lbSeat = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTicInfo = new System.Windows.Forms.Label();
            this.lvPrice = new System.Windows.Forms.ListView();
            this.head0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.head1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.head2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.head3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.head4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(306, 47);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "<Tên phim>";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDate
            // 
            this.tbxDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDate.Location = new System.Drawing.Point(5, 77);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.ReadOnly = true;
            this.tbxDate.Size = new System.Drawing.Size(306, 31);
            this.tbxDate.TabIndex = 3;
            this.tbxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(5, 52);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(132, 25);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngày chiếu: ";
            // 
            // tbxTheater
            // 
            this.tbxTheater.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTheater.Location = new System.Drawing.Point(5, 133);
            this.tbxTheater.Name = "tbxTheater";
            this.tbxTheater.ReadOnly = true;
            this.tbxTheater.Size = new System.Drawing.Size(306, 31);
            this.tbxTheater.TabIndex = 5;
            this.tbxTheater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTheater
            // 
            this.lbTheater.AutoSize = true;
            this.lbTheater.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheater.Location = new System.Drawing.Point(5, 108);
            this.lbTheater.Name = "lbTheater";
            this.lbTheater.Size = new System.Drawing.Size(115, 25);
            this.lbTheater.TabIndex = 4;
            this.lbTheater.Text = "Rạp chiếu:";
            // 
            // tbxSeat
            // 
            this.tbxSeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSeat.Location = new System.Drawing.Point(5, 189);
            this.tbxSeat.Name = "tbxSeat";
            this.tbxSeat.ReadOnly = true;
            this.tbxSeat.Size = new System.Drawing.Size(306, 31);
            this.tbxSeat.TabIndex = 7;
            this.tbxSeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeat.Location = new System.Drawing.Point(5, 164);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(111, 25);
            this.lbSeat.TabIndex = 6;
            this.lbSeat.Text = "Hàng ghế:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(5, 245);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.ReadOnly = true;
            this.tbxPrice.Size = new System.Drawing.Size(306, 31);
            this.tbxPrice.TabIndex = 9;
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(5, 220);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(80, 25);
            this.lbPrice.TabIndex = 8;
            this.lbPrice.Text = "Giá vé:";
            // 
            // lbTicInfo
            // 
            this.lbTicInfo.AutoSize = true;
            this.lbTicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicInfo.Location = new System.Drawing.Point(5, 276);
            this.lbTicInfo.Name = "lbTicInfo";
            this.lbTicInfo.Size = new System.Drawing.Size(137, 25);
            this.lbTicInfo.TabIndex = 11;
            this.lbTicInfo.Text = "Thông tin vé:";
            // 
            // lvPrice
            // 
            this.lvPrice.AutoArrange = false;
            this.lvPrice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.head0,
            this.head1,
            this.head2,
            this.head3,
            this.head4});
            this.lvPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvPrice.FullRowSelect = true;
            this.lvPrice.GridLines = true;
            this.lvPrice.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPrice.HideSelection = false;
            this.lvPrice.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvPrice.Location = new System.Drawing.Point(5, 301);
            this.lvPrice.Name = "lvPrice";
            this.lvPrice.Scrollable = false;
            this.lvPrice.Size = new System.Drawing.Size(306, 119);
            this.lvPrice.TabIndex = 12;
            this.lvPrice.UseCompatibleStateImageBehavior = false;
            this.lvPrice.View = System.Windows.Forms.View.Details;
            // 
            // head0
            // 
            this.head0.DisplayIndex = 4;
            this.head0.Text = "";
            // 
            // head1
            // 
            this.head1.DisplayIndex = 0;
            this.head1.Text = "Loại vé";
            this.head1.Width = 81;
            // 
            // head2
            // 
            this.head2.DisplayIndex = 1;
            this.head2.Text = "Đơn giá";
            this.head2.Width = 49;
            // 
            // head3
            // 
            this.head3.DisplayIndex = 2;
            this.head3.Text = "Số lượng";
            this.head3.Width = 58;
            // 
            // head4
            // 
            this.head4.DisplayIndex = 3;
            this.head4.Text = "Thành tiền";
            this.head4.Width = 74;
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(5, 420);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(306, 39);
            this.btnAccept.TabIndex = 13;
            this.btnAccept.Text = "XÁC NHẬN";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 465);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lvPrice);
            this.Controls.Add(this.lbTicInfo);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.tbxSeat);
            this.Controls.Add(this.lbSeat);
            this.Controls.Add(this.tbxTheater);
            this.Controls.Add(this.lbTheater);
            this.Controls.Add(this.tbxDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbName);
            this.KeyPreview = true;
            this.Name = "Bill";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bill_FormClosing);
            this.Load += new System.EventHandler(this.Bill_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bill_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbxTheater;
        private System.Windows.Forms.Label lbTheater;
        private System.Windows.Forms.TextBox tbxSeat;
        private System.Windows.Forms.Label lbSeat;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTicInfo;
        private System.Windows.Forms.ListView lvPrice;
        private System.Windows.Forms.ColumnHeader head0;
        private System.Windows.Forms.ColumnHeader head1;
        private System.Windows.Forms.ColumnHeader head2;
        private System.Windows.Forms.ColumnHeader head3;
        private System.Windows.Forms.ColumnHeader head4;
        private System.Windows.Forms.Button btnAccept;
    }
}