using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Validator
    {
        public static bool AssertOnPositiveValue(string method, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(String.Format("В методе {0} вводимое число должно быть больше 0 ", method));                
            }
            else return true;
        }
    }
}
