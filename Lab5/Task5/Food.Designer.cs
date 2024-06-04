using System.Drawing;
using System.Windows.Forms;

namespace Task5
{
    partial class Food
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 4);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1466, 228);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(248, 29);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 1;
            label1.Text = "\"FoodName\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 2;
            label2.Text = "Giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 122);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 164);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 4;
            label4.Text = "Đóng góp:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 189);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(336, 85);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 6;
            label5.Text = "\"Price\"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 122);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 7;
            label6.Text = "\"Address\"";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(359, 164);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 8;
            label7.Text = "\"Owner\"";
            // 
            // Food
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Food";
            Size = new Size(1469, 235);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
