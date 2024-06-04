
namespace Lab2
{
    partial class Form7
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Subfolder");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("D:", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.trvFile = new System.Windows.Forms.TreeView();
            this.pBrowse = new System.Windows.Forms.Panel();
            this.tbxBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.prbBrowse = new System.Windows.Forms.ProgressBar();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.pBrowse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // trvFile
            // 
            this.trvFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvFile.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvFile.FullRowSelect = true;
            this.trvFile.HideSelection = false;
            this.trvFile.ItemHeight = 20;
            this.trvFile.Location = new System.Drawing.Point(0, 0);
            this.trvFile.Name = "trvFile";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Subfolder";
            treeNode2.Checked = true;
            treeNode2.Name = "Node0";
            treeNode2.Text = "D:";
            this.trvFile.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.trvFile.ShowNodeToolTips = true;
            this.trvFile.Size = new System.Drawing.Size(260, 528);
            this.trvFile.TabIndex = 99;
            this.trvFile.DoubleClick += new System.EventHandler(this.trvFile_DoubleClick);
            // 
            // pBrowse
            // 
            this.pBrowse.Controls.Add(this.tbxBrowse);
            this.pBrowse.Controls.Add(this.btnBrowse);
            this.pBrowse.Controls.Add(this.prbBrowse);
            this.pBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBrowse.Location = new System.Drawing.Point(260, 0);
            this.pBrowse.Name = "pBrowse";
            this.pBrowse.Padding = new System.Windows.Forms.Padding(5);
            this.pBrowse.Size = new System.Drawing.Size(521, 53);
            this.pBrowse.TabIndex = 5;
            // 
            // tbxBrowse
            // 
            this.tbxBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBrowse.Location = new System.Drawing.Point(5, 5);
            this.tbxBrowse.Name = "tbxBrowse";
            this.tbxBrowse.Size = new System.Drawing.Size(457, 26);
            this.tbxBrowse.TabIndex = 0;
            this.tbxBrowse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxBrowse_KeyDown);
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBrowse.Location = new System.Drawing.Point(462, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(54, 28);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxBrowse_KeyDown);
            // 
            // prbBrowse
            // 
            this.prbBrowse.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.prbBrowse.Location = new System.Drawing.Point(5, 33);
            this.prbBrowse.Name = "prbBrowse";
            this.prbBrowse.Size = new System.Drawing.Size(511, 15);
            this.prbBrowse.TabIndex = 8;
            // 
            // pbxMain
            // 
            this.pbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxMain.Location = new System.Drawing.Point(260, 53);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(521, 475);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMain.TabIndex = 8;
            this.pbxMain.TabStop = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 528);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.pBrowse);
            this.Controls.Add(this.trvFile);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.pBrowse.ResumeLayout(false);
            this.pBrowse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvFile;
        private System.Windows.Forms.Panel pBrowse;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.TextBox tbxBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar prbBrowse;
    }
}