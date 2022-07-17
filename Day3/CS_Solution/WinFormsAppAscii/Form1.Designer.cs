namespace WinFormsAppAscii
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtAscii = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(89, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(425, 27);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(89, 155);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(425, 27);
            this.txtB.TabIndex = 1;
            this.txtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_KeyDown);
            // 
            // txtAscii
            // 
            this.txtAscii.Location = new System.Drawing.Point(89, 87);
            this.txtAscii.Name = "txtAscii";
            this.txtAscii.Size = new System.Drawing.Size(163, 27);
            this.txtAscii.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(89, 209);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(163, 27);
            this.txtCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lower";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "A-Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "0-9";
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(143, 280);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(425, 27);
            this.txtUpper.TabIndex = 8;
            this.txtUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(143, 325);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(425, 27);
            this.txtLower.TabIndex = 9;
            this.txtLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLower_KeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(143, 373);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(425, 27);
            this.txtNum.TabIndex = 10;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_KeyPress);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(143, 423);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(425, 27);
            this.txtWord.TabIndex = 11;
            this.txtWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWord_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtAscii);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtAscii;
        private TextBox txtCode;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUpper;
        private TextBox txtLower;
        private TextBox txtNum;
        private TextBox txtWord;
    }
}