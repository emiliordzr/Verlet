using System.Drawing;

namespace Verlet
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        VerletPoint point;
        public Form1()
        {
            InitializeComponent();
            point = new VerletPoint(20, 20);
            bmp= new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image= bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            point.Render(pictureBox1.Width, pictureBox1.Height);
            label1.Text = point.pos.X.ToString();
            label2.Text = point.pos.Y.ToString();
            g.FillEllipse(Brushes.Orange, point.pos.X - point.radius, point.pos.Y - point.radius, point.diameter, point.diameter);
            pictureBox1.Invalidate();
        }
    }
}