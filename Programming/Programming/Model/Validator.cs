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

        public static void AssertOnPositiveValue(string method, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));                
            }
           
        }

        public static void AssertOnPositiveValue(string method, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
           
        }

        //----------------------------------------------AssertValueInRange--------------------------------------------//

        public static void AssertValueInRange(string method, int value, int min, int max)
        {
            if (!(value >= min && value <= max))            
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
        }

        public static void AssertValueInRange(string method, double value, double min, double max)
        {
            if (!(value >= min && value <= max))            
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));
            }
        }

        //-------------------------------------------------Area---------------------------------------------------------//
        public static double CalculateArea(double InternalRadius, double OuterRadius)
        {
            double OuterArea = Math.PI * (OuterRadius * OuterRadius);
            double InnerArea = Math.PI * (InternalRadius * InternalRadius);
            double result = OuterArea - InnerArea;
            return result;
        }

        //--------------------------------------------------------------------------------------------------------------//

        public static bool AssertStringContainsOnlyLetters(string value)
        {
            return !string.IsNullOrEmpty(value) && !Regex.IsMatch(value, @"^[a-zA-z]+$");
        }
    }
}
