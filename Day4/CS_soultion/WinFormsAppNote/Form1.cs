namespace WinFormsAppNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);
                sw.WriteLine(txtData.Text);
                sw.Close();
                MessageBox.Show("¶s¿…¶®•\", "Save");
            }
           


        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(dlgOpen.FileName);
                txtData.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
           
        }
    }
}