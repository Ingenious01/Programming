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
        
        private int _duration;
        private int _year;
        private string _genre;
        private double _rating;        

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
                if (value >= 1900 && value <= 2023)
                    _year = value;
                else
                    throw new ArgumentException("Введите корректный год релиза фильма");
            }

        }

        public string Genre { get; set; }


        public double Rating
        {
            get => _rating;
            set
            {
                if (value > 0 && value <= 10)
                    _rating = value;
                else
                    throw new ArgumentException("Укажите рейтинг фильма");
            }

        }

        public Film()
        {

        }

        public Film(int duration, int year, string genre, double rating)
        {
            Duration = duration;
            Year = year;
            Genre = genre;
            Rating = rating;
        }
    }
}
