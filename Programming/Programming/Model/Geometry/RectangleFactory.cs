using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public static class RectangleFactory
    {       
        public static Rectangle Randomize(int maxXPosition,int maxYPosition)
        {
            var _random = new Random();
            var colors = Enum.GetNames(typeof(Enums.Color));
            var randomColor = colors[_random.Next(colors.Length)];

            var height = _random.Next(1, 200);
            var length = _random.Next(1, 200);

            var centreX=_random.Next(length / 2 + 15, maxXPosition - (length / 2) - 15);
            var centreY=_random.Next(height / 2 + 15, maxYPosition - (length / 2) - 15);

            return new Rectangle(height, length, randomColor, new Point2D(centreX, centreY));
        }   
    }
}
