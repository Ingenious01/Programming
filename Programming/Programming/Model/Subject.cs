using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию об учебной дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Название дисциплины.
        /// </summary>
        string _name;

        /// <summary>
        /// Преподователь.
        /// </summary>
        string _teacher;

        /// <summary>
        /// Оценка
        /// </summary>
        int _mark;

        /// <summary>
        /// Возвращает и задает название дисциплины.
        /// </summary>
        private string Name
        {
            get => _name;
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentException("Укажите название предмета");
            }

        }

        /// <summary>
        /// Возвращает и задаёт преподователя.
        /// </summary>
        private string Teacher
        {
            get => _teacher;
            set
            {
                if (value != null)
                    _teacher = value;
                else
                    throw new ArgumentException("Укажите имя преподователя");
            }

        }

        /// <summary>
        /// Возвращает и задаёт оценку по диспциплине.
        /// </summary>
        private int Mark
        {
            get => _mark;
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 1, 5);                
                
                _mark = value;
            }

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/> без инициализации полей.
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="mark">Оценка.</param>
        /// <param name="teacher">Преподователь.</param>
        public Subject(string name, string teacher, int mark)
        {
            Name = name;
            Teacher = teacher;
            Mark = mark;
        }
    }
}
