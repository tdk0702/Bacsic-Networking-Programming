
namespace Lab3.Theater
{
    partial class Home
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
            this.lptableHome = new System.Windows.Forms.TableLayoutPanel();
            this.gbxMovie4 = new System.Windows.Forms.GroupBox();
            this.lbMovie4 = new System.Windows.Forms.Label();
            this.btnGo4 = new System.Windows.Forms.Button();
            this.gbxMovie1 = new System.Windows.Forms.GroupBox();
            this.lbMovie1 = new System.Windows.Forms.Label();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.gbxMovie2 = new System.Windows.Forms.GroupBox();
            this.lbMovie2 = new System.Windows.Forms.Label();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.gbxMovie3 = new System.Windows.Forms.GroupBox();
            this.lbMovie3 = new System.Windows.Forms.Label();
            this.btnGo3 = new System.Windows.Forms.Button();
            this.pgbMovie = new System.Windows.Forms.ProgressBar();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lptableHome.SuspendLayout();
            this.gbxMovie4.SuspendLayout();
            this.gbxMovie1.SuspendLayout();
            this.gbxMovie2.SuspendLayout();
            this.gbxMovie3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lptableHome
            // 
            this.lptableHome.ColumnCount = 1;
            this.lptableHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lptableHome.Controls.Add(this.gbxMovie4, 0, 3);
            this.lptableHome.Controls.Add(this.gbxMovie1, 0, 0);
            this.lptableHome.Controls.Add(this.gbxMovie2, 0, 1);
            this.lptableHome.Controls.Add(this.gbxMovie3, 0, 2);
            this.lptableHome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lptableHome.Location = new System.Drawing.Point(0, 119);
            this.lptableHome.Name = "lptableHome";
            this.lptableHome.RowCount = 4;
            this.lptableHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lptableHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lptableHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lptableHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.lptableHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lptableHome.Size = new System.Drawing.Size(471, 370);
            this.lptableHome.TabIndex = 100;
            // 
            // gbxMovie4
            // 
            this.gbxMovie4.Controls.Add(this.lbMovie4);
            this.gbxMovie4.Controls.Add(this.btnGo4);
            this.gbxMovie4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMovie4.Location = new System.Drawing.Point(3, 279);
            this.gbxMovie4.Name = "gbxMovie4";
            this.gbxMovie4.Size = new System.Drawing.Size(465, 86);
            this.gbxMovie4.TabIndex = 3;
            this.gbxMovie4.TabStop = false;
            this.gbxMovie4.Text = "Tarot";
            // 
            // lbMovie4
            // 
            this.lbMovie4.AutoSize = true;
            this.lbMovie4.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMovie4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovie4.Location = new System.Drawing.Point(3, 25);
            this.lbMovie4.Name = "lbMovie4";
            this.lbMovie4.Size = new System.Drawing.Size(99, 48);
            this.lbMovie4.TabIndex = 102;
            this.lbMovie4.Text = "Tên gốc: Tarot\r\nGiá vé: 90.000đ\r\nPhòng chiếu: 3";
            // 
            // btnGo4
            // 
            this.btnGo4.AutoSize = true;
            this.btnGo4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo4.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGo4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo4.Location = new System.Drawing.Point(364, 25);
            this.btnGo4.Name = "btnGo4";
            this.btnGo4.Size = new System.Drawing.Size(98, 58);
            this.btnGo4.TabIndex = 101;
            this.btnGo4.Text = "ĐẶT VÉ";
            this.btnGo4.UseVisualStyleBackColor = false;
            this.btnGo4.Click += new System.EventHandler(this.btnGo4_Click);
            // 
            // gbxMovie1
            // 
            this.gbxMovie1.Controls.Add(this.lbMovie1);
            this.gbxMovie1.Controls.Add(this.btnGo1);
            this.gbxMovie1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMovie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMovie1.Location = new System.Drawing.Point(3, 3);
            this.gbxMovie1.Name = "gbxMovie1";
            this.gbxMovie1.Size = new System.Drawing.Size(465, 86);
            this.gbxMovie1.TabIndex = 1;
            this.gbxMovie1.TabStop = false;
            this.gbxMovie1.Text = "Đào, Phở và Piano";
            // 
            // lbMovie1
            // 
            this.lbMovie1.AutoSize = true;
            this.lbMovie1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMovie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovie1.Location = new System.Drawing.Point(3, 25);
            this.lbMovie1.Name = "lbMovie1";
            this.lbMovie1.Size = new System.Drawing.Size(184, 48);
            this.lbMovie1.TabIndex = 102;
            this.lbMovie1.Text = "Tên gốc: Dao, Pho and Piano\r\nGiá vé chuẩn: 45.000đ\r\nPhòng chiếu: 1, 2, 3";
            // 
            // btnGo1
            // 
            this.btnGo1.AutoSize = true;
            this.btnGo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGo1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo1.Location = new System.Drawing.Point(364, 25);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(98, 58);
            this.btnGo1.TabIndex = 101;
            this.btnGo1.Text = "ĐẶT VÉ";
            this.btnGo1.UseVisualStyleBackColor = false;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // gbxMovie2
            // 
            this.gbxMovie2.Controls.Add(this.lbMovie2);
            this.gbxMovie2.Controls.Add(this.btnGo2);
            this.gbxMovie2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMovie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMovie2.Location = new System.Drawing.Point(3, 95);
            this.gbxMovie2.Name = "gbxMovie2";
            this.gbxMovie2.Size = new System.Drawing.Size(465, 86);
            this.gbxMovie2.TabIndex = 2;
            this.gbxMovie2.TabStop = false;
            this.gbxMovie2.Text = "Mai";
            // 
            // lbMovie2
            // 
            this.lbMovie2.AutoSize = true;
            this.lbMovie2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMovie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovie2.Location = new System.Drawing.Point(3, 25);
            this.lbMovie2.Name = "lbMovie2";
            this.lbMovie2.Size = new System.Drawing.Size(145, 48);
            this.lbMovie2.TabIndex = 102;
            this.lbMovie2.Text = "Tên gốc: Mai\r\nGiá vé chuẩn: 100.000đ\r\nPhòng chiếu: 2, 3";
            // 
            // btnGo2
            // 
            this.btnGo2.AutoSize = true;
            this.btnGo2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGo2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo2.Location = new System.Drawing.Point(364, 25);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(98, 58);
            this.btnGo2.TabIndex = 101;
            this.btnGo2.Text = "ĐẶT VÉ";
            this.btnGo2.UseVisualStyleBackColor = false;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // gbxMovie3
            // 
            this.gbxMovie3.Controls.Add(this.lbMovie3);
            this.gbxMovie3.Controls.Add(this.btnGo3);
            this.gbxMovie3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMovie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMovie3.Location = new System.Drawing.Point(3, 187);
            this.gbxMovie3.Name = "gbxMovie3";
            this.gbxMovie3.Size = new System.Drawing.Size(465, 86);
            this.gbxMovie3.TabIndex = 2;
            this.gbxMovie3.TabStop = false;
            this.gbxMovie3.Text = "Gặp Lại Chị Bầu";
            // 
            // lbMovie3
            // 
            this.lbMovie3.AutoSize = true;
            this.lbMovie3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMovie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovie3.Location = new System.Drawing.Point(3, 25);
            this.lbMovie3.Name = "lbMovie3";
            this.lbMovie3.Size = new System.Drawing.Size(247, 48);
            this.lbMovie3.TabIndex = 102;
            this.lbMovie3.Text = "Tên gốc: Meet My Pregnant Sister Again\r\nGiá vé: 70.000đ\r\nPhòng chiếu: 1";
            // 
            // btnGo3
            // 
            this.btnGo3.AutoSize = true;
            this.btnGo3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo3.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGo3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo3.Location = new System.Drawing.Point(364, 25);
            this.btnGo3.Name = "btnGo3";
            this.btnGo3.Size = new System.Drawing.Size(98, 58);
            this.btnGo3.TabIndex = 101;
            this.btnGo3.Text = "ĐẶT VÉ";
            this.btnGo3.UseVisualStyleBackColor = false;
            this.btnGo3.Click += new System.EventHandler(this.btnGo3_Click);
            // 
            // pgbMovie
            // 
            this.pgbMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.pgbMovie.Location = new System.Drawing.Point(0, 0);
            this.pgbMovie.Name = "pgbMovie";
            this.pgbMovie.Size = new System.Drawing.Size(471, 12);
            this.pgbMovie.TabIndex = 103;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 12);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(471, 47);
            this.lbTitle.TabIndex = 104;
            this.lbTitle.Tag = "0";
            this.lbTitle.Text = "Rạp chiếu phim";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.Enabled = false;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(0, 59);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(51, 60);
            this.btnBack.TabIndex = 105;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(420, 59);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(51, 60);
            this.btnNext.TabIndex = 106;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(471, 489);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pgbMovie);
            this.Controls.Add(this.lptableHome);
            this.KeyPreview = true;
            this.Name = "Home";
            this.ShowIcon = false;
            this.Text = "Rạp Chiếu Phim";
            this.Load += new System.EventHandler(this.Home_Load);
            this.lptableHome.ResumeLayout(false);
            this.gbxMovie4.ResumeLayout(false);
            this.gbxMovie4.PerformLayout();
            this.gbxMovie1.ResumeLayout(false);
            this.gbxMovie1.PerformLayout();
            this.gbxMovie2.ResumeLayout(false);
            this.gbxMovie2.PerformLayout();
            this.gbxMovie3.ResumeLayout(false);
            this.gbxMovie3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel lptableHome;
        private System.Windows.Forms.GroupBox gbxMovie4;
        private System.Windows.Forms.Label lbMovie4;
        private System.Windows.Forms.Button btnGo4;
        private System.Windows.Forms.GroupBox gbxMovie1;
        private System.Windows.Forms.Label lbMovie1;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.GroupBox gbxMovie2;
        private System.Windows.Forms.Label lbMovie2;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.GroupBox gbxMovie3;
        private System.Windows.Forms.Label lbMovie3;
        private System.Windows.Forms.Button btnGo3;
        private System.Windows.Forms.ProgressBar pgbMovie;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}