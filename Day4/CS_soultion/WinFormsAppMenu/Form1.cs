namespace WinFormsAppMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muNewFile_Click(object sender, EventArgs e)
        {
            txtData.Clear();
        }

        private void muQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void muSaveFile_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);
                sw.WriteLine(txtData.Text);
                sw.Close();
                MessageBox.Show("¶s¿…¶®•\", "Save");
            }
        }

        private void muFontColor_Click(object sender, EventArgs e)
        {
            if (dlgColor.ShowDialog() == DialogResult.OK)
                txtData.ForeColor = dlgColor.Color;
        }

        private void muBackColor_Click(object sender, EventArgs e)
        {
            if(dlgColor.ShowDialog() == DialogResult.OK) 
                txtData.BackColor= dlgColor.Color;
        }

        private void muFont_Click(object sender, EventArgs e)
        {
            if (dlgFont.ShowDialog() == DialogResult.OK)
                txtData.Font = dlgFont.Font;
        }

        private void muOpenFile_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(dlgOpen.FileName);
                txtData.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }
    }
}