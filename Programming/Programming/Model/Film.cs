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
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                
                _duration = value;
            }

        }

        public int Year
        {
            get => _year;
            set
            {
                Validator.AssertValueInRange(nameof(Year), value, 1900, 2023);
                
                _year = value;
            }

        }

        public string Genre { get; set; }


        public double Rating
        {
            get => _rating;
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0.000001, 10);
                
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
