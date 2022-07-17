namespace WinFormsAppOpenFileNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            dlgSave.ShowDialog();
            if (dlgSave.ShowDialog() == DialogResult.OK)
                txtData.Text = dlgSave.FileName;
            else
                txtData.Text = "<Cancel> ";
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            dlgOpen.ShowDialog();
            if(dlgOpen.ShowDialog() == DialogResult.OK)
                txtData.Text = dlgOpen.FileName;
            else
                txtData.Text = "<Cancel >";
        }
    }
}