namespace WinFormsAppEvent
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
            this.btA = new System.Windows.Forms.Button();
            this.btB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btA
            // 
            this.btA.Location = new System.Drawing.Point(256, 66);
            this.btA.Name = "btA";
            this.btA.Size = new System.Drawing.Size(142, 37);
            this.btA.TabIndex = 0;
            this.btA.Text = "a";
            this.btA.UseVisualStyleBackColor = true;
            this.btA.Click += new System.EventHandler(this.btn_Click);
            // 
            // btB
            // 
            this.btB.Location = new System.Drawing.Point(256, 139);
            this.btB.Name = "btB";
            this.btB.Size = new System.Drawing.Size(142, 46);
            this.btB.TabIndex = 1;
            this.btB.Text = "b";
            this.btB.UseVisualStyleBackColor = true;
            this.btB.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btB);
            this.Controls.Add(this.btA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btA;
        private Button btB;
    }
}