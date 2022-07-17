namespace WinFormsAppLoadImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cat_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("animals/CAT.jpg");

        }

        private void bt_chicken_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("animals/images.jpg");
        }

        private void bt_bird_Click(object sender, EventArgs e)
        {
            pct1.Image = Image.FromFile("animals/BIRD.jpg"); 
        }

        private void pct1_Click(object sender, EventArgs e)
        {

        }
    }
}