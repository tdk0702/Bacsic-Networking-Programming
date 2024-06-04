namespace Task6
{
    partial class MailSend
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
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHtml = new System.Windows.Forms.CheckBox();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(14, 80);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(31, 20);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "To:";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(14, 11);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(50, 20);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Body";
            // 
            // checkBoxHtml
            // 
            this.checkBoxHtml.AutoSize = true;
            this.checkBoxHtml.Location = new System.Drawing.Point(105, 155);
            this.checkBoxHtml.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxHtml.Name = "checkBoxHtml";
            this.checkBoxHtml.Size = new System.Drawing.Size(78, 24);
            this.checkBoxHtml.TabIndex = 7;
            this.checkBoxHtml.Text = "HTML";
            this.checkBoxHtml.UseVisualStyleBackColor = true;
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(105, 8);
            this.txtfrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.ReadOnly = true;
            this.txtfrom.Size = new System.Drawing.Size(577, 26);
            this.txtfrom.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(105, 42);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(577, 26);
            this.txtname.TabIndex = 9;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(105, 76);
            this.txtto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(577, 26);
            this.txtto.TabIndex = 10;
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(105, 112);
            this.txtsubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(577, 26);
            this.txtsubject.TabIndex = 11;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(82, 208);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(599, 438);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(105, 682);
            this.txtfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(472, 26);
            this.txtfile.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 686);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Attachment";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(597, 682);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(84, 29);
            this.buttonBrowse.TabIndex = 15;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(597, 722);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(84, 29);
            this.buttonSend.TabIndex = 16;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 766);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.checkBoxHtml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHtml;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonSend;
    }
}