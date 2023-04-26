using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programming.Model
{
    public class Rectangle
    {

        Validator validator = new Validator();

        private double _length;
        private double _width;
        private string _color;
        private Point2D _centre;

        public double Length
        {
            get => _length;
            set
            {
               
                string method = "Length";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true)
                        _length = value;
                
            }

        }

        public double Width
        {
            get => _width;
            set
            {
                string method = "Width";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true)
                    _width = value;
            }

        }
        public string Color { get; set; }

        public Point2D Centre { get;set; }
        

        public Rectangle()
        {

        }

        public Rectangle(float length, float width, string color, Point2D centre)
        {
            Length = length;
            Width = width;
            Color = color;            
            Centre = centre;
        }
    }
}
