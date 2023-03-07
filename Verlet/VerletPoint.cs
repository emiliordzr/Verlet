using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlet
{
    public class VerletPoint
    {
        Graphics g;
        Bitmap bmp;
        public Vec2 pos, old;
        public Vec2 gravity;
        Brush brush;
        public float friction = 0.97f;
        public float groundFriction = 0.7f;
        public float radius = 10;
        public float mass = 1;
        public float diameter;


        public VerletPoint(float x, float y)
        {
            pos=new Vec2(x, y);
            old=new Vec2(x, y);
            gravity=new Vec2(0, 1);
            diameter = radius + radius;
            Color c = Color.Orange;
            brush=new SolidBrush(c);
        }


        public void Update(int width, int height)
        {
            var vel = pos - old;
            vel = vel * friction;

            if(pos.Y>=height-radius && vel.MagSqrt() > 0.000001)
            {
                var m = vel.Length();
                vel /= m;
                vel *= (m * groundFriction);
            }

            old = pos;
            pos += vel + gravity;
        }

        public void Constraints(int width, int height)
        {
            if (pos.X > width - radius)
                pos.X = width - radius;
            if (pos.X < radius)
                pos.X = radius;
            if (pos.Y > height - radius)
                pos.Y = height - radius;
            if (pos.Y < radius) 
                pos.Y = radius;
        }

        public void Render(int width, int height)
        {
            bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            Update(width, height);
            Constraints(width, height);
            
        }

    }
}
