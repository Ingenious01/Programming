using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Реализует проверку на пересечение прямоугольников и кругов.
    /// </summary>
    internal class CollisionManager
    {
        /// <summary>
        /// Проверяет пересечение прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый экземпляр прямоугольника.</param>
        /// <param name="rectangle2">Второй экземпляр прямоугольника.</param>
        /// <returns>Если прямоугольники пересекаются, метод возвращает true, иначе возвращает false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            var width1 = rectangle1.Width;
            var width2 = rectangle2.Width;            

            var firstx = rectangle1.Center.X;
            var secondx = rectangle2.Center.X;

            bool widthCheck;
            
            if (firstx < secondx)
            {
                widthCheck = (Math.Abs(rectangle1.Center.X - rectangle2.Center.X) <= width1);
            }
            else
            {
                widthCheck = (Math.Abs(rectangle1.Center.X - rectangle2.Center.X) <= width2);
            }

            var length1 = rectangle1.Length;
            var length2 = rectangle2.Length;

            var firsty = rectangle1.Center.Y;
            var secondy = rectangle2.Center.Y;

            bool lengthCheck;

            if (firsty < secondy)
            {
                lengthCheck = (Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) <= length1);
            }
            else
            {
                lengthCheck = (Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) <= length2);
            }

            return widthCheck && lengthCheck ;
        }

        /// <summary>
        /// Проверяет пересечение кругов.
        /// </summary>
        /// <param name="ring1"> Первый экземпляр круга.</param>
        /// <param name="ring2">Второй экземпляр круга.</param>
        /// <returns>Если круги пересекаются, метод возвращает true, иначе возвращает false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            var radius1 = ring1.OutRadius;
            var radius2 = ring2.OutRadius;

            var dX = Math.Abs(ring1.Center.X - ring2.Center.X);
            var dY = Math.Abs(ring1.Center.Y - ring2.Center.Y);

            var c = Math.Sqrt(Math.Pow(dX, 2) + Math.Pow(dY, 2));

            return c < radius1 + radius2;
        }
    }
}
