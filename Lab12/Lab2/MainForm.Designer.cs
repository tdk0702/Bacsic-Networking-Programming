
namespace Lab2
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
            this.lbChoose = new System.Windows.Forms.Label();
            this.cbxChoose = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbChoose
            // 
            this.lbChoose.AutoSize = true;
            this.lbChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChoose.Location = new System.Drawing.Point(5, 5);
            this.lbChoose.Name = "lbChoose";
            this.lbChoose.Size = new System.Drawing.Size(67, 16);
            this.lbChoose.TabIndex = 1;
            this.lbChoose.Text = "Chọn câu:";
            // 
            // cbxChoose
            // 
            this.cbxChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChoose.Items.AddRange(new object[] {
            "Câu 1",
            "Câu 2",
            "Câu 3",
            "Câu 4",
            "Câu 5",
            "Câu 6",
            "Câu 7"});
            this.cbxChoose.Location = new System.Drawing.Point(5, 21);
            this.cbxChoose.Name = "cbxChoose";
            this.cbxChoose.Size = new System.Drawing.Size(270, 24);
            this.cbxChoose.TabIndex = 2;
            this.cbxChoose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // btnChoose
            // 
            this.btnChoose.AutoSize = true;
            this.btnChoose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(5, 45);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(270, 26);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 91);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.cbxChoose);
            this.Controls.Add(this.lbChoose);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbChoose;
        private System.Windows.Forms.ComboBox cbxChoose;
        private System.Windows.Forms.Button btnChoose;
    }
}

