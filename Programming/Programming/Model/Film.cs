using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о фильме.
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Продолжительность фильма.
        /// </summary>        
        private int _duration;

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        private int _year;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма.
        /// </summary>
        public int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                
                _duration = value;
            }

        }

        /// <summary>
        /// Возвращает и задаёт год выпуска фильма. Он должен быть со значением от 1900 до 2023.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(nameof(Year), value, 1900, 2023);
                
                _year = value;
            }

        }

        /// <summary>
        /// Возвращает и задаёт жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма. Он должен быть со значением от 0 до 10.
        /// </summary>
        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0.01, 10);
                
                _rating = value;
            }

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/> без инициализации полей.
        /// </summary>
        public Film()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="duration">Длительность</param>
        /// <param name="year">Год создания</param>
        /// <param name="genre">Жанр</param>
        /// <param name="rating">Рейтинг</param>
        public Film(string name, int duration, int year, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
    }
}
