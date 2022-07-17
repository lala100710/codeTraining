namespace WinFormsAppCalculator
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(58, 49);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(207, 27);
            this.txtDisplay.TabIndex = 0;
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(63, 82);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(46, 48);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "1";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(135, 82);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(46, 48);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "2";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(63, 218);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(46, 48);
            this.bt1.TabIndex = 3;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(63, 146);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(46, 48);
            this.bt4.TabIndex = 4;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(219, 82);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(46, 48);
            this.bt9.TabIndex = 5;
            this.bt9.Text = "3";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(135, 146);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(46, 48);
            this.bt5.TabIndex = 6;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(135, 218);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(46, 48);
            this.bt2.TabIndex = 7;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(219, 146);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(46, 48);
            this.bt6.TabIndex = 8;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(218, 218);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(47, 48);
            this.bt3.TabIndex = 9;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(58, 295);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(136, 34);
            this.bt0.TabIndex = 10;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt_Click);
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(218, 288);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(46, 48);
            this.btDot.TabIndex = 11;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 403);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtDisplay;
        private Button bt7;
        private Button bt8;
        private Button bt1;
        private Button bt4;
        private Button bt9;
        private Button bt5;
        private Button bt2;
        private Button bt6;
        private Button bt3;
        private Button bt0;
        private Button btDot;
    }
}