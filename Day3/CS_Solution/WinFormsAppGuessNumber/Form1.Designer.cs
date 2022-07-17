namespace WinFormsAppGuessNumber
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_atart = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.bt_guess = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGuess);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(115, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "猜數字";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(104, 79);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(157, 27);
            this.txtGuess.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1-99 :";
            // 
            // bt_atart
            // 
            this.bt_atart.Location = new System.Drawing.Point(93, 263);
            this.bt_atart.Name = "bt_atart";
            this.bt_atart.Size = new System.Drawing.Size(139, 40);
            this.bt_atart.TabIndex = 1;
            this.bt_atart.Text = "start";
            this.bt_atart.UseVisualStyleBackColor = true;
            this.bt_atart.Click += new System.EventHandler(this.bt_atart_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(415, 263);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(139, 40);
            this.bt_quit.TabIndex = 2;
            this.bt_quit.Text = "quit";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_guess
            // 
            this.bt_guess.Enabled = false;
            this.bt_guess.Location = new System.Drawing.Point(254, 263);
            this.bt_guess.Name = "bt_guess";
            this.bt_guess.Size = new System.Drawing.Size(139, 40);
            this.bt_guess.TabIndex = 3;
            this.bt_guess.Text = "guess";
            this.bt_guess.UseVisualStyleBackColor = true;
            this.bt_guess.Click += new System.EventHandler(this.bt_guess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_guess);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.bt_atart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtGuess;
        private Label label1;
        private Button bt_atart;
        private Button bt_quit;
        private Button bt_guess;
    }
}