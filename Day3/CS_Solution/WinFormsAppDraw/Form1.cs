namespace WinFormsAppDraw
{
    public partial class Form1 : Form
    {
        int x0, y0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pct1_MouseMove(object sender, MouseEventArgs e)
        {
            txtData.Text=String.Format("x={0}, y={1}, Button{2}",
                e.X, e.Y,e.Button);
            //�P�_�O�_���F����
            if(e.Button == MouseButtons.Left)
            {
                Graphics graphics = pct1.CreateGraphics();
                graphics.DrawLine(new Pen(Color.Black),x0,y0,e.X,e.Y);

                //�����s�y��
                x0 = e.X;
                y0 = e.Y;
            }

        }

        private void btLine_Click(object sender, EventArgs e)
        {
            Graphics g = pct1.CreateGraphics(); //��X�e��
            g.DrawLine(new Pen(Color.Blue), 10, 10, 110, 110);
        }

        private void btRec_Click(object sender, EventArgs e)
        {
            Graphics graphics = pct1.CreateGraphics();
            graphics.DrawRectangle(new Pen(Color.Brown), 10, 10, 100, 100);
        }

        private void btEllipse_Click(object sender, EventArgs e)
        {
            Graphics graphics = pct1.CreateGraphics();
            graphics.DrawEllipse(new Pen(Color.DarkOliveGreen), 10, 10, 100, 100);
        }
        //���o���U�ƹ����y��
        private void pct1_MouseDown(object sender, MouseEventArgs e)
        {
            x0=e.X;
            y0=e.Y;
        }
    }
}