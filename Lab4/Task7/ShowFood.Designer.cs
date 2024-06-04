namespace Task7
{
    partial class ShowFood
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
            flp = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // flp
            // 
            flp.Location = new Point(1, 84);
            flp.Margin = new Padding(3, 4, 3, 4);
            flp.Name = "flp";
            flp.Size = new Size(886, 228);
            flp.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(358, 51);
            label1.TabIndex = 1;
            label1.Text = "Món ăn hôm này là";
            // 
            // ShowFood
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 308);
            Controls.Add(label1);
            Controls.Add(flp);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShowFood";
            Text = "ShowFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private Label label1;
    }
}