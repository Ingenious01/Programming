using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Validator
    {
        //----------------------------------------------AssertOnPositiveValue--------------------------------------------//

        public static bool AssertOnPositiveValue(string method, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));                
            }
            else return true;
        }

        public static bool AssertOnPositiveValue(string method, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
            else return true;
        }

        //----------------------------------------------AssertValueInRange--------------------------------------------//

        public static bool AssertValueInRange(string method, int value, int min, int max)
        {
            if (value >= min && value <= max) return true;
            else
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
        }

        public static bool AssertValueInRange(string method, double value, double min, double max)
        {
            if (value >= min && value <= max) return true;
            else
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
        }

        //-------------------------------------------------Area---------------------------------------------------------//
        public static double CalculateArea(double InnerRadius, double OuterRadius)
        {
            double OuterArea = Math.PI * (OuterRadius * OuterRadius);
            double InnerArea = Math.PI * (InnerRadius * InnerRadius);
            double result = OuterArea - InnerArea;
            return result;
        }
    }
}
