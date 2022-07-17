namespace WinFormsAppRollDices
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
            this.pcy4 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.bt_roll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Location = new System.Drawing.Point(32, 12);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(120, 119);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            // 
            // pcy4
            // 
            this.pcy4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcy4.Location = new System.Drawing.Point(601, 16);
            this.pcy4.Name = "pcy4";
            this.pcy4.Size = new System.Drawing.Size(120, 119);
            this.pcy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcy4.TabIndex = 1;
            this.pcy4.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct3.Location = new System.Drawing.Point(407, 16);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(120, 119);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct3.TabIndex = 2;
            this.pct3.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct2.Location = new System.Drawing.Point(211, 16);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(120, 119);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 3;
            this.pct2.TabStop = false;
            // 
            // bt_roll
            // 
            this.bt_roll.Location = new System.Drawing.Point(526, 254);
            this.bt_roll.Name = "bt_roll";
            this.bt_roll.Size = new System.Drawing.Size(129, 68);
            this.bt_roll.TabIndex = 4;
            this.bt_roll.Text = "Roll";
            this.bt_roll.UseVisualStyleBackColor = true;
            this.bt_roll.Click += new System.EventHandler(this.bt_roll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "點數";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(109, 246);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(106, 27);
            this.txt_result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_roll);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pcy4);
            this.Controls.Add(this.pct1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pct1;
        private PictureBox pcy4;
        private PictureBox pct3;
        private PictureBox pct2;
        private Button bt_roll;
        private Label label1;
        private TextBox txt_result;
    }
}