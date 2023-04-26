using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public double X
        {
            get => _x;
            private set 
            {
                string method = "X";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true) _x = value;            
            }
        }

        public double Y
        {
            get => _y;
            private set
            {
                string method = "Y";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true) _y = value;
            }
        }        

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

    }

}
