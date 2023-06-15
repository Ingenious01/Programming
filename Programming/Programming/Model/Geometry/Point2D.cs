using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Создает точку в двумерном пространстве.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// X координата.
        /// </summary>
        private double _x;

        /// <summary>
        /// Y координата.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задает X координату. Должна быть положительным числом.
        /// </summary>
        public double X
        {
            get => _x;
            private set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);

                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Y координату. Должна быть положительным числом.
        /// </summary>
        public double Y
        {
            get => _y;
            private set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);

                _y = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса.<see cref="Point2D"/>
        /// </summary>
        /// <param name="x">X координата. Должна быть только положительным числом.</param>
        /// <param name="y">Y координата. Должна быть только положительным числом.</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

    }

}
