using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о полёте.
    /// </summary>
    public class Flight
    {
        /// <summary>
        /// Пункт вылета
        /// </summary>
        string _startPoint;

        /// <summary>
        /// Пункт назначения
        /// </summary>
        string _endPoint;

        /// <summary>
        /// Продолжительность полёта(в минутах)
        /// </summary>
        int _duration;

        /// <summary>
        /// Возвращает и задаёт пункт вылета.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт место назначения.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт время полёта.
        /// </summary>
        private int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                
                _duration = value;
            }

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/> без инициализации полей.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="start">Пункт вылета.</param>
        /// <param name="end">Место назначения.</param>
        /// <param name="duration">Время полёта.</param>
        public Flight(string start, string end, int duration)
        {
            Start = start;
            End = end;
            Duration = duration;
        }
    }
}
