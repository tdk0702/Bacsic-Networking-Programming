
namespace Lab2
{
    partial class Form2
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
            this.tbxContent = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.pInfo = new System.Windows.Forms.Panel();
            this.tbxChar = new System.Windows.Forms.TextBox();
            this.lbChar = new System.Windows.Forms.Label();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.lbWord = new System.Windows.Forms.Label();
            this.tbxLine = new System.Windows.Forms.TextBox();
            this.lbLine = new System.Windows.Forms.Label();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.tbxSize = new System.Windows.Forms.TextBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxContent
            // 
            this.tbxContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContent.Location = new System.Drawing.Point(277, 5);
            this.tbxContent.Multiline = true;
            this.tbxContent.Name = "tbxContent";
            this.tbxContent.ReadOnly = true;
            this.tbxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxContent.Size = new System.Drawing.Size(281, 343);
            this.tbxContent.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRead.Location = new System.Drawing.Point(5, 5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(272, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "ĐỌC FILE";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.tbxChar);
            this.pInfo.Controls.Add(this.lbChar);
            this.pInfo.Controls.Add(this.tbxWord);
            this.pInfo.Controls.Add(this.lbWord);
            this.pInfo.Controls.Add(this.tbxLine);
            this.pInfo.Controls.Add(this.lbLine);
            this.pInfo.Controls.Add(this.tbxURL);
            this.pInfo.Controls.Add(this.lbURL);
            this.pInfo.Controls.Add(this.tbxSize);
            this.pInfo.Controls.Add(this.lbSize);
            this.pInfo.Controls.Add(this.tbxName);
            this.pInfo.Controls.Add(this.lbName);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInfo.Location = new System.Drawing.Point(5, 28);
            this.pInfo.Name = "pInfo";
            this.pInfo.Padding = new System.Windows.Forms.Padding(5);
            this.pInfo.Size = new System.Drawing.Size(272, 317);
            this.pInfo.TabIndex = 2;
            // 
            // tbxChar
            // 
            this.tbxChar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChar.Location = new System.Drawing.Point(5, 211);
            this.tbxChar.Name = "tbxChar";
            this.tbxChar.ReadOnly = true;
            this.tbxChar.Size = new System.Drawing.Size(262, 22);
            this.tbxChar.TabIndex = 14;
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(5, 195);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(58, 16);
            this.lbChar.TabIndex = 13;
            this.lbChar.Text = "Số ký tự:";
            // 
            // tbxWord
            // 
            this.tbxWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWord.Location = new System.Drawing.Point(5, 173);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.ReadOnly = true;
            this.tbxWord.Size = new System.Drawing.Size(262, 22);
            this.tbxWord.TabIndex = 12;
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.Location = new System.Drawing.Point(5, 157);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(41, 16);
            this.lbWord.TabIndex = 11;
            this.lbWord.Text = "Số từ:";
            // 
            // tbxLine
            // 
            this.tbxLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLine.Location = new System.Drawing.Point(5, 135);
            this.tbxLine.Name = "tbxLine";
            this.tbxLine.ReadOnly = true;
            this.tbxLine.Size = new System.Drawing.Size(262, 22);
            this.tbxLine.TabIndex = 10;
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLine.Location = new System.Drawing.Point(5, 119);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(62, 16);
            this.lbLine.TabIndex = 9;
            this.lbLine.Text = "Số dòng:";
            // 
            // tbxURL
            // 
            this.tbxURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxURL.Location = new System.Drawing.Point(5, 97);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.ReadOnly = true;
            this.tbxURL.Size = new System.Drawing.Size(262, 22);
            this.tbxURL.TabIndex = 8;
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbURL.Location = new System.Drawing.Point(5, 81);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(35, 16);
            this.lbURL.TabIndex = 7;
            this.lbURL.Text = "URL";
            // 
            // tbxSize
            // 
            this.tbxSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSize.Location = new System.Drawing.Point(5, 59);
            this.tbxSize.Name = "tbxSize";
            this.tbxSize.ReadOnly = true;
            this.tbxSize.Size = new System.Drawing.Size(262, 22);
            this.tbxSize.TabIndex = 6;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(5, 43);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(40, 16);
            this.lbSize.TabIndex = 5;
            this.lbSize.Text = "Size: ";
            // 
            // tbxName
            // 
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(5, 21);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(262, 22);
            this.tbxName.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(5, 5);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 16);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Tên file: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 353);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.tbxContent);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Câu 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxContent;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.TextBox tbxChar;
        private System.Windows.Forms.Label lbChar;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.TextBox tbxLine;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbxSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lbName;
    }
}