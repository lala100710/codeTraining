namespace WinFormsAppGuessNumber
{
    public partial class Form1 : Form
    {
        int ans, guess;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_guess_Click(object sender, EventArgs e)
        {
            int.TryParse(txtGuess.Text, out guess);
           
            if (ans > guess)
                MessageBox.Show("���@�I ", "����");
            else if(ans < guess)
                MessageBox.Show("�C�@�I ", "����");
            else
            {
                MessageBox.Show("����F ", "����");
                txtGuess.Text = "";
                bt_atart.Enabled = true;
                txtGuess.Enabled = false;
                bt_guess.Enabled = false;
            }
              
        }

        private void bt_atart_Click(object sender, EventArgs e)
        {
            Random rand=new Random();
            ans=rand.Next(1,100);
            bt_guess.Enabled = true;
            bt_atart.Enabled = false;
            txtGuess.Enabled = true;
        }
    }
}