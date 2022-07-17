namespace WinFormsAppRollDices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_roll_Click(object sender, EventArgs e)
        {
            string[] files = { "dice/d1.png","dice/d2.png","dice/d3.png","dice/d4.png" ,"dice/d5.png","dice/d6.png" };
            int n;
            int[] args=new int[4];
            Random random = new Random();
            args[0]=random.Next(0,6);
            pct1.Image = Image.FromFile(files[args[0]]);
            args[1] = random.Next(0, 6);
            pct2.Image = Image.FromFile(files[args[1]]);
            args[2] = random.Next(0, 6);
            pct3.Image = Image.FromFile(files[args[2]]);
            args[3] = random.Next(0, 6);
            pcy4.Image = Image.FromFile(files[args[3]]);
            Array.Sort(args);
            if (args[0] == args[3])
                txt_result.Text = "�@╈";
            else if (args[0] == args[1])
                txt_result.Text = String.Format("{0} 헕", args[2] + args[3]);
            else if (args[1] == args[2])
                txt_result.Text = String.Format("{0} 헕", args[0] + args[3]);
            else if (args[2] == args[3])
                txt_result.Text = String.Format("{0} 헕", args[0] + args[1]);
            else
                txt_result.Text = "쮁헕";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}