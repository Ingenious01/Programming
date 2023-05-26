using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programming.Model.Geometry
{
    public class Rectangle
    {

        private static int _allRectanglesCount = 1;
        private double _length;
        private double _width;
        private string _color;
        private Point2D _center;
        private int _id;

        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set => _allRectanglesCount = value;
        }

        public double Length
        {
            get => _length;
            set
            {

                Validator.AssertOnPositiveValue(nameof(Length), value);

                _length = value;
            }

        }

        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);

                _width = value;
            }

        }
        public string Color { get; set; }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public Point2D Center { get; set; }


        public Rectangle()
        {

        }

        public Rectangle(float length, float width, string color, Point2D center)
        {
            Id = AllRectanglesCount;
            AllRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }
    }
}
