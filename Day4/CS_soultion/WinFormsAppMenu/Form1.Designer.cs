namespace WinFormsAppMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muFile = new System.Windows.Forms.ToolStripMenuItem();
            this.muNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.muOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.muSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.muQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.muView = new System.Windows.Forms.ToolStripMenuItem();
            this.muFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.muBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.muFont = new System.Windows.Forms.ToolStripMenuItem();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muFile,
            this.muView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // muFile
            // 
            this.muFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muNewFile,
            this.muOpenFile,
            this.muSaveFile,
            this.muQuit});
            this.muFile.Name = "muFile";
            this.muFile.Size = new System.Drawing.Size(71, 24);
            this.muFile.Text = "檔案(&F)";
            // 
            // muNewFile
            // 
            this.muNewFile.Name = "muNewFile";
            this.muNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.muNewFile.Size = new System.Drawing.Size(224, 26);
            this.muNewFile.Text = "開新檔案";
            this.muNewFile.Click += new System.EventHandler(this.muNewFile_Click);
            // 
            // muOpenFile
            // 
            this.muOpenFile.Name = "muOpenFile";
            this.muOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.muOpenFile.Size = new System.Drawing.Size(224, 26);
            this.muOpenFile.Text = "開啟舊檔";
            this.muOpenFile.Click += new System.EventHandler(this.muOpenFile_Click);
            // 
            // muSaveFile
            // 
            this.muSaveFile.Name = "muSaveFile";
            this.muSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.muSaveFile.Size = new System.Drawing.Size(224, 26);
            this.muSaveFile.Text = "儲存檔案";
            this.muSaveFile.Click += new System.EventHandler(this.muSaveFile_Click);
            // 
            // muQuit
            // 
            this.muQuit.Name = "muQuit";
            this.muQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.muQuit.Size = new System.Drawing.Size(224, 26);
            this.muQuit.Text = "離開";
            this.muQuit.Click += new System.EventHandler(this.muQuit_Click);
            // 
            // muView
            // 
            this.muView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muFontColor,
            this.muBackColor,
            this.muFont});
            this.muView.Name = "muView";
            this.muView.Size = new System.Drawing.Size(73, 24);
            this.muView.Text = "檢視(&V)";
            // 
            // muFontColor
            // 
            this.muFontColor.Name = "muFontColor";
            this.muFontColor.Size = new System.Drawing.Size(161, 26);
            this.muFontColor.Text = "文字顏色...";
            this.muFontColor.Click += new System.EventHandler(this.muFontColor_Click);
            // 
            // muBackColor
            // 
            this.muBackColor.Name = "muBackColor";
            this.muBackColor.Size = new System.Drawing.Size(161, 26);
            this.muBackColor.Text = "背景顏色...";
            this.muBackColor.Click += new System.EventHandler(this.muBackColor_Click);
            // 
            // muFont
            // 
            this.muFont.Name = "muFont";
            this.muFont.Size = new System.Drawing.Size(161, 26);
            this.muFont.Text = "字型...";
            this.muFont.Click += new System.EventHandler(this.muFont_Click);
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(0, 28);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtData.Size = new System.Drawing.Size(800, 422);
            this.txtData.TabIndex = 1;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            this.dlgOpen.Filter = "All Files|*.*|Text Files|*.txt";
            this.dlgOpen.FilterIndex = 2;
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "All Files|*.*|Text Files|*.txt";
            this.dlgSave.FilterIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem muFile;
        private ToolStripMenuItem muNewFile;
        private ToolStripMenuItem muOpenFile;
        private ToolStripMenuItem muSaveFile;
        private ToolStripMenuItem muQuit;
        private ToolStripMenuItem muView;
        private ToolStripMenuItem muFontColor;
        private ToolStripMenuItem muBackColor;
        private ToolStripMenuItem muFont;
        private TextBox txtData;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private ColorDialog dlgColor;
        private FontDialog dlgFont;
    }
}