using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        private int Hours
        {
            get => _hours;
            set 
            {
                string method = "Hours";

                bool check = Validator.AssertValueInRange(method, value, 0, 23);

                if (check == true)
                    _hours = value;
            }

        }

        private int Minutes
        {
            get => _minutes;
            set
            {
                string method = "Minutes";

                bool check = Validator.AssertValueInRange(method, value, 0, 59);

                if (check == true)
                    _minutes = value;
            }

        }

        private int Seconds
        {
            get => _seconds;
            set
            {
                string method = "Seconds";

                bool check = Validator.AssertValueInRange(method, value, 0, 59);

                if (check == true)
                    _seconds = value;
            }

        }

        public Time() 
        { 
        
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;            
        }
    }
}
