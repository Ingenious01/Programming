using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.Model
{
    public class Film
    {
                
        private int _duration;
        private int _year;        
        private double _rating;

        public string Name { get; set; }

        public int Duration
        {
            get => _duration;
            set
            {
                string method = "FilmDuration";

                bool check = Validator.AssertOnPositiveValue(method, value);

                if (check == true)
                    _duration = value;
            }

        }

        public int Year
        {
            get => _year;
            set
            {
                string method = "FilmYear";

                bool check = Validator.AssertValueInRange(method, value, 1900, 2023);

                if (check == true)
                    _year = value;
            }

        }

        public string Genre { get; set; }


        public double Rating
        {
            get => _rating;
            set
            {
                string method = "FilmRating";

                bool check = Validator.AssertValueInRange(method, value, 0.000001, 10);

                if (check == true)
                    _rating = value;
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
