namespace WinFormsAppMeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            int total =0;
            if (rdoNo1.Checked)
                total += 95;
            else if (rdoNo2.Checked)
                total += 105;
            else if (rdoNo3.Checked)
                total += 120;
            if (chkCream.Checked)
                total += 15;
            if (chkPie.Checked)
                total += 25;
            txtCount.Text = total.ToString();
        }
    }
}