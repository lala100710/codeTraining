namespace WinFormsAppPersonalData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkSame_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSame.Checked)
                txtB.Text = txtA.Text;
        }
    }
}