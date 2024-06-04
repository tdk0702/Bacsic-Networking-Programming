namespace Task5
{
    partial class Invite
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 160);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 26);
            this.textBox1.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(544, 219);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 36);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(729, 135);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(669, 219);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 36);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button2_Click);
            // 
            // Invite
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 427);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Invite";
            this.Text = "Invite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_send;
    }
}