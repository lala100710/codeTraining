namespace WinFormsAppLoadImage
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
            this.bt_cat = new System.Windows.Forms.Button();
            this.bt_chicken = new System.Windows.Forms.Button();
            this.bt_bird = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // pct1
            // 
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Image = global::WinFormsAppLoadImage.Properties.Resources.images;
            this.pct1.Location = new System.Drawing.Point(46, 30);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(259, 150);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct1.TabIndex = 0;
            this.pct1.TabStop = false;
            this.pct1.Click += new System.EventHandler(this.pct1_Click);
            // 
            // bt_cat
            // 
            this.bt_cat.Location = new System.Drawing.Point(434, 30);
            this.bt_cat.Name = "bt_cat";
            this.bt_cat.Size = new System.Drawing.Size(94, 29);
            this.bt_cat.TabIndex = 1;
            this.bt_cat.Text = "cat";
            this.bt_cat.UseVisualStyleBackColor = true;
            this.bt_cat.Click += new System.EventHandler(this.bt_cat_Click);
            // 
            // bt_chicken
            // 
            this.bt_chicken.Location = new System.Drawing.Point(434, 96);
            this.bt_chicken.Name = "bt_chicken";
            this.bt_chicken.Size = new System.Drawing.Size(94, 29);
            this.bt_chicken.TabIndex = 2;
            this.bt_chicken.Text = "chicken";
            this.bt_chicken.UseVisualStyleBackColor = true;
            this.bt_chicken.Click += new System.EventHandler(this.bt_chicken_Click);
            // 
            // bt_bird
            // 
            this.bt_bird.Location = new System.Drawing.Point(434, 160);
            this.bt_bird.Name = "bt_bird";
            this.bt_bird.Size = new System.Drawing.Size(94, 29);
            this.bt_bird.TabIndex = 3;
            this.bt_bird.Text = "bird";
            this.bt_bird.UseVisualStyleBackColor = true;
            this.bt_bird.Click += new System.EventHandler(this.bt_bird_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_bird);
            this.Controls.Add(this.bt_chicken);
            this.Controls.Add(this.bt_cat);
            this.Controls.Add(this.pct1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pct1;
        private Button bt_cat;
        private Button bt_chicken;
        private Button bt_bird;
    }
}