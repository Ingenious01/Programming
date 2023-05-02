using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Song
    {
        string _name;
        int _duration;
        string _genre;
        string _singer;

        private string Name
        {
            get => _name;
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentException("Введите имя песни");
            }

        }

        private int Duration
        {
            get => _duration;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                
                _duration = value;
            }

        }

        private string Genre
        {
            get => _genre;
            set
            {
                if (value != null)
                    _genre = value;
                else
                    throw new ArgumentException("Укажите жанр песни");
            }

        }

        private string Singer
        {
            get => _singer;
            set
            {
                if (value != null)
                    _singer = value;
                else
                    throw new ArgumentException("Введите имя артиста");
            }

        }

        public Song()
        {

        }

        public Song(string name, int duration, string genre, string singer)
        {
            Name = name;
            Duration = duration;
            Genre = genre;
            Singer = singer;
        }
    }
}
