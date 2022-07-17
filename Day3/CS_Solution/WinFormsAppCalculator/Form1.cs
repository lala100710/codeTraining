namespace WinFormsAppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;  
            txtDisplay.Text  =txtDisplay.Text+ btn.Text;
        }
    }
}