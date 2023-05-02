using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class CollisionManager
    {
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double dx = Math.Max(rectangle1.Centre.X, rectangle2.Centre.X) 
                - Math.Min(rectangle1.Centre.X, rectangle2.Centre.X);   

            double dy = Math.Max(rectangle1.Centre.Y, rectangle2.Centre.Y)
                - Math.Min(rectangle1.Centre.Y, rectangle2.Centre.Y);

            double Xlength = (rectangle1.Length - rectangle2.Length)/2;
            Math.Abs(Xlength);

            double Ywidth = (rectangle1.Width - rectangle2.Width)/ 2;
            Math.Abs(Ywidth);

            return ((dx < Xlength) && (dy < Ywidth));
        }

        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double radiuses = ring1.OutRadius + ring2.OutRadius;

            double dx = Math.Max(ring1.Centre.X, ring2.Centre.X)
               - Math.Min(ring1.Centre.X, ring2.Centre.X);

            double dy = Math.Max(ring1.Centre.Y, ring2.Centre.Y)
                - Math.Min(ring1.Centre.Y, ring2.Centre.Y);

            double C = Math.Sqrt((dx*dx)+(dy*dy));

            return (C < radiuses);
        }
    }
}
