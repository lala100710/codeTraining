namespace WinFormsAppTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //�{�����J
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //��������  e.Cancel=true;
            DialogResult ans=MessageBox.Show("�T�w����","���}",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ans==DialogResult.No)
                e.Cancel = true;

        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}