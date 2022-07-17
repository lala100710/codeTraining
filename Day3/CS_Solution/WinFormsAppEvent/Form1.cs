namespace WinFormsAppEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sender 區隔是誰發生觸發事件 boxing 

        private void btn_Click(object sender, EventArgs e)
        {
            //unboxing 語法(解開) 必須與sender 同data type 
            Button button = (Button)sender;
            MessageBox.Show("YOU CLICK ME  "+button.Text+"!");
        }
    }
}