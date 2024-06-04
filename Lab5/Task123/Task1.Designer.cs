namespace Task123
{
    partial class Task1
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
            tbxBody = new TextBox();
            tbxSubject = new TextBox();
            tbxTo = new TextBox();
            tbxFrom = new TextBox();
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbxBody
            // 
            tbxBody.Location = new Point(100, 119);
            tbxBody.Multiline = true;
            tbxBody.Name = "tbxBody";
            tbxBody.Size = new Size(438, 204);
            tbxBody.TabIndex = 3;
            // 
            // tbxSubject
            // 
            tbxSubject.Location = new Point(100, 90);
            tbxSubject.Name = "tbxSubject";
            tbxSubject.Size = new Size(438, 23);
            tbxSubject.TabIndex = 4;
            // 
            // tbxTo
            // 
            tbxTo.Location = new Point(200, 49);
            tbxTo.Name = "tbxTo";
            tbxTo.Size = new Size(198, 23);
            tbxTo.TabIndex = 5;
            // 
            // tbxFrom
            // 
            tbxFrom.Location = new Point(200, 20);
            tbxFrom.Name = "tbxFrom";
            tbxFrom.Size = new Size(198, 23);
            tbxFrom.TabIndex = 6;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(27, 20);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(92, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 24);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 49);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 7;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 93);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 119);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Body:";
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 340);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxBody);
            Controls.Add(tbxSubject);
            Controls.Add(tbxTo);
            Controls.Add(tbxFrom);
            Controls.Add(btnSend);
            Name = "Task1";
            Text = "Task1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxBody;
        private TextBox tbxSubject;
        private TextBox tbxTo;
        private TextBox tbxFrom;
        private Button btnSend;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}