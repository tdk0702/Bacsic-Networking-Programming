
namespace Lab3.Theater
{
    partial class Admin
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
            this.pRank = new System.Windows.Forms.Panel();
            this.lbxTheaters = new System.Windows.Forms.ListBox();
            this.lbTheaterList = new System.Windows.Forms.Label();
            this.lbxMovies = new System.Windows.Forms.ListBox();
            this.lbMovieList = new System.Windows.Forms.Label();
            this.lbxMovRank = new System.Windows.Forms.ListBox();
            this.lbxTheaRank = new System.Windows.Forms.ListBox();
            this.lbRank = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.pHistory = new System.Windows.Forms.Panel();
            this.tbxHistory = new System.Windows.Forms.RichTextBox();
            this.lbHistory = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudClients = new System.Windows.Forms.NumericUpDown();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.tbnAddTheater = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.pRank.SuspendLayout();
            this.pHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClients)).BeginInit();
            this.SuspendLayout();
            // 
            // pRank
            // 
            this.pRank.Controls.Add(this.lbxTheaters);
            this.pRank.Controls.Add(this.lbTheaterList);
            this.pRank.Controls.Add(this.lbxMovies);
            this.pRank.Controls.Add(this.lbMovieList);
            this.pRank.Controls.Add(this.lbxMovRank);
            this.pRank.Controls.Add(this.lbxTheaRank);
            this.pRank.Controls.Add(this.lbRank);
            this.pRank.Controls.Add(this.cbxType);
            this.pRank.Controls.Add(this.dtpDate);
            this.pRank.Dock = System.Windows.Forms.DockStyle.Left;
            this.pRank.Location = new System.Drawing.Point(5, 5);
            this.pRank.Name = "pRank";
            this.pRank.Padding = new System.Windows.Forms.Padding(5);
            this.pRank.Size = new System.Drawing.Size(283, 562);
            this.pRank.TabIndex = 3;
            // 
            // lbxTheaters
            // 
            this.lbxTheaters.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxTheaters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTheaters.FormattingEnabled = true;
            this.lbxTheaters.HorizontalScrollbar = true;
            this.lbxTheaters.ItemHeight = 18;
            this.lbxTheaters.Items.AddRange(new object[] {
            "<Rạp 1> : <Số ghế thường>, <Ghế VIP>, <SweetBox>"});
            this.lbxTheaters.Location = new System.Drawing.Point(5, 463);
            this.lbxTheaters.Name = "lbxTheaters";
            this.lbxTheaters.Size = new System.Drawing.Size(273, 94);
            this.lbxTheaters.TabIndex = 19;
            // 
            // lbTheaterList
            // 
            this.lbTheaterList.AutoSize = true;
            this.lbTheaterList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTheaterList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterList.Location = new System.Drawing.Point(5, 445);
            this.lbTheaterList.Name = "lbTheaterList";
            this.lbTheaterList.Size = new System.Drawing.Size(136, 18);
            this.lbTheaterList.TabIndex = 18;
            this.lbTheaterList.Text = "Danh sách các rạp:";
            // 
            // lbxMovies
            // 
            this.lbxMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMovies.FormattingEnabled = true;
            this.lbxMovies.HorizontalScrollbar = true;
            this.lbxMovies.ItemHeight = 18;
            this.lbxMovies.Items.AddRange(new object[] {
            "<Phim 1> : <Rạp 1>, <Rạp 2>"});
            this.lbxMovies.Location = new System.Drawing.Point(5, 351);
            this.lbxMovies.Name = "lbxMovies";
            this.lbxMovies.Size = new System.Drawing.Size(273, 94);
            this.lbxMovies.TabIndex = 17;
            // 
            // lbMovieList
            // 
            this.lbMovieList.AutoSize = true;
            this.lbMovieList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMovieList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovieList.Location = new System.Drawing.Point(5, 333);
            this.lbMovieList.Name = "lbMovieList";
            this.lbMovieList.Size = new System.Drawing.Size(168, 18);
            this.lbMovieList.TabIndex = 16;
            this.lbMovieList.Text = "Danh sách các bộ phim:";
            // 
            // lbxMovRank
            // 
            this.lbxMovRank.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxMovRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxMovRank.FormattingEnabled = true;
            this.lbxMovRank.ItemHeight = 18;
            this.lbxMovRank.Items.AddRange(new object[] {
            "Phim 1 : 999k"});
            this.lbxMovRank.Location = new System.Drawing.Point(5, 203);
            this.lbxMovRank.Name = "lbxMovRank";
            this.lbxMovRank.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxMovRank.Size = new System.Drawing.Size(273, 130);
            this.lbxMovRank.Sorted = true;
            this.lbxMovRank.TabIndex = 15;
            // 
            // lbxTheaRank
            // 
            this.lbxTheaRank.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxTheaRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxTheaRank.FormattingEnabled = true;
            this.lbxTheaRank.ItemHeight = 18;
            this.lbxTheaRank.Items.AddRange(new object[] {
            "Rạp 1 : 999k"});
            this.lbxTheaRank.Location = new System.Drawing.Point(5, 73);
            this.lbxTheaRank.Name = "lbxTheaRank";
            this.lbxTheaRank.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxTheaRank.Size = new System.Drawing.Size(273, 130);
            this.lbxTheaRank.Sorted = true;
            this.lbxTheaRank.TabIndex = 10;
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.Location = new System.Drawing.Point(5, 55);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(143, 18);
            this.lbRank.TabIndex = 9;
            this.lbRank.Text = "Xếp hạng doanh thu:";
            // 
            // cbxType
            // 
            this.cbxType.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbxType.Location = new System.Drawing.Point(5, 29);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(273, 26);
            this.cbxType.TabIndex = 8;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(5, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(273, 24);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // pHistory
            // 
            this.pHistory.Controls.Add(this.tbxHistory);
            this.pHistory.Controls.Add(this.lbHistory);
            this.pHistory.Controls.Add(this.panel1);
            this.pHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.pHistory.Location = new System.Drawing.Point(288, 5);
            this.pHistory.Name = "pHistory";
            this.pHistory.Padding = new System.Windows.Forms.Padding(5);
            this.pHistory.Size = new System.Drawing.Size(520, 562);
            this.pHistory.TabIndex = 4;
            // 
            // tbxHistory
            // 
            this.tbxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHistory.Location = new System.Drawing.Point(5, 73);
            this.tbxHistory.Name = "tbxHistory";
            this.tbxHistory.ReadOnly = true;
            this.tbxHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tbxHistory.Size = new System.Drawing.Size(510, 484);
            this.tbxHistory.TabIndex = 16;
            this.tbxHistory.Text = "<History>";
            // 
            // lbHistory
            // 
            this.lbHistory.AutoSize = true;
            this.lbHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistory.Location = new System.Drawing.Point(5, 55);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(120, 18);
            this.lbHistory.TabIndex = 15;
            this.lbHistory.Text = "Lịch sử hệ thống:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxHost);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(510, 50);
            this.panel1.TabIndex = 14;
            // 
            // tbxHost
            // 
            this.tbxHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHost.Location = new System.Drawing.Point(5, 23);
            this.tbxHost.Name = "tbxHost";
            this.tbxHost.Size = new System.Drawing.Size(500, 24);
            this.tbxHost.TabIndex = 12;
            this.tbxHost.Text = "127.0.0.1:8080";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hostname:";
            // 
            // btnListen
            // 
            this.btnListen.AutoSize = true;
            this.btnListen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(808, 5);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(97, 28);
            this.btnListen.TabIndex = 5;
            this.btnListen.Text = "Chạy Server";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(808, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số client:";
            // 
            // nudClients
            // 
            this.nudClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudClients.Location = new System.Drawing.Point(808, 51);
            this.nudClients.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudClients.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClients.Name = "nudClients";
            this.nudClients.Size = new System.Drawing.Size(97, 22);
            this.nudClients.TabIndex = 11;
            this.nudClients.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbCopyright
            // 
            this.lbCopyright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopyright.Location = new System.Drawing.Point(808, 549);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(97, 18);
            this.lbCopyright.TabIndex = 13;
            this.lbCopyright.Text = "Created by TDK";
            this.lbCopyright.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.AutoSize = true;
            this.btnAddMovie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(808, 521);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(97, 28);
            this.btnAddMovie.TabIndex = 14;
            this.btnAddMovie.Text = "Thêm phim";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // tbnAddTheater
            // 
            this.tbnAddTheater.AutoSize = true;
            this.tbnAddTheater.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbnAddTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnAddTheater.Location = new System.Drawing.Point(808, 493);
            this.tbnAddTheater.Name = "tbnAddTheater";
            this.tbnAddTheater.Size = new System.Drawing.Size(97, 28);
            this.tbnAddTheater.TabIndex = 15;
            this.tbnAddTheater.Text = "Thêm rạp";
            this.tbnAddTheater.UseVisualStyleBackColor = true;
            this.tbnAddTheater.Click += new System.EventHandler(this.tbnAddTheater_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(808, 73);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 28);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Tắt server";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 572);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.tbnAddTheater);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.nudClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.pHistory);
            this.Controls.Add(this.pRank);
            this.KeyPreview = true;
            this.Name = "Admin";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Admin_KeyDown);
            this.pRank.ResumeLayout(false);
            this.pRank.PerformLayout();
            this.pHistory.ResumeLayout(false);
            this.pHistory.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pRank;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListBox lbxTheaRank;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Panel pHistory;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudClients;
        private System.Windows.Forms.ListBox lbxTheaters;
        private System.Windows.Forms.Label lbTheaterList;
        private System.Windows.Forms.ListBox lbxMovies;
        private System.Windows.Forms.Label lbMovieList;
        private System.Windows.Forms.ListBox lbxMovRank;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button tbnAddTheater;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox tbxHistory;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label label2;
    }
}