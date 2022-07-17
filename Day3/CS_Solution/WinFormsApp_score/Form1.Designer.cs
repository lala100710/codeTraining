namespace WinFormsApp_score
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.bt_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "成績";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "結果";
            // 
            // txt_score
            // 
            this.txt_score.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_score.Location = new System.Drawing.Point(129, 48);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(125, 27);
            this.txt_score.TabIndex = 2;
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_result.Location = new System.Drawing.Point(129, 99);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(125, 27);
            this.txt_result.TabIndex = 3;
            // 
            // bt_cal
            // 
            this.bt_cal.Location = new System.Drawing.Point(129, 156);
            this.bt_cal.Name = "bt_cal";
            this.bt_cal.Size = new System.Drawing.Size(94, 29);
            this.bt_cal.TabIndex = 4;
            this.bt_cal.Text = "計算";
            this.bt_cal.UseVisualStyleBackColor = true;
            this.bt_cal.Click += new System.EventHandler(this.bt_cal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 248);
            this.Controls.Add(this.bt_cal);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_score;
        private TextBox txt_result;
        private Button bt_cal;
    }
}