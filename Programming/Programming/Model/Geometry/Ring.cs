using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Описывает геометрическое кольцо.
    /// </summary>
    public class Ring
    {
        /// <summary>
        /// Центр координат прямоугольника.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _inRadius;

        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outRadius;

        /// <summary>
        /// Площадь внутренности кольца
        /// </summary>
        private double _area;

        /// <summary>
        /// Возвращает и задаёт внутренний радиус. Должен быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт внешний радиус. Должен быть положительным числом.
        /// </summary>
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

        /// <summary>
        /// Центр координат прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get => Validator.CalculateArea(_inRadius, _outRadius);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Ring"/> без инициализации полей.
        /// </summary>
        public Ring()
        {

        }

        /// <summary>
        /// Создаёт геометрическое кольцо.
        /// </summary>
        /// <param name="outRadius">Внешний радус. Должен быть положительным числом.</param>
        /// <param name="inRadius">Внутренний радуис. Должен быть положительным числом.</param>
        /// <param name="center">Центр координат прямоугольника.</param>
        public Ring(double inRadius, double outRadius, Point2D center)
        {
            Center = center;
            InRadius = inRadius;
            OutRadius = outRadius;
        }
    }
}

