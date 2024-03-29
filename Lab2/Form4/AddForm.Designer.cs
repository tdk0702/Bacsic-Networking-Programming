
namespace Lab2.Form4
{
    partial class AddForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.lbScore1 = new System.Windows.Forms.Label();
            this.tbxScore1 = new System.Windows.Forms.TextBox();
            this.lbScore2 = new System.Windows.Forms.Label();
            this.tbxScore2 = new System.Windows.Forms.TextBox();
            this.lbScore3 = new System.Windows.Forms.Label();
            this.tbxScore3 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 13);
            this.lbName.TabIndex = 99;
            this.lbName.Text = "Họ và tên:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(80, 10);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(130, 20);
            this.tbxName.TabIndex = 0;
            this.tbxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_KeyDown);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(13, 39);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(40, 13);
            this.lbID.TabIndex = 99;
            this.lbID.Text = "MSSV:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(80, 36);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(130, 20);
            this.tbxID.TabIndex = 1;
            this.tbxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_KeyDown);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(13, 65);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(32, 13);
            this.lbPhone.TabIndex = 99;
            this.lbPhone.Text = "SĐT:";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(80, 62);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(130, 20);
            this.tbxPhone.TabIndex = 2;
            this.tbxPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_KeyDown);
            // 
            // lbScore1
            // 
            this.lbScore1.AutoSize = true;
            this.lbScore1.Location = new System.Drawing.Point(13, 91);
            this.lbScore1.Name = "lbScore1";
            this.lbScore1.Size = new System.Drawing.Size(40, 13);
            this.lbScore1.TabIndex = 99;
            this.lbScore1.Text = "Môn 1:";
            // 
            // tbxScore1
            // 
            this.tbxScore1.Location = new System.Drawing.Point(80, 88);
            this.tbxScore1.Name = "tbxScore1";
            this.tbxScore1.Size = new System.Drawing.Size(130, 20);
            this.tbxScore1.TabIndex = 3;
            this.tbxScore1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_KeyDown);
            // 
            // lbScore2
            // 
            this.lbScore2.AutoSize = true;
            this.lbScore2.Location = new System.Drawing.Point(13, 117);
            this.lbScore2.Name = "lbScore2";
            this.lbScore2.Size = new System.Drawing.Size(40, 13);
            this.lbScore2.TabIndex = 99;
            this.lbScore2.Text = "Môn 2:";
            // 
            // tbxScore2
            // 
            this.tbxScore2.Location = new System.Drawing.Point(80, 114);
            this.tbxScore2.Name = "tbxScore2";
            this.tbxScore2.Size = new System.Drawing.Size(130, 20);
            this.tbxScore2.TabIndex = 4;
            this.tbxScore2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_KeyDown);
            // 
            // lbScore3
            // 
            this.lbScore3.AutoSize = true;
            this.lbScore3.Location = new System.Drawing.Point(13, 143);
            this.lbScore3.Name = "lbScore3";
            this.lbScore3.Size = new System.Drawing.Size(40, 13);
            this.lbScore3.TabIndex = 99;
            this.lbScore3.Text = "Môn 3:";
            // 
            // tbxScore3
            // 
            this.tbxScore3.Location = new System.Drawing.Point(80, 140);
            this.tbxScore3.Name = "tbxScore3";
            this.tbxScore3.Size = new System.Drawing.Size(130, 20);
            this.tbxScore3.TabIndex = 5;
            this.tbxScore3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(118, 166);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Xong";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 207);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxScore3);
            this.Controls.Add(this.lbScore3);
            this.Controls.Add(this.tbxScore2);
            this.Controls.Add(this.lbScore2);
            this.Controls.Add(this.tbxScore1);
            this.Controls.Add(this.lbScore1);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lbName);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lbScore1;
        private System.Windows.Forms.TextBox tbxScore1;
        private System.Windows.Forms.Label lbScore2;
        private System.Windows.Forms.TextBox tbxScore2;
        private System.Windows.Forms.Label lbScore3;
        private System.Windows.Forms.TextBox tbxScore3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}