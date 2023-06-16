using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    static class Validator
    {
        //----------------------------------------------AssertOnPositiveValue--------------------------------------------//

        /// <summary>
        /// Проверяет число на положительность.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="method">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertOnPositiveValue(string method, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));                
            }
           
        }

        /// <summary>
        /// Проверяет число на положительность.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="method">Имя свойства или объекта, которое подлежит проверке.</param>
        public static void AssertOnPositiveValue(string method, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
           
        }

        //----------------------------------------------AssertValueInRange--------------------------------------------//

        /// <summary>
        /// Проверяет число на нахождение в значениях от min до max
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="method">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        public static void AssertValueInRange(string method, int value, int min, int max)
        {
            if (!(value >= min && value <= max))            
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
        }

        /// <summary>
        /// Проверяет число на нахождение в значениях от min до max
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="method">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        public static void AssertValueInRange(string method, double value, double min, double max)
        {
            if (!(value >= min && value <= max))            
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше {1} и меньше {2} ", method, min, max));
            }
        }

        //-------------------------------------------------Area---------------------------------------------------------//
        /// <summary>
        /// Считает площадь кольца
        /// </summary>
        /// <param name="InternalRadius">Внутренний радиус.</param>
        /// <param name="OuterRadius">Внешний радиус.</param>
        public static double CalculateArea(double InternalRadius, double OuterRadius)
        {
            double OuterArea = Math.PI * (OuterRadius * OuterRadius);
            double InnerArea = Math.PI * (InternalRadius * InternalRadius);
            double result = OuterArea - InnerArea;
            return result;
        }

        //--------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>            
        public static bool AssertStringContainsOnlyLetters(string value)
        {
            return !string.IsNullOrEmpty(value) && !Regex.IsMatch(value, @"^[a-zA-z]+$");
        }
    }
}
