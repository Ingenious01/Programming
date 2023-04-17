using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Flight
    {
        string _startPoint;
        string _endPoint;
        int _duration;

        private string Start
        {
            get => _startPoint;
            set
            {
                if (value != null)
                    _startPoint = value;
                else
                    throw new ArgumentException("Укажите точку начала полёта");
            }

        }

        private string End
        {
            get => _endPoint;
            set
            {
                if (value != null)
                    _endPoint = value;
                else
                    throw new ArgumentException("Укажите точку концпа полёта");
            }

        }

        private int Duration
        {
            get => _duration;
            set
            {
                string method = "FlightDuration";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true)
                    _duration = value;
            }

        }

        public Flight()
        {

        }

        public Flight(string start, string end, int duration)
        {
            Start = start;
            End = end;
            Duration = duration;
        }
    }
}
