namespace WinFormsApp_ChangeMoney
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btSend_Click(object sender, EventArgs e)
        {
            decimal amout;
            int nt;
            int.TryParse(txtNT.Text,out nt);
            switch (cmbCurr.Text)
            {
                case "����":
                    amout = nt / 30.05m;
                    break;
                case "���":
                    amout = nt / 0.2756m;
                    break;
                case "�ڤ�":
                    amout = nt / 32.15m;
                    break;
                default:
                    amout = 0;
                    break;
            }
            txtNum.Text=amout.ToString("#,##0.00");
        }
    }
}