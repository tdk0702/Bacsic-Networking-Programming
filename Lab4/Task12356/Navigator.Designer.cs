namespace Task12356
{
    partial class Navigator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Task1 = new Button();
            btn_Task2 = new Button();
            btn_Task3 = new Button();
            btn_Task5 = new Button();
            btn_Task6 = new Button();
            SuspendLayout();
            // 
            // btn_Task1
            // 
            btn_Task1.Font = new Font("Segoe UI", 12F);
            btn_Task1.Location = new Point(107, 78);
            btn_Task1.Name = "btn_Task1";
            btn_Task1.Size = new Size(108, 59);
            btn_Task1.TabIndex = 0;
            btn_Task1.Text = "Task 1";
            btn_Task1.UseVisualStyleBackColor = true;
            btn_Task1.Click += btn_Task1_Click;
            // 
            // btn_Task2
            // 
            btn_Task2.Font = new Font("Segoe UI", 12F);
            btn_Task2.Location = new Point(326, 78);
            btn_Task2.Name = "btn_Task2";
            btn_Task2.Size = new Size(108, 59);
            btn_Task2.TabIndex = 1;
            btn_Task2.Text = "Task 2";
            btn_Task2.UseVisualStyleBackColor = true;
            btn_Task2.Click += btn_Task2_Click;
            // 
            // btn_Task3
            // 
            btn_Task3.Font = new Font("Segoe UI", 12F);
            btn_Task3.Location = new Point(548, 78);
            btn_Task3.Name = "btn_Task3";
            btn_Task3.Size = new Size(108, 59);
            btn_Task3.TabIndex = 2;
            btn_Task3.Text = "Task 3";
            btn_Task3.UseVisualStyleBackColor = true;
            btn_Task3.Click += btn_Task3_Click;
            // 
            // btn_Task5
            // 
            btn_Task5.Font = new Font("Segoe UI", 12F);
            btn_Task5.Location = new Point(107, 217);
            btn_Task5.Name = "btn_Task5";
            btn_Task5.Size = new Size(108, 59);
            btn_Task5.TabIndex = 3;
            btn_Task5.Text = "Task 5";
            btn_Task5.UseVisualStyleBackColor = true;
            btn_Task5.Click += btn_Task5_Click;
            // 
            // btn_Task6
            // 
            btn_Task6.Font = new Font("Segoe UI", 12F);
            btn_Task6.Location = new Point(326, 217);
            btn_Task6.Name = "btn_Task6";
            btn_Task6.Size = new Size(108, 59);
            btn_Task6.TabIndex = 4;
            btn_Task6.Text = "Task 6";
            btn_Task6.UseVisualStyleBackColor = true;
            btn_Task6.Click += btn_Task6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Task6);
            Controls.Add(btn_Task5);
            Controls.Add(btn_Task3);
            Controls.Add(btn_Task2);
            Controls.Add(btn_Task1);
            Name = "Form1";
            Text = "Navigator";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Task1;
        private Button btn_Task2;
        private Button btn_Task3;
        private Button btn_Task5;
        private Button btn_Task6;
    }
}
