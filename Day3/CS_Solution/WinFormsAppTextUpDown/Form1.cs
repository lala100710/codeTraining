namespace WinFormsAppTextUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                case Keys.Down:
                    SendKeys.Send("{Tab}");
                    break;
                case Keys.Up:
                    SendKeys.Send("+{Tab}");
                    break ;
            }
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectAll();

        }
    }
}