using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        string _name;
        int _duration;
        int _year;
        string _genre;
        double _rating;

        public string Name
        {
            get => _name;
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentException("Введите название фильма");
            }

        }

        public int Duration
        {
            get => _duration;
            set
            {
                if (value > 0 && value <= 600)
                    _duration = value;
                else
                    throw new ArgumentException("Введите время продождительности фильма(от 1 до 600)");
            }

        }

        public int Year
        {
            get => _year;
            set
            {
                if (value >= 1850 && value <= 2023)
                    _year = value;
                else
                    throw new ArgumentException("Введите корректный год релиза фильма");
            }

        }

        public string Genre
        {
            get => _genre;
            set
            {
                if (value != null )
                    _genre = value;
                else
                    throw new ArgumentException("Введите корректный жанр фильма");
            }

        }

        public double Rating
        {
            get => _rating;
            set
            {
                if (value >= 0 && value <= 10)
                    _rating = value;
                else
                    throw new ArgumentException("Укажите рейтинг фильма");
            }

        }

        public Film()
        {

        }

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
