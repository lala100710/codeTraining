namespace WinFormsApp_score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_cal_Click(object sender, EventArgs e)
        {
            int score;
            int.TryParse(txt_score.Text, out score);
            if(score <60)
            {
                txt_result.BackColor = Color.Tomato;
                txt_result.ForeColor = Color.Tan;
                txt_result.Text = "不及格";
            }
            else
            {
                txt_result.BackColor = Color.Thistle;
                txt_result.ForeColor = Color.SteelBlue;
                txt_result.Text = "及格";
            }
        }
    }
}