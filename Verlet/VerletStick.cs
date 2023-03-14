using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Verlet
{
    public class VerletStick
    {
        public VerletPoint startPoint, endPoint;
        public float stiffness, length, damp, tot, m1, m2, dis, diff;
        public Vec2 offset, dxy;
        

        public VerletStick(VerletPoint s, VerletPoint e)
        {
            startPoint= s;
            endPoint= e;
            stiffness = 25f;
            damp = 0.05f;
            length=startPoint.pos.Distance(endPoint.pos);
            tot = s.mass + e.mass;
            m1 = e.mass / tot;
            m2 = s.mass / tot;
        }

        public void Update()
        {
            dxy=endPoint.pos - startPoint.pos;
            dis = dxy.Length();
            diff = stiffness * (length - dis) / dis;
            offset = dxy * diff * damp;
            if(!startPoint.pinned)
                startPoint.pos -= offset * m1;
            endPoint.pos += offset * m2;
        }
        
        public void Render(Graphics g)
        {
            Update();
            g.DrawLine(Pens.Green, startPoint.pos.X, startPoint.pos.Y, endPoint.pos.X, endPoint.pos.Y);
        }

    }
}
