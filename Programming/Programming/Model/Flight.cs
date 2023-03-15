using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Flight
    {
        string _start_point;
        string _end_point;
        int _time;

        public string Start
        {
            get => _start_point;
            set
            {
                if (value != null)
                    _start_point = value;
                else
                    throw new ArgumentException("Укажите точку начала полёта");
            }

        }

        public string End
        {
            get => _end_point;
            set
            {
                if (value != null)
                    _end_point = value;
                else
                    throw new ArgumentException("Укажите точку концпа полёта");
            }

        }

        public int Time
        {
            get => _time;
            set
            {
                if (value >= 0)
                    _time = value;
                else
                    throw new ArgumentException("Укажите аргумент (больше 0)");
            }

        }

        public Flight()
        {

        }

        public Flight(string start, string end, int time)
        {
            Start = start;
            End = end;
            Time = time;
        }
    }
}
