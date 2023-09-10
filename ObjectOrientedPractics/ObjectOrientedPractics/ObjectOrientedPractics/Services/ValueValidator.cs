using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    static class ValueValidator
    {
        /// <summary>
        /// Метод, проверяющий, не превышает ли длина строки заданное число.
        /// </summary>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(String.Format("{0} должен быть меньше {1} символов ", propertyName, maxLength));
            }

        }
    }
}
