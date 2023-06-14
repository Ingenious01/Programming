using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8lab.Model.Enums
{
    /// <summary>
    /// Хранит данные о фильме.
     /// </summary>
    public class Movie
    {
        /// <summary>
        /// Создает экземпляр класса Movie.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationMinutes">Продолжительность фильма в минутах.</param>
        /// <param name="year">Год выхода.</param>
        /// <param name="genre">Жанр.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        public Movie(string title, int durationMinutes, int year, string genre, double rating)
        {
            Title = title;
            DurationMinutes = durationMinutes;
            Year = year;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах.
        /// </summary>
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Возвращает и задает год выхода.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает рейтинг фильма.
        /// </summary>
        public double Rating { get; set; }
    }
}
