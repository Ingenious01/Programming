using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о текущем времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задаёт часы. Должны быть со значением от 0 до 23.
        /// </summary>
        private int Hours
        {
            get => _hours;
            set 
            {
                Validator.AssertValueInRange(nameof(Hours), value, 0, 23);

                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт минуты. Должны быть со значением от 0 до 60.
        /// </summary>
        private int Minutes
        {
            get => _minutes;
            set
            {
                Validator.AssertValueInRange(nameof(Minutes), value, 0, 59);

                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт секунды. Должны быть со значением от 0 до 60.
        /// </summary>
        private int Seconds
        {
            get => _seconds;
            set
            {
                Validator.AssertValueInRange(nameof(Seconds), value, 0, 59);

                _seconds = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/> без инициализации полей.
        /// </summary>
        public Time() 
        { 
        
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours">Часы.</param>
        /// <param name="minutes">Минуты.</param>
        /// <param name="seconds">Секунды.</param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;            
        }
    }
}
