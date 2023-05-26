using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    internal class RectangleFactory
    {
        private Random _random = new Random();
        public  Rectangle Randomize()
        {
            Rectangle fill = new Rectangle(); 

            int length = _random.Next(1, 30);
            int width = _random.Next(1, 30);            
            Point2D centre = new Point2D(_random.Next(0, 201), _random.Next(0, 201));
            fill = new Rectangle(length, width, centre);

            return fill;
        }
    }
}
