using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    public class Ring
    {

        private Point2D _center;
        private double _inRadius;
        private double _outRadius;
        private double _area;

        public double InRadius
        {
            get => _inRadius;
            set
            {
                Validator.AssertOnPositiveValue(nameof(InRadius), value);


                if (value < _outRadius)
                {
                    _inRadius = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Внутренний радиус не может быть больше внешнего "));
                }
            }
        }

        public double OutRadius
        {
            get => _outRadius;
            set
            {
                Validator.AssertOnPositiveValue(nameof(OutRadius), value);

                if (value < _inRadius)
                {
                    _outRadius = value;
                }
                else
                {
                    throw new ArgumentException(string.Format("Внешний радиус не может быть меньне внутреннего"));
                }
            }

        }

        public Point2D Center { get; set; }

        public double Area
        {
            get => Validator.CalculateArea(_inRadius, _outRadius);
        }

        public Ring()
        {

        }

        public Ring(double inRadius, double outRadius, Point2D center)
        {
            Center = center;
            InRadius = inRadius;
            OutRadius = outRadius;
        }
    }
}

