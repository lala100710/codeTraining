namespace WinFormsAppTimer
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
            this.components = new System.ComponentModel.Container();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(45, 36);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(217, 27);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "0";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(37, 112);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(94, 29);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(237, 112);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(94, 29);
            this.btReset.TabIndex = 2;
            this.btReset.Text = "reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(137, 112);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(94, 29);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 336);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.txtN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtN;
        private Button btStart;
        private Button btReset;
        private Button btStop;
        private System.Windows.Forms.Timer timer1;
    }
}