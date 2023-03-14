using System.Drawing;
using System.Net;

namespace Verlet
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        VerletPoint point, point2, point3, point4;
        VerletStick stick, stick2, stick3;
        bool pin = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Init();
        }

        Box box;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            point = new VerletPoint(350, 20, pin);
            point2 = new VerletPoint(325, 20);
            point3 = new VerletPoint(300, 20);
            point4 = new VerletPoint(275, 20);
            stick = new VerletStick(point, point2);
            stick2 = new VerletStick(point2, point3);
            stick3 = new VerletStick(point3, point4);
            box = new Box(30, 30);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);
            point.Render(g, pictureBox1.Width, pictureBox1.Height);
            point2.Render(g, pictureBox1.Width, pictureBox1.Height);
            point3.Render(g, pictureBox1.Width, pictureBox1.Height);
            point4.Render(g, pictureBox1.Width, pictureBox1.Height);
            stick.Render(g);
            stick2.Render(g);
            stick3.Render(g);
            label1.Text = point.pos.X.ToString();
            label2.Text = point.pos.Y.ToString();
            box.Render(g, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Invalidate();
        }
    }
}