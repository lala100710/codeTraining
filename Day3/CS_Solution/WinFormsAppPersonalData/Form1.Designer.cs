namespace WinFormsAppPersonalData
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
            this.chkSame = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(138, 54);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(431, 27);
            this.txtA.TabIndex = 0;
            this.txtA.TextChanged += new System.EventHandler(this.chkSame_CheckedChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(138, 165);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(431, 27);
            this.txtB.TabIndex = 1;
            // 
            // chkSame
            // 
            this.chkSame.AutoSize = true;
            this.chkSame.Location = new System.Drawing.Point(138, 136);
            this.chkSame.Name = "chkSame";
            this.chkSame.Size = new System.Drawing.Size(61, 23);
            this.chkSame.TabIndex = 2;
            this.chkSame.Text = "同上";
            this.chkSame.UseVisualStyleBackColor = true;
            this.chkSame.CheckedChanged += new System.EventHandler(this.chkSame_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSame);
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
        private CheckBox chkSame;
    }
}