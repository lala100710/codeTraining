namespace WinFormsAppEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sender �Ϲj�O�ֵo��Ĳ�o�ƥ� boxing 

        private void btn_Click(object sender, EventArgs e)
        {
            //unboxing �y�k(�Ѷ}) �����Psender �Pdata type 
            Button button = (Button)sender;
            MessageBox.Show("YOU CLICK ME  "+button.Text+"!");
        }
    }
}