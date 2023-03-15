using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get => _hours;
            set 
            {
                if (value >= 0 && value <= 23)
                    _hours = value;
                else
                    throw new ArgumentException("Укажите аргумент (от 0 до 23)");
            }

        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                if (value >= 0 && value <= 59)
                    _minutes = value;
                else
                    throw new ArgumentException("Укажите аргумент (от 0 до 59)");
            }

        }

        public int Seconds
        {
            get => _seconds;
            set
            {
                if (value >= 0 && value <= 59)
                    _seconds = value;
                else
                    throw new ArgumentException("Укажите аргумент (от 0 до 59)");
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
