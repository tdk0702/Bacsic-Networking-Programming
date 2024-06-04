
namespace Theater.Server
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
            pRank = new Panel();
            lbxTheaters = new ListBox();
            lbTheaterList = new Label();
            lbxMovies = new ListBox();
            lbMovieList = new Label();
            lbxMovRank = new ListBox();
            lbxTheaRank = new ListBox();
            lbRank = new Label();
            cbxType = new ComboBox();
            dtpDate = new DateTimePicker();
            pHistory = new Panel();
            tbxHistory = new RichTextBox();
            lbHistory = new Label();
            panel1 = new Panel();
            tbxHost = new TextBox();
            label2 = new Label();
            label1 = new Label();
            nudClients = new NumericUpDown();
            lbCopyright = new Label();
            btnAddMovie = new Button();
            tbnAddTheater = new Button();
            btnListen = new Button();
            btnStop = new Button();
            btn_manage = new Button();
            pRank.SuspendLayout();
            pHistory.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudClients).BeginInit();
            SuspendLayout();
            // 
            // pRank
            // 
            pRank.Controls.Add(lbxTheaters);
            pRank.Controls.Add(lbTheaterList);
            pRank.Controls.Add(lbxMovies);
            pRank.Controls.Add(lbMovieList);
            pRank.Controls.Add(lbxMovRank);
            pRank.Controls.Add(lbxTheaRank);
            pRank.Controls.Add(lbRank);
            pRank.Controls.Add(cbxType);
            pRank.Controls.Add(dtpDate);
            pRank.Dock = DockStyle.Left;
            pRank.Location = new Point(6, 6);
            pRank.Margin = new Padding(4, 3, 4, 3);
            pRank.Name = "pRank";
            pRank.Padding = new Padding(6);
            pRank.Size = new Size(330, 437);
            pRank.TabIndex = 3;
            // 
            // lbxTheaters
            // 
            lbxTheaters.Dock = DockStyle.Top;
            lbxTheaters.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxTheaters.FormattingEnabled = true;
            lbxTheaters.HorizontalScrollbar = true;
            lbxTheaters.ItemHeight = 18;
            lbxTheaters.Items.AddRange(new object[] { "<Rạp 1> : <Số ghế thường>, <Ghế VIP>, <SweetBox>" });
            lbxTheaters.Location = new Point(6, 446);
            lbxTheaters.Margin = new Padding(4, 3, 4, 3);
            lbxTheaters.Name = "lbxTheaters";
            lbxTheaters.Size = new Size(318, 76);
            lbxTheaters.TabIndex = 19;
            // 
            // lbTheaterList
            // 
            lbTheaterList.AutoSize = true;
            lbTheaterList.Dock = DockStyle.Top;
            lbTheaterList.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTheaterList.Location = new Point(6, 428);
            lbTheaterList.Margin = new Padding(4, 0, 4, 0);
            lbTheaterList.Name = "lbTheaterList";
            lbTheaterList.Size = new Size(136, 18);
            lbTheaterList.TabIndex = 18;
            lbTheaterList.Text = "Danh sách các rạp:";
            // 
            // lbxMovies
            // 
            lbxMovies.Dock = DockStyle.Top;
            lbxMovies.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxMovies.FormattingEnabled = true;
            lbxMovies.HorizontalScrollbar = true;
            lbxMovies.ItemHeight = 18;
            lbxMovies.Items.AddRange(new object[] { "<Phim 1> : <Rạp 1>, <Rạp 2>" });
            lbxMovies.Location = new Point(6, 352);
            lbxMovies.Margin = new Padding(4, 3, 4, 3);
            lbxMovies.Name = "lbxMovies";
            lbxMovies.Size = new Size(318, 76);
            lbxMovies.TabIndex = 17;
            // 
            // lbMovieList
            // 
            lbMovieList.AutoSize = true;
            lbMovieList.Dock = DockStyle.Top;
            lbMovieList.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMovieList.Location = new Point(6, 334);
            lbMovieList.Margin = new Padding(4, 0, 4, 0);
            lbMovieList.Name = "lbMovieList";
            lbMovieList.Size = new Size(168, 18);
            lbMovieList.TabIndex = 16;
            lbMovieList.Text = "Danh sách các bộ phim:";
            // 
            // lbxMovRank
            // 
            lbxMovRank.Dock = DockStyle.Top;
            lbxMovRank.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxMovRank.FormattingEnabled = true;
            lbxMovRank.ItemHeight = 18;
            lbxMovRank.Items.AddRange(new object[] { "Phim 1 : 999k" });
            lbxMovRank.Location = new Point(6, 204);
            lbxMovRank.Margin = new Padding(4, 3, 4, 3);
            lbxMovRank.Name = "lbxMovRank";
            lbxMovRank.SelectionMode = SelectionMode.None;
            lbxMovRank.Size = new Size(318, 130);
            lbxMovRank.Sorted = true;
            lbxMovRank.TabIndex = 15;
            // 
            // lbxTheaRank
            // 
            lbxTheaRank.Dock = DockStyle.Top;
            lbxTheaRank.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxTheaRank.FormattingEnabled = true;
            lbxTheaRank.ItemHeight = 18;
            lbxTheaRank.Items.AddRange(new object[] { "Rạp 1 : 999k" });
            lbxTheaRank.Location = new Point(6, 74);
            lbxTheaRank.Margin = new Padding(4, 3, 4, 3);
            lbxTheaRank.Name = "lbxTheaRank";
            lbxTheaRank.SelectionMode = SelectionMode.None;
            lbxTheaRank.Size = new Size(318, 130);
            lbxTheaRank.Sorted = true;
            lbxTheaRank.TabIndex = 10;
            // 
            // lbRank
            // 
            lbRank.AutoSize = true;
            lbRank.Dock = DockStyle.Top;
            lbRank.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRank.Location = new Point(6, 56);
            lbRank.Margin = new Padding(4, 0, 4, 0);
            lbRank.Name = "lbRank";
            lbRank.Size = new Size(143, 18);
            lbRank.TabIndex = 9;
            lbRank.Text = "Xếp hạng doanh thu:";
            // 
            // cbxType
            // 
            cbxType.Dock = DockStyle.Top;
            cbxType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxType.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxType.FormattingEnabled = true;
            cbxType.Items.AddRange(new object[] { "Ngày", "Tháng", "Năm" });
            cbxType.Location = new Point(6, 30);
            cbxType.Margin = new Padding(4, 3, 4, 3);
            cbxType.Name = "cbxType";
            cbxType.Size = new Size(318, 26);
            cbxType.TabIndex = 8;
            cbxType.SelectedIndexChanged += cbxType_SelectedIndexChanged;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd/MM/yyyy";
            dtpDate.Dock = DockStyle.Top;
            dtpDate.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(6, 6);
            dtpDate.Margin = new Padding(4, 3, 4, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(318, 24);
            dtpDate.TabIndex = 5;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // pHistory
            // 
            pHistory.Controls.Add(tbxHistory);
            pHistory.Controls.Add(lbHistory);
            pHistory.Controls.Add(panel1);
            pHistory.Dock = DockStyle.Left;
            pHistory.Location = new Point(336, 6);
            pHistory.Margin = new Padding(4, 3, 4, 3);
            pHistory.Name = "pHistory";
            pHistory.Padding = new Padding(6);
            pHistory.Size = new Size(607, 437);
            pHistory.TabIndex = 4;
            // 
            // tbxHistory
            // 
            tbxHistory.Dock = DockStyle.Fill;
            tbxHistory.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxHistory.Location = new Point(6, 82);
            tbxHistory.Margin = new Padding(4, 3, 4, 3);
            tbxHistory.Name = "tbxHistory";
            tbxHistory.ReadOnly = true;
            tbxHistory.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            tbxHistory.Size = new Size(595, 349);
            tbxHistory.TabIndex = 16;
            tbxHistory.Text = "<History>";
            // 
            // lbHistory
            // 
            lbHistory.AutoSize = true;
            lbHistory.Dock = DockStyle.Top;
            lbHistory.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHistory.Location = new Point(6, 64);
            lbHistory.Margin = new Padding(4, 0, 4, 0);
            lbHistory.Name = "lbHistory";
            lbHistory.Size = new Size(120, 18);
            lbHistory.TabIndex = 15;
            lbHistory.Text = "Lịch sử hệ thống:";
            // 
            // panel1
            // 
            panel1.Controls.Add(tbxHost);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(6, 6);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6);
            panel1.Size = new Size(595, 58);
            panel1.TabIndex = 14;
            // 
            // tbxHost
            // 
            tbxHost.Dock = DockStyle.Top;
            tbxHost.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxHost.Location = new Point(6, 24);
            tbxHost.Margin = new Padding(4, 3, 4, 3);
            tbxHost.Name = "tbxHost";
            tbxHost.Size = new Size(583, 24);
            tbxHost.TabIndex = 12;
            tbxHost.Text = "127.0.0.1:8080";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 6);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 18);
            label2.TabIndex = 11;
            label2.Text = "Hostname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(943, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 10;
            label1.Text = "Số client:";
            // 
            // nudClients
            // 
            nudClients.Dock = DockStyle.Top;
            nudClients.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudClients.Location = new Point(943, 24);
            nudClients.Margin = new Padding(4, 3, 4, 3);
            nudClients.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudClients.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudClients.Name = "nudClients";
            nudClients.Size = new Size(111, 22);
            nudClients.TabIndex = 11;
            nudClients.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbCopyright
            // 
            lbCopyright.Dock = DockStyle.Bottom;
            lbCopyright.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCopyright.Location = new Point(943, 422);
            lbCopyright.Margin = new Padding(4, 0, 4, 0);
            lbCopyright.Name = "lbCopyright";
            lbCopyright.Size = new Size(111, 21);
            lbCopyright.TabIndex = 13;
            lbCopyright.Text = "Created by TDK";
            lbCopyright.TextAlign = ContentAlignment.BottomRight;
            // 
            // btnAddMovie
            // 
            btnAddMovie.AutoSize = true;
            btnAddMovie.Dock = DockStyle.Bottom;
            btnAddMovie.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddMovie.Location = new Point(943, 390);
            btnAddMovie.Margin = new Padding(4, 3, 4, 3);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(111, 32);
            btnAddMovie.TabIndex = 14;
            btnAddMovie.Text = "Thêm phim";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // tbnAddTheater
            // 
            tbnAddTheater.AutoSize = true;
            tbnAddTheater.Dock = DockStyle.Bottom;
            tbnAddTheater.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbnAddTheater.Location = new Point(943, 358);
            tbnAddTheater.Margin = new Padding(4, 3, 4, 3);
            tbnAddTheater.Name = "tbnAddTheater";
            tbnAddTheater.Size = new Size(111, 32);
            tbnAddTheater.TabIndex = 15;
            tbnAddTheater.Text = "Thêm rạp";
            tbnAddTheater.UseVisualStyleBackColor = true;
            tbnAddTheater.Click += tbnAddTheater_Click;
            // 
            // btnListen
            // 
            btnListen.AutoSize = true;
            btnListen.Dock = DockStyle.Top;
            btnListen.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListen.Location = new Point(943, 46);
            btnListen.Margin = new Padding(4, 3, 4, 3);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(111, 32);
            btnListen.TabIndex = 17;
            btnListen.Text = "Chạy Server";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // btnStop
            // 
            btnStop.AutoSize = true;
            btnStop.Dock = DockStyle.Top;
            btnStop.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStop.Location = new Point(943, 78);
            btnStop.Margin = new Padding(4, 3, 4, 3);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(111, 32);
            btnStop.TabIndex = 18;
            btnStop.Text = "Tắt server";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // btn_manage
            // 
            btn_manage.AutoSize = true;
            btn_manage.Dock = DockStyle.Top;
            btn_manage.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_manage.Location = new Point(943, 110);
            btn_manage.Margin = new Padding(4, 3, 4, 3);
            btn_manage.Name = "btn_manage";
            btn_manage.Size = new Size(111, 32);
            btn_manage.TabIndex = 19;
            btn_manage.Text = "Quản lí quầy";
            btn_manage.UseVisualStyleBackColor = true;
            btn_manage.Click += btn_manage_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 449);
            Controls.Add(btn_manage);
            Controls.Add(btnStop);
            Controls.Add(btnListen);
            Controls.Add(tbnAddTheater);
            Controls.Add(btnAddMovie);
            Controls.Add(lbCopyright);
            Controls.Add(nudClients);
            Controls.Add(label1);
            Controls.Add(pHistory);
            Controls.Add(pRank);
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Admin";
            Padding = new Padding(6);
            Text = "Server";
            Load += Admin_Load;
            KeyDown += Admin_KeyDown;
            pRank.ResumeLayout(false);
            pRank.PerformLayout();
            pHistory.ResumeLayout(false);
            pHistory.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel pRank;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ListBox lbxTheaRank;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Panel pHistory;
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
        private System.Windows.Forms.RichTextBox tbxHistory;
        private System.Windows.Forms.Label lbHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxHost;
        private System.Windows.Forms.Label label2;
        private Button btnListen;
        private Button btnStop;
        private Button btn_manage;
    }
}