using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    static class ValueValidator
    {
        /// <summary>
        /// Метод, проверяющий, не превышает ли длина строки заданное число.
        /// </summary>
        /// <param name="value">Строка</param>
        /// <param name="maxLength">Максимальная длинна строки</param>
        /// <param name=propertyName">Название параметра класса</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {

            if ((value.Length <= maxLength) && (value != string.Empty) && (value.Length > 3))
            { }
            else
            { throw new ArgumentException(String.Format("{0} должен быть меньше {1} символов ", propertyName, maxLength)); }

        }

        /// <summary>
        /// Метод, проверяющий, правильно ли введено имя.
        /// </summary>
        /// <param name="value">Строка</param>        
        /// <param name="propertyName">Название параметра класса</param>
        public static void AssertNameStringOnSymbols(string value, string propertyName)
        {
            string pattern = ("^[a-zA-Z]+$");
            if ((value.Length > 3) && (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase)))
            { }
            else
            { throw new ArgumentException(String.Format("{0} должно состоять из одного слова, включать в себя только англмйские буквы ", propertyName)); }

        }

        /// <summary>
        /// Метод, проверяющий, правильно ли введены имя и фамилия.
        /// </summary>
        /// <param name="value">Строка</param>        
        /// <param name="propertyName">Название параметра класса</param>
        public static void AssertFullNameStringOnSymbols(string value, string propertyName)
        {
            string pattern = ("^[a-zA-Z]* [a-zA-Z]*$");
            if ((value.Length > 3) && (Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase)))
            { }
            else
            { throw new ArgumentException(String.Format("{0} должно состоять из двух слов и пробела, включать в себя только англмйские буквы ", propertyName)); }

        }
    }
}
