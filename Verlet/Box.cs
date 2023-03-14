using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlet
{
    public class Box
    {
        public VerletPoint p1, p2, p3, p4;
        public VerletStick s1, s2, s3, s4, s5, s6;
        public Box(int height, int width) 
        {
            p1= new VerletPoint(200, 50, 20,0);
            p2 = new VerletPoint(200 + width, 50);
            p3 = new VerletPoint(200 + width, 50 + height);
            p4 = new VerletPoint(200, 50 + height);

            s1 = new VerletStick(p1, p2);
            s2 = new VerletStick(p2, p3);
            s3 = new VerletStick(p3, p4);
            s4 = new VerletStick(p4, p1);
            s5 = new VerletStick(p1, p3);
            s6 = new VerletStick(p2, p4);
        }

        public void Render(Graphics g, int width, int height)
        {
            p1.Render(g, width, height);
            p2.Render(g, width, height);
            p3.Render(g, width, height);
            p4.Render(g, width, height);

            s1.Render(g);
            s2.Render(g);
            s3.Render(g);
            s4.Render(g);
            s5.Render(g);
            s6.Render(g);
        }

    }
}
