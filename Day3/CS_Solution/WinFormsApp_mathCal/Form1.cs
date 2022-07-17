namespace WinFormsApp_mathCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txt_a.Text, out a);
            decimal.TryParse(txt_b.Text, out b);
            txt_ans.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txt_a.Text, out a);
            decimal.TryParse(txt_b.Text, out b);
            txt_ans.Text = (a * b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txt_a.Text, out a);
            decimal.TryParse(txt_b.Text, out b);
            txt_ans.Text = (a - b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal a, b;
            decimal.TryParse(txt_a.Text, out a);
            decimal.TryParse(txt_b.Text, out b);
            if (b == 0)
                txt_ans.Text = "除法不為0";
            else
                txt_ans.Text = (a / b).ToString();
        }
    }
}