namespace Task12356
{
    partial class ViewSource
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.WhiteSmoke;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(889, 562);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ViewSource
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewSource";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viewsource";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}