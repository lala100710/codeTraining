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
            //程式載入
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //取消關閉  e.Cancel=true;
            DialogResult ans=MessageBox.Show("確定關閉","離開",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ans==DialogResult.No)
                e.Cancel = true;

        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}