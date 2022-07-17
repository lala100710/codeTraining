namespace WinFormsAppMeal
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
            this.rdoNo1 = new System.Windows.Forms.RadioButton();
            this.rdoNo2 = new System.Windows.Forms.RadioButton();
            this.rdoNo3 = new System.Windows.Forms.RadioButton();
            this.grMeal = new System.Windows.Forms.GroupBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.chkPie = new System.Windows.Forms.CheckBox();
            this.chkCream = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.grMeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoNo1
            // 
            this.rdoNo1.AutoSize = true;
            this.rdoNo1.Location = new System.Drawing.Point(60, 28);
            this.rdoNo1.Name = "rdoNo1";
            this.rdoNo1.Size = new System.Drawing.Size(88, 23);
            this.rdoNo1.TabIndex = 0;
            this.rdoNo1.TabStop = true;
            this.rdoNo1.Text = "No1(95)";
            this.rdoNo1.UseVisualStyleBackColor = true;
            // 
            // rdoNo2
            // 
            this.rdoNo2.AutoSize = true;
            this.rdoNo2.Location = new System.Drawing.Point(57, 73);
            this.rdoNo2.Name = "rdoNo2";
            this.rdoNo2.Size = new System.Drawing.Size(97, 23);
            this.rdoNo2.TabIndex = 1;
            this.rdoNo2.TabStop = true;
            this.rdoNo2.Text = "No2(105)";
            this.rdoNo2.UseVisualStyleBackColor = true;
            // 
            // rdoNo3
            // 
            this.rdoNo3.AutoSize = true;
            this.rdoNo3.Location = new System.Drawing.Point(60, 130);
            this.rdoNo3.Name = "rdoNo3";
            this.rdoNo3.Size = new System.Drawing.Size(97, 23);
            this.rdoNo3.TabIndex = 2;
            this.rdoNo3.TabStop = true;
            this.rdoNo3.Text = "No3(120)";
            this.rdoNo3.UseVisualStyleBackColor = true;
            // 
            // grMeal
            // 
            this.grMeal.Controls.Add(this.rdoNo3);
            this.grMeal.Controls.Add(this.rdoNo2);
            this.grMeal.Controls.Add(this.rdoNo1);
            this.grMeal.Location = new System.Drawing.Point(26, 12);
            this.grMeal.Name = "grMeal";
            this.grMeal.Size = new System.Drawing.Size(225, 188);
            this.grMeal.TabIndex = 0;
            this.grMeal.TabStop = false;
            this.grMeal.Text = "餐點";
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(114, 356);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(94, 29);
            this.bt_send.TabIndex = 0;
            this.bt_send.Text = "計算";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // chkPie
            // 
            this.chkPie.AutoSize = true;
            this.chkPie.Location = new System.Drawing.Point(83, 230);
            this.chkPie.Name = "chkPie";
            this.chkPie.Size = new System.Drawing.Size(124, 23);
            this.chkPie.TabIndex = 1;
            this.chkPie.Text = "Apple Pie(25)";
            this.chkPie.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            this.chkCream.AutoSize = true;
            this.chkCream.Location = new System.Drawing.Point(83, 271);
            this.chkCream.Name = "chkCream";
            this.chkCream.Size = new System.Drawing.Size(128, 23);
            this.chkCream.TabIndex = 2;
            this.chkCream.Text = "Ice Cream(15)";
            this.chkCream.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "小計";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(101, 321);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(125, 27);
            this.txtCount.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkCream);
            this.Controls.Add(this.chkPie);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.grMeal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grMeal.ResumeLayout(false);
            this.grMeal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rdoNo1;
        private RadioButton rdoNo2;
        private RadioButton rdoNo3;
        private GroupBox grMeal;
        private Button bt_send;
        private CheckBox chkPie;
        private CheckBox chkCream;
        private Label label1;
        private TextBox txtCount;
    }
}