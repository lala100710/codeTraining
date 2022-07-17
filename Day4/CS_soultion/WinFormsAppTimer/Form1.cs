namespace WinFormsAppTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n;
            int.TryParse(txtN.Text, out n);
            txtN.Text = (++n).ToString();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtN.Text ="0" ;
        }
    }
}