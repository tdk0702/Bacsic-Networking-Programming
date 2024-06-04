namespace Task12356
{
    partial class Task3
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
            btn_load = new Button();
            btn_reload = new Button();
            btn_downR = new Button();
            btn_downS = new Button();
            textBox1 = new TextBox();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            btn_viewS = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // btn_load
            // 
            btn_load.Location = new Point(53, 40);
            btn_load.Margin = new Padding(2, 2, 2, 2);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(80, 27);
            btn_load.TabIndex = 0;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_reload
            // 
            btn_reload.Location = new Point(736, 7);
            btn_reload.Margin = new Padding(2, 2, 2, 2);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(80, 27);
            btn_reload.TabIndex = 1;
            btn_reload.Text = "Reload";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // btn_downR
            // 
            btn_downR.Location = new Point(668, 38);
            btn_downR.Margin = new Padding(2, 2, 2, 2);
            btn_downR.Name = "btn_downR";
            btn_downR.Size = new Size(148, 27);
            btn_downR.TabIndex = 2;
            btn_downR.Text = "Download Resource";
            btn_downR.UseVisualStyleBackColor = true;
            btn_downR.Click += btn_downR_Click;
            // 
            // btn_downS
            // 
            btn_downS.Location = new Point(542, 38);
            btn_downS.Margin = new Padding(2, 2, 2, 2);
            btn_downS.Name = "btn_downS";
            btn_downS.Size = new Size(122, 27);
            btn_downS.TabIndex = 3;
            btn_downS.Text = "Download Source";
            btn_downS.UseVisualStyleBackColor = true;
            btn_downS.Click += btn_downS_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 7);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(680, 29);
            textBox1.TabIndex = 4;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(8, 68);
            webView.Margin = new Padding(2, 2, 2, 2);
            webView.Name = "webView";
            webView.Size = new Size(806, 311);
            webView.TabIndex = 5;
            webView.ZoomFactor = 1D;
            // 
            // btn_viewS
            // 
            btn_viewS.Location = new Point(415, 38);
            btn_viewS.Margin = new Padding(2, 2, 2, 2);
            btn_viewS.Name = "btn_viewS";
            btn_viewS.Size = new Size(122, 27);
            btn_viewS.TabIndex = 6;
            btn_viewS.Text = "View Source";
            btn_viewS.UseVisualStyleBackColor = true;
            btn_viewS.Click += btn_viewS_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 7;
            label1.Text = "URL:";
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 386);
            Controls.Add(label1);
            Controls.Add(btn_viewS);
            Controls.Add(webView);
            Controls.Add(textBox1);
            Controls.Add(btn_downS);
            Controls.Add(btn_downR);
            Controls.Add(btn_reload);
            Controls.Add(btn_load);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Task3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task 3";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_load;
        private Button btn_reload;
        private Button btn_downR;
        private Button btn_downS;
        private TextBox textBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Button btn_viewS;
        private Label label1;
    }
}