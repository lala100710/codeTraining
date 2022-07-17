namespace WinFormsApp_ChangeMoney
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
            this.cmbCurr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCurr
            // 
            this.cmbCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurr.FormattingEnabled = true;
            this.cmbCurr.Items.AddRange(new object[] {
            "美金",
            "日圓",
            "歐元"});
            this.cmbCurr.Location = new System.Drawing.Point(335, 68);
            this.cmbCurr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCurr.Name = "cmbCurr";
            this.cmbCurr.Size = new System.Drawing.Size(200, 33);
            this.cmbCurr.TabIndex = 0;
            this.cmbCurr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "幣別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "台幣";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(356, 255);
            this.btSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(125, 38);
            this.btSend.TabIndex = 4;
            this.btSend.Text = "兌換";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 379);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "可兌換金額";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(335, 371);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(165, 33);
            this.txtNum.TabIndex = 6;
            // 
            // txtNT
            // 
            this.txtNT.Location = new System.Drawing.Point(335, 150);
            this.txtNT.Margin = new System.Windows.Forms.Padding(4);
            this.txtNT.Name = "txtNT";
            this.txtNT.Size = new System.Drawing.Size(165, 33);
            this.txtNT.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 461);
            this.Controls.Add(this.txtNT);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCurr);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbCurr;
        private Label label1;
        private Label label2;
        private Button btSend;
        private Label label3;
        private TextBox txtNum;
        private TextBox txtNT;
    }
}