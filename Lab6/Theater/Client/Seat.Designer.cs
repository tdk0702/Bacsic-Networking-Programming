
namespace Theater.Client
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
            components = new System.ComponentModel.Container();
            lbTitle = new Label();
            btnGo = new Button();
            tctrlMain = new TabControl();
            tab0 = new TabPage();
            llbLink = new LinkLabel();
            tbxMInfo = new TextBox();
            pbxMImage = new PictureBox();
            lbMNotice = new Label();
            lbMName = new Label();
            tab1 = new TabPage();
            pMainSeat = new Panel();
            panel2 = new Panel();
            lbRank = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnScreen = new Button();
            pLabel1 = new Panel();
            button2 = new Button();
            lbLeftLabel3 = new Label();
            button1 = new Button();
            lbLeftLabel2 = new Label();
            btnLeftLabel1 = new Button();
            lbLeftLabel1 = new Label();
            ttSeat = new ToolTip(components);
            tctrlMain.SuspendLayout();
            tab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMImage).BeginInit();
            tab1.SuspendLayout();
            pMainSeat.SuspendLayout();
            panel2.SuspendLayout();
            pLabel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Dock = DockStyle.Top;
            lbTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(0, 0);
            lbTitle.Margin = new Padding(4, 0, 4, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(1004, 45);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "DANH SÁCH RẠP PHIM";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGo
            // 
            btnGo.AutoSize = true;
            btnGo.Dock = DockStyle.Bottom;
            btnGo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGo.Location = new Point(0, 611);
            btnGo.Margin = new Padding(4, 3, 4, 3);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(1004, 42);
            btnGo.TabIndex = 2;
            btnGo.Text = "Đặt vé";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // tctrlMain
            // 
            tctrlMain.Controls.Add(tab0);
            tctrlMain.Controls.Add(tab1);
            tctrlMain.Dock = DockStyle.Fill;
            tctrlMain.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tctrlMain.Location = new Point(0, 45);
            tctrlMain.Margin = new Padding(4, 3, 4, 3);
            tctrlMain.Name = "tctrlMain";
            tctrlMain.SelectedIndex = 0;
            tctrlMain.Size = new Size(1004, 566);
            tctrlMain.SizeMode = TabSizeMode.Fixed;
            tctrlMain.TabIndex = 3;
            tctrlMain.Selected += tctrlMain_SelectedIndexChanged;
            // 
            // tab0
            // 
            tab0.Controls.Add(llbLink);
            tab0.Controls.Add(tbxMInfo);
            tab0.Controls.Add(pbxMImage);
            tab0.Controls.Add(lbMNotice);
            tab0.Controls.Add(lbMName);
            tab0.Location = new Point(4, 29);
            tab0.Margin = new Padding(4, 3, 4, 3);
            tab0.Name = "tab0";
            tab0.Padding = new Padding(12);
            tab0.Size = new Size(996, 533);
            tab0.TabIndex = 2;
            tab0.Text = "Thông tin";
            tab0.UseVisualStyleBackColor = true;
            // 
            // llbLink
            // 
            llbLink.AutoSize = true;
            llbLink.Dock = DockStyle.Bottom;
            llbLink.Location = new Point(12, 439);
            llbLink.Name = "llbLink";
            llbLink.Size = new Size(105, 20);
            llbLink.TabIndex = 7;
            llbLink.TabStop = true;
            llbLink.Text = "Mở trang web";
            llbLink.LinkClicked += llbLink_LinkClicked;
            // 
            // tbxMInfo
            // 
            tbxMInfo.BorderStyle = BorderStyle.None;
            tbxMInfo.Dock = DockStyle.Fill;
            tbxMInfo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMInfo.Location = new Point(12, 74);
            tbxMInfo.Margin = new Padding(4, 3, 4, 3);
            tbxMInfo.Multiline = true;
            tbxMInfo.Name = "tbxMInfo";
            tbxMInfo.ReadOnly = true;
            tbxMInfo.Size = new Size(599, 385);
            tbxMInfo.TabIndex = 6;
            tbxMInfo.Text = "<Nội dung>";
            // 
            // pbxMImage
            // 
            pbxMImage.Dock = DockStyle.Right;
            pbxMImage.Location = new Point(611, 74);
            pbxMImage.Margin = new Padding(4, 3, 4, 3);
            pbxMImage.Name = "pbxMImage";
            pbxMImage.Size = new Size(373, 385);
            pbxMImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMImage.TabIndex = 4;
            pbxMImage.TabStop = false;
            // 
            // lbMNotice
            // 
            lbMNotice.Dock = DockStyle.Bottom;
            lbMNotice.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMNotice.ForeColor = Color.Red;
            lbMNotice.Location = new Point(12, 459);
            lbMNotice.Margin = new Padding(4, 0, 4, 0);
            lbMNotice.Name = "lbMNotice";
            lbMNotice.Padding = new Padding(6);
            lbMNotice.Size = new Size(972, 62);
            lbMNotice.TabIndex = 3;
            lbMNotice.Text = "Vui lòng chọn rạp phim ở các tab tiếp theo và đặt vé";
            lbMNotice.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbMName
            // 
            lbMName.Dock = DockStyle.Top;
            lbMName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMName.Location = new Point(12, 12);
            lbMName.Margin = new Padding(4, 0, 4, 0);
            lbMName.Name = "lbMName";
            lbMName.Size = new Size(972, 62);
            lbMName.TabIndex = 2;
            lbMName.Text = "<Tên phim>";
            lbMName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tab1
            // 
            tab1.Controls.Add(pMainSeat);
            tab1.Controls.Add(btnScreen);
            tab1.Controls.Add(pLabel1);
            tab1.Location = new Point(4, 29);
            tab1.Margin = new Padding(4, 3, 4, 3);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(4, 3, 4, 3);
            tab1.Size = new Size(996, 533);
            tab1.TabIndex = 0;
            tab1.Text = "Rạp chiếu 1";
            tab1.UseVisualStyleBackColor = true;
            // 
            // pMainSeat
            // 
            pMainSeat.Controls.Add(panel2);
            pMainSeat.Controls.Add(tableLayoutPanel1);
            pMainSeat.Dock = DockStyle.Fill;
            pMainSeat.Location = new Point(114, 45);
            pMainSeat.Margin = new Padding(4, 3, 4, 3);
            pMainSeat.Name = "pMainSeat";
            pMainSeat.Size = new Size(878, 485);
            pMainSeat.TabIndex = 107;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbRank);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(257, 6, 6, 6);
            panel2.Size = new Size(878, 52);
            panel2.TabIndex = 103;
            panel2.Visible = false;
            // 
            // lbRank
            // 
            lbRank.Dock = DockStyle.Right;
            lbRank.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRank.Location = new Point(818, 6);
            lbRank.Margin = new Padding(4, 0, 4, 0);
            lbRank.Name = "lbRank";
            lbRank.RightToLeft = RightToLeft.No;
            lbRank.Size = new Size(54, 40);
            lbRank.TabIndex = 13;
            lbRank.Text = "A";
            lbRank.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button9
            // 
            button9.BackColor = Color.LightGray;
            button9.Dock = DockStyle.Left;
            button9.Location = new Point(503, 6);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(41, 40);
            button9.TabIndex = 12;
            button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGray;
            button8.Dock = DockStyle.Left;
            button8.Location = new Point(462, 6);
            button8.Margin = new Padding(4, 3, 4, 3);
            button8.Name = "button8";
            button8.Size = new Size(41, 40);
            button8.TabIndex = 11;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.Dock = DockStyle.Left;
            button7.Location = new Point(421, 6);
            button7.Margin = new Padding(4, 3, 4, 3);
            button7.Name = "button7";
            button7.Size = new Size(41, 40);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.Dock = DockStyle.Left;
            button6.Location = new Point(380, 6);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(41, 40);
            button6.TabIndex = 9;
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGray;
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(339, 6);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(41, 40);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(298, 6);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(41, 40);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(257, 6);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(41, 40);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 14;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142883F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142884F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142514F));
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(0, 485);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnScreen
            // 
            btnScreen.AutoSize = true;
            btnScreen.Dock = DockStyle.Top;
            btnScreen.FlatStyle = FlatStyle.Flat;
            btnScreen.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScreen.Location = new Point(114, 3);
            btnScreen.Margin = new Padding(4, 3, 4, 3);
            btnScreen.Name = "btnScreen";
            btnScreen.Size = new Size(878, 42);
            btnScreen.TabIndex = 104;
            btnScreen.Text = "MÀN HÌNH CHIẾU PHIM";
            btnScreen.UseVisualStyleBackColor = true;
            // 
            // pLabel1
            // 
            pLabel1.Controls.Add(button2);
            pLabel1.Controls.Add(lbLeftLabel3);
            pLabel1.Controls.Add(button1);
            pLabel1.Controls.Add(lbLeftLabel2);
            pLabel1.Controls.Add(btnLeftLabel1);
            pLabel1.Controls.Add(lbLeftLabel1);
            pLabel1.Dock = DockStyle.Left;
            pLabel1.Location = new Point(4, 3);
            pLabel1.Margin = new Padding(175, 3, 93, 3);
            pLabel1.Name = "pLabel1";
            pLabel1.Padding = new Padding(6);
            pLabel1.Size = new Size(110, 527);
            pLabel1.TabIndex = 101;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(6, 124);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(98, 35);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            // 
            // lbLeftLabel3
            // 
            lbLeftLabel3.AutoSize = true;
            lbLeftLabel3.Dock = DockStyle.Top;
            lbLeftLabel3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLeftLabel3.Location = new Point(6, 108);
            lbLeftLabel3.Margin = new Padding(4, 0, 4, 0);
            lbLeftLabel3.Name = "lbLeftLabel3";
            lbLeftLabel3.Size = new Size(73, 16);
            lbLeftLabel3.TabIndex = 11;
            lbLeftLabel3.Text = "Sweet Box:";
            lbLeftLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(6, 73);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 10;
            button1.UseVisualStyleBackColor = false;
            // 
            // lbLeftLabel2
            // 
            lbLeftLabel2.AutoSize = true;
            lbLeftLabel2.Dock = DockStyle.Top;
            lbLeftLabel2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLeftLabel2.Location = new Point(6, 57);
            lbLeftLabel2.Margin = new Padding(4, 0, 4, 0);
            lbLeftLabel2.Name = "lbLeftLabel2";
            lbLeftLabel2.Size = new Size(59, 16);
            lbLeftLabel2.TabIndex = 6;
            lbLeftLabel2.Text = "Ghế VIP:";
            lbLeftLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLeftLabel1
            // 
            btnLeftLabel1.BackColor = Color.LightGray;
            btnLeftLabel1.Dock = DockStyle.Top;
            btnLeftLabel1.Location = new Point(6, 22);
            btnLeftLabel1.Margin = new Padding(4, 3, 4, 3);
            btnLeftLabel1.Name = "btnLeftLabel1";
            btnLeftLabel1.Size = new Size(98, 35);
            btnLeftLabel1.TabIndex = 5;
            btnLeftLabel1.UseVisualStyleBackColor = false;
            // 
            // lbLeftLabel1
            // 
            lbLeftLabel1.AutoSize = true;
            lbLeftLabel1.Dock = DockStyle.Top;
            lbLeftLabel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLeftLabel1.Location = new Point(6, 6);
            lbLeftLabel1.Margin = new Padding(4, 0, 4, 0);
            lbLeftLabel1.Name = "lbLeftLabel1";
            lbLeftLabel1.Size = new Size(78, 16);
            lbLeftLabel1.TabIndex = 0;
            lbLeftLabel1.Text = "Ghế thường:";
            lbLeftLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ttSeat
            // 
            ttSeat.AutoPopDelay = 4000;
            ttSeat.InitialDelay = 300;
            ttSeat.ReshowDelay = 100;
            // 
            // Seat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 653);
            Controls.Add(tctrlMain);
            Controls.Add(btnGo);
            Controls.Add(lbTitle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Seat";
            Text = "ChooseTicket";
            Load += ChooseTicket_Load;
            tctrlMain.ResumeLayout(false);
            tab0.ResumeLayout(false);
            tab0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxMImage).EndInit();
            tab1.ResumeLayout(false);
            tab1.PerformLayout();
            pMainSeat.ResumeLayout(false);
            pMainSeat.PerformLayout();
            panel2.ResumeLayout(false);
            pLabel1.ResumeLayout(false);
            pLabel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolTip ttSeat;
        private LinkLabel llbLink;
        private Label lbMNotice;
    }
}