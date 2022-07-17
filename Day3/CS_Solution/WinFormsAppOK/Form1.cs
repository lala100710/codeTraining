namespace WinFormsAppOK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world !", "Greeting", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           
        }

        private void btAsk_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("YES OR NO ", "ASK", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ans == DialogResult.Yes)
                txtResult.Text = "yes";
            else
                txtResult.Text = "no";
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you sure ", "leave", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ans == DialogResult.Yes)
                Close();
        }
    }
}