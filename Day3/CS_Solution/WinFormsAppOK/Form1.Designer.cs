namespace WinFormsAppOK
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
            this.btOk = new System.Windows.Forms.Button();
            this.btAsk = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(82, 49);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(89, 33);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btAsk
            // 
            this.btAsk.Location = new System.Drawing.Point(82, 115);
            this.btAsk.Name = "btAsk";
            this.btAsk.Size = new System.Drawing.Size(89, 33);
            this.btAsk.TabIndex = 1;
            this.btAsk.Text = "ask";
            this.btAsk.UseVisualStyleBackColor = true;
            this.btAsk.Click += new System.EventHandler(this.btAsk_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(229, 115);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(175, 27);
            this.txtResult.TabIndex = 2;
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(454, 175);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(148, 30);
            this.btQuit.TabIndex = 3;
            this.btQuit.Text = "quit";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 289);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btAsk);
            this.Controls.Add(this.btOk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btOk;
        private Button btAsk;
        private TextBox txtResult;
        private Button btQuit;
    }
}