using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        int _length;
        int _width;
        string _color;       

        public int Length
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

        public int Width
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

        public string Color
        {
            get => _color;
            set
            {
                if (value == "Red" || value == "Blue" || value == "Yellow" || value == "Green"
                     || value == "Orange" || value == "Pink" || value == "Brown" || value == "Purple"
                      || value == "White" || value == "Black")
                    _color = value;
                else
                    throw new ArgumentException("Укажите цвет прямоугольника (цвет на английском)");
            }

        }

        public Rectangle()
        {

        }

        public Rectangle(int length, int width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
    }
}
