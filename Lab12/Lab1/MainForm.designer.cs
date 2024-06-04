
namespace Lab1
{
    partial class MainForm
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
            this.btnQuest1 = new System.Windows.Forms.Button();
            this.btnQuest2 = new System.Windows.Forms.Button();
            this.btnQuest4 = new System.Windows.Forms.Button();
            this.btnQuest5 = new System.Windows.Forms.Button();
            this.btnQuest7 = new System.Windows.Forms.Button();
            this.btnQuest8 = new System.Windows.Forms.Button();
            this.btnQuest3 = new System.Windows.Forms.Button();
            this.btnQuest6 = new System.Windows.Forms.Button();
            this.btnQuest9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuest1
            // 
            this.btnQuest1.Location = new System.Drawing.Point(12, 12);
            this.btnQuest1.Name = "btnQuest1";
            this.btnQuest1.Size = new System.Drawing.Size(87, 27);
            this.btnQuest1.TabIndex = 0;
            this.btnQuest1.Text = "Câu 1";
            this.btnQuest1.UseVisualStyleBackColor = true;
            this.btnQuest1.Click += new System.EventHandler(this.btnQuest1_Click);
            // 
            // btnQuest2
            // 
            this.btnQuest2.Location = new System.Drawing.Point(105, 12);
            this.btnQuest2.Name = "btnQuest2";
            this.btnQuest2.Size = new System.Drawing.Size(87, 27);
            this.btnQuest2.TabIndex = 1;
            this.btnQuest2.Text = "Câu 2";
            this.btnQuest2.UseVisualStyleBackColor = true;
            this.btnQuest2.Click += new System.EventHandler(this.btnQuest2_Click);
            // 
            // btnQuest4
            // 
            this.btnQuest4.Location = new System.Drawing.Point(12, 45);
            this.btnQuest4.Name = "btnQuest4";
            this.btnQuest4.Size = new System.Drawing.Size(87, 27);
            this.btnQuest4.TabIndex = 3;
            this.btnQuest4.Text = "Câu 4";
            this.btnQuest4.UseVisualStyleBackColor = true;
            this.btnQuest4.Click += new System.EventHandler(this.btnQuest4_Click);
            // 
            // btnQuest5
            // 
            this.btnQuest5.Location = new System.Drawing.Point(105, 45);
            this.btnQuest5.Name = "btnQuest5";
            this.btnQuest5.Size = new System.Drawing.Size(87, 27);
            this.btnQuest5.TabIndex = 4;
            this.btnQuest5.Text = "Câu 5";
            this.btnQuest5.UseVisualStyleBackColor = true;
            this.btnQuest5.Click += new System.EventHandler(this.btnQuest5_Click);
            // 
            // btnQuest7
            // 
            this.btnQuest7.Location = new System.Drawing.Point(12, 78);
            this.btnQuest7.Name = "btnQuest7";
            this.btnQuest7.Size = new System.Drawing.Size(87, 27);
            this.btnQuest7.TabIndex = 6;
            this.btnQuest7.Text = "Câu 7";
            this.btnQuest7.UseVisualStyleBackColor = true;
            this.btnQuest7.Click += new System.EventHandler(this.btnQuest7_Click);
            // 
            // btnQuest8
            // 
            this.btnQuest8.Location = new System.Drawing.Point(105, 78);
            this.btnQuest8.Name = "btnQuest8";
            this.btnQuest8.Size = new System.Drawing.Size(87, 27);
            this.btnQuest8.TabIndex = 7;
            this.btnQuest8.Text = "Câu 8";
            this.btnQuest8.UseVisualStyleBackColor = true;
            this.btnQuest8.Click += new System.EventHandler(this.btnQuest8_Click);
            // 
            // btnQuest3
            // 
            this.btnQuest3.Location = new System.Drawing.Point(198, 12);
            this.btnQuest3.Name = "btnQuest3";
            this.btnQuest3.Size = new System.Drawing.Size(87, 27);
            this.btnQuest3.TabIndex = 2;
            this.btnQuest3.Text = "Câu 3";
            this.btnQuest3.UseVisualStyleBackColor = true;
            this.btnQuest3.Click += new System.EventHandler(this.btnQuest3_Click);
            // 
            // btnQuest6
            // 
            this.btnQuest6.Location = new System.Drawing.Point(198, 45);
            this.btnQuest6.Name = "btnQuest6";
            this.btnQuest6.Size = new System.Drawing.Size(87, 27);
            this.btnQuest6.TabIndex = 5;
            this.btnQuest6.Text = "Câu 6";
            this.btnQuest6.UseVisualStyleBackColor = true;
            this.btnQuest6.Click += new System.EventHandler(this.btnQuest6_Click);
            // 
            // btnQuest9
            // 
            this.btnQuest9.Location = new System.Drawing.Point(198, 78);
            this.btnQuest9.Name = "btnQuest9";
            this.btnQuest9.Size = new System.Drawing.Size(87, 27);
            this.btnQuest9.TabIndex = 8;
            this.btnQuest9.Text = "Câu 9";
            this.btnQuest9.UseVisualStyleBackColor = true;
            this.btnQuest9.Click += new System.EventHandler(this.btnQuest9_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 125);
            this.Controls.Add(this.btnQuest8);
            this.Controls.Add(this.btnQuest7);
            this.Controls.Add(this.btnQuest5);
            this.Controls.Add(this.btnQuest4);
            this.Controls.Add(this.btnQuest9);
            this.Controls.Add(this.btnQuest6);
            this.Controls.Add(this.btnQuest3);
            this.Controls.Add(this.btnQuest2);
            this.Controls.Add(this.btnQuest1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Lab 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuest1;
        private System.Windows.Forms.Button btnQuest2;
        private System.Windows.Forms.Button btnQuest4;
        private System.Windows.Forms.Button btnQuest5;
        private System.Windows.Forms.Button btnQuest7;
        private System.Windows.Forms.Button btnQuest8;
        private System.Windows.Forms.Button btnQuest3;
        private System.Windows.Forms.Button btnQuest6;
        private System.Windows.Forms.Button btnQuest9;
    }
}

