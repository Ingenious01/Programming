using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Ring
    {
        Validator validator = new Validator();

        private Point2D _centre;
        private double _inRadius;
        private double _outRadius; 
        private double _area;

        public double InRadius
        {
            get => _inRadius;
            set
            {

                string method = "Internal Radius";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true)
                {
                    if (value < _outRadius)
                    {
                        _inRadius = value;
                    }
                    else
                    {
                        throw new ArgumentException(String.Format("Внутренний радиус не может быть больше внешнего ", method));
                    }
                }
            }
        }

        public double OutRadius
        {
            get => _outRadius;
            set
            {
                string method = "Outher Radius";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true)
                {
                    if (value < _inRadius)
                    {
                        _outRadius = value;
                    }
                    else
                    {
                        throw new ArgumentException(String.Format("Внешний радиус не может быть меньне внутреннего", method));
                    }
                }
            }

        }       

        public Point2D Centre { get; set; }

        public double Area
        {
            get=> Validator.CalculateArea(_inRadius,_outRadius);           

        }


        public Ring()
        {

        }

        public Ring(double inRadius, double outRadius, Point2D centre)
        {
            Centre = centre;
            InRadius = inRadius;
            OutRadius = outRadius;            
        }
    }
}

