using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlet
{
    public class Vec2
    {
        public float X, Y;
        public Vec2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vec2 operator -(Vec2 v)
        {
            return new Vec2(-v.X, -v.Y);
        }

        public static Vec2 operator +(Vec2 a, Vec2 b)
        {
            return new Vec2(a.X+b.X, a.Y+b.Y);
        }

        public static Vec2 operator -(Vec2 a, Vec2 b)
        {
            return new Vec2(a.X - b.X, a.Y - b.Y);
        }

        public static Vec2 operator *(float a,Vec2 v)
        {
            return new Vec2(a*v.X, a*v.Y);
        }

        public static Vec2 operator *(Vec2 v, float a)
        {
            return new Vec2(a*v.X, a*v.Y);
        }

        public static Vec2 operator /(Vec2 v, float a)
        {
            return new Vec2(v.X/a, v.Y/a);
        }

        public float MagSqrt()
        {
            return (X * X) + (Y * Y);
        }

        public float Length()
        {
            return MathF.Sqrt((X * X) + (Y * Y));
        }

        public float Distance(Vec2 v)
        {
            return MathF.Sqrt(MathF.Pow(X-v.X, 2)+MathF.Pow(Y-v.Y, 2));
        }


    }
}
