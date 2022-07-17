namespace WinFormsAppDraw
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
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btLine = new System.Windows.Forms.Button();
            this.btRec = new System.Windows.Forms.Button();
            this.btEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Location = new System.Drawing.Point(45, 44);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(449, 307);
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            this.pct1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseDown);
            this.pct1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pct1_MouseMove);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(45, 372);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(715, 27);
            this.txtData.TabIndex = 1;
            // 
            // btLine
            // 
            this.btLine.Location = new System.Drawing.Point(532, 58);
            this.btLine.Name = "btLine";
            this.btLine.Size = new System.Drawing.Size(228, 45);
            this.btLine.TabIndex = 2;
            this.btLine.Text = "Line";
            this.btLine.UseVisualStyleBackColor = true;
            this.btLine.Click += new System.EventHandler(this.btLine_Click);
            // 
            // btRec
            // 
            this.btRec.Location = new System.Drawing.Point(532, 138);
            this.btRec.Name = "btRec";
            this.btRec.Size = new System.Drawing.Size(228, 45);
            this.btRec.TabIndex = 3;
            this.btRec.Text = "Rectangle";
            this.btRec.UseVisualStyleBackColor = true;
            this.btRec.Click += new System.EventHandler(this.btRec_Click);
            // 
            // btEllipse
            // 
            this.btEllipse.Location = new System.Drawing.Point(532, 224);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(228, 45);
            this.btEllipse.TabIndex = 4;
            this.btEllipse.Text = "Ellipse";
            this.btEllipse.UseVisualStyleBackColor = true;
            this.btEllipse.Click += new System.EventHandler(this.btEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEllipse);
            this.Controls.Add(this.btRec);
            this.Controls.Add(this.btLine);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.pct1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct1;
        private TextBox txtData;
        private Button btLine;
        private Button btRec;
        private Button btEllipse;
    }
}