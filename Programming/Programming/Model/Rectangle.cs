using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;

        public double Length
        {
            get => _length;
            set
            {
                if (value >= 0 )
                    _length = value;
                else
                    throw new ArgumentException("Укажите длинну прямоугольника (больше 0)");
            }

        }

        public double Width
        {
            get => _width;
            set
            {
                if (value >= 0 )
                    _width = value;
                else
                    throw new ArgumentException("Укажите ширину прямоугольника (больше 0)");
            }

        }
        public string Color { get; set; }

        public Rectangle()
        {

        }

        public Rectangle(float length, float width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}
