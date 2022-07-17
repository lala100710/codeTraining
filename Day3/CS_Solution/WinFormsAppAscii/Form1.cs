namespace WinFormsAppAscii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = e.KeyChar; 
            txtAscii.Text=n.ToString();
        }

        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            txtCode.Text = e.KeyCode.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar=char.ToUpper(e.KeyChar);
        }

        private void txtLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x8') return;
            if (!char.IsDigit(e.KeyChar))
                e.KeyChar = '\0';
        }

        private void txtWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x8') return;
            if (!char.IsLetter(e.KeyChar))
                e.KeyChar = '\0';
        }
    }
}