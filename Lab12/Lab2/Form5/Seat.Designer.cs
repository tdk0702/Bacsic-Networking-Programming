
namespace Lab2.Form5
{
    partial class Seat
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.tctrlMain = new System.Windows.Forms.TabControl();
            this.tab0 = new System.Windows.Forms.TabPage();
            this.tbxMInfo = new System.Windows.Forms.TextBox();
            this.pbxMImage = new System.Windows.Forms.PictureBox();
            this.lbMNotice = new System.Windows.Forms.Label();
            this.lbMName = new System.Windows.Forms.Label();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.pMainSeat = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbRank = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnScreen = new System.Windows.Forms.Button();
            this.pLabel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbLeftLabel3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLeftLabel2 = new System.Windows.Forms.Label();
            this.btnLeftLabel1 = new System.Windows.Forms.Button();
            this.lbLeftLabel1 = new System.Windows.Forms.Label();
            this.tctrlMain.SuspendLayout();
            this.tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMImage)).BeginInit();
            this.tab1.SuspendLayout();
            this.pMainSeat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pLabel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(861, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "DANH SÁCH RẠP PHIM";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGo
            // 
            this.btnGo.AutoSize = true;
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(0, 530);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(861, 36);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Đặt vé";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tctrlMain
            // 
            this.tctrlMain.Controls.Add(this.tab0);
            this.tctrlMain.Controls.Add(this.tab1);
            this.tctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctrlMain.Location = new System.Drawing.Point(0, 39);
            this.tctrlMain.Name = "tctrlMain";
            this.tctrlMain.SelectedIndex = 0;
            this.tctrlMain.Size = new System.Drawing.Size(861, 491);
            this.tctrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctrlMain.TabIndex = 3;
            this.tctrlMain.Selected += new System.Windows.Forms.TabControlEventHandler(this.tctrlMain_SelectedIndexChanged);
            // 
            // tab0
            // 
            this.tab0.Controls.Add(this.tbxMInfo);
            this.tab0.Controls.Add(this.pbxMImage);
            this.tab0.Controls.Add(this.lbMNotice);
            this.tab0.Controls.Add(this.lbMName);
            this.tab0.Location = new System.Drawing.Point(4, 29);
            this.tab0.Name = "tab0";
            this.tab0.Padding = new System.Windows.Forms.Padding(10);
            this.tab0.Size = new System.Drawing.Size(853, 458);
            this.tab0.TabIndex = 2;
            this.tab0.Text = "Thông tin";
            this.tab0.UseVisualStyleBackColor = true;
            // 
            // tbxMInfo
            // 
            this.tbxMInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMInfo.Location = new System.Drawing.Point(10, 64);
            this.tbxMInfo.Multiline = true;
            this.tbxMInfo.Name = "tbxMInfo";
            this.tbxMInfo.ReadOnly = true;
            this.tbxMInfo.Size = new System.Drawing.Size(513, 330);
            this.tbxMInfo.TabIndex = 6;
            this.tbxMInfo.Text = "<Nội dung>";
            // 
            // pbxMImage
            // 
            this.pbxMImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbxMImage.Image = global::Lab2.Properties.Resources.movie_image_sample;
            this.pbxMImage.Location = new System.Drawing.Point(523, 64);
            this.pbxMImage.Name = "pbxMImage";
            this.pbxMImage.Size = new System.Drawing.Size(320, 330);
            this.pbxMImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMImage.TabIndex = 4;
            this.pbxMImage.TabStop = false;
            // 
            // lbMNotice
            // 
            this.lbMNotice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMNotice.ForeColor = System.Drawing.Color.Red;
            this.lbMNotice.Location = new System.Drawing.Point(10, 394);
            this.lbMNotice.Name = "lbMNotice";
            this.lbMNotice.Padding = new System.Windows.Forms.Padding(5);
            this.lbMNotice.Size = new System.Drawing.Size(833, 54);
            this.lbMNotice.TabIndex = 3;
            this.lbMNotice.Text = "Vui lòng chọn rạp phim ở các tab tiếp theo và đặt vé";
            this.lbMNotice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbMName
            // 
            this.lbMName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMName.Location = new System.Drawing.Point(10, 10);
            this.lbMName.Name = "lbMName";
            this.lbMName.Size = new System.Drawing.Size(833, 54);
            this.lbMName.TabIndex = 2;
            this.lbMName.Text = "<Tên phim>";
            this.lbMName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.pMainSeat);
            this.tab1.Controls.Add(this.btnScreen);
            this.tab1.Controls.Add(this.pLabel1);
            this.tab1.Location = new System.Drawing.Point(4, 29);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(853, 458);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Rạp chiếu 1";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // pMainSeat
            // 
            this.pMainSeat.Controls.Add(this.panel2);
            this.pMainSeat.Controls.Add(this.tableLayoutPanel1);
            this.pMainSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainSeat.Location = new System.Drawing.Point(97, 39);
            this.pMainSeat.Name = "pMainSeat";
            this.pMainSeat.Size = new System.Drawing.Size(753, 416);
            this.pMainSeat.TabIndex = 107;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbRank);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(220, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(753, 45);
            this.panel2.TabIndex = 103;
            this.panel2.Visible = false;
            // 
            // lbRank
            // 
            this.lbRank.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.Location = new System.Drawing.Point(702, 5);
            this.lbRank.Name = "lbRank";
            this.lbRank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRank.Size = new System.Drawing.Size(46, 35);
            this.lbRank.TabIndex = 13;
            this.lbRank.Text = "A";
            this.lbRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGray;
            this.button9.Dock = System.Windows.Forms.DockStyle.Left;
            this.button9.Location = new System.Drawing.Point(430, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(35, 35);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightGray;
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.Location = new System.Drawing.Point(395, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(35, 35);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightGray;
            this.button7.Dock = System.Windows.Forms.DockStyle.Left;
            this.button7.Location = new System.Drawing.Point(360, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.Dock = System.Windows.Forms.DockStyle.Left;
            this.button6.Location = new System.Drawing.Point(325, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.Location = new System.Drawing.Point(290, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(255, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(220, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 14;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142884F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.142514F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnScreen
            // 
            this.btnScreen.AutoSize = true;
            this.btnScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreen.Location = new System.Drawing.Point(97, 3);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(753, 36);
            this.btnScreen.TabIndex = 104;
            this.btnScreen.Text = "MÀN HÌNH CHIẾU PHIM";
            this.btnScreen.UseVisualStyleBackColor = true;
            // 
            // pLabel1
            // 
            this.pLabel1.Controls.Add(this.button2);
            this.pLabel1.Controls.Add(this.lbLeftLabel3);
            this.pLabel1.Controls.Add(this.button1);
            this.pLabel1.Controls.Add(this.lbLeftLabel2);
            this.pLabel1.Controls.Add(this.btnLeftLabel1);
            this.pLabel1.Controls.Add(this.lbLeftLabel1);
            this.pLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLabel1.Location = new System.Drawing.Point(3, 3);
            this.pLabel1.Margin = new System.Windows.Forms.Padding(150, 3, 80, 3);
            this.pLabel1.Name = "pLabel1";
            this.pLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.pLabel1.Size = new System.Drawing.Size(94, 452);
            this.pLabel1.TabIndex = 101;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(5, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbLeftLabel3
            // 
            this.lbLeftLabel3.AutoSize = true;
            this.lbLeftLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLeftLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftLabel3.Location = new System.Drawing.Point(5, 97);
            this.lbLeftLabel3.Name = "lbLeftLabel3";
            this.lbLeftLabel3.Size = new System.Drawing.Size(74, 16);
            this.lbLeftLabel3.TabIndex = 11;
            this.lbLeftLabel3.Text = "Sweet Box:";
            this.lbLeftLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(5, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbLeftLabel2
            // 
            this.lbLeftLabel2.AutoSize = true;
            this.lbLeftLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLeftLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftLabel2.Location = new System.Drawing.Point(5, 51);
            this.lbLeftLabel2.Name = "lbLeftLabel2";
            this.lbLeftLabel2.Size = new System.Drawing.Size(60, 16);
            this.lbLeftLabel2.TabIndex = 6;
            this.lbLeftLabel2.Text = "Ghế VIP:";
            this.lbLeftLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLeftLabel1
            // 
            this.btnLeftLabel1.BackColor = System.Drawing.Color.LightGray;
            this.btnLeftLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLeftLabel1.Location = new System.Drawing.Point(5, 21);
            this.btnLeftLabel1.Name = "btnLeftLabel1";
            this.btnLeftLabel1.Size = new System.Drawing.Size(84, 30);
            this.btnLeftLabel1.TabIndex = 5;
            this.btnLeftLabel1.UseVisualStyleBackColor = false;
            // 
            // lbLeftLabel1
            // 
            this.lbLeftLabel1.AutoSize = true;
            this.lbLeftLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLeftLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeftLabel1.Location = new System.Drawing.Point(5, 5);
            this.lbLeftLabel1.Name = "lbLeftLabel1";
            this.lbLeftLabel1.Size = new System.Drawing.Size(79, 16);
            this.lbLeftLabel1.TabIndex = 0;
            this.lbLeftLabel1.Text = "Ghế thường:";
            this.lbLeftLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 566);
            this.Controls.Add(this.tctrlMain);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lbTitle);
            this.Name = "Seat";
            this.Text = "ChooseTicket";
            this.Load += new System.EventHandler(this.ChooseTicket_Load);
            this.tctrlMain.ResumeLayout(false);
            this.tab0.ResumeLayout(false);
            this.tab0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMImage)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.pMainSeat.ResumeLayout(false);
            this.pMainSeat.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pLabel1.ResumeLayout(false);
            this.pLabel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TabControl tctrlMain;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Panel pLabel1;
        private System.Windows.Forms.Label lbLeftLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbLeftLabel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbLeftLabel2;
        private System.Windows.Forms.Button btnLeftLabel1;
        private System.Windows.Forms.TabPage tab0;
        private System.Windows.Forms.Label lbMNotice;
        private System.Windows.Forms.Label lbMName;
        private System.Windows.Forms.TextBox tbxMInfo;
        private System.Windows.Forms.PictureBox pbxMImage;
        private System.Windows.Forms.Panel pMainSeat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnScreen;
    }
}