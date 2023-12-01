using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Название песни
        /// </summary>
        string _name;

        /// <summary>
        /// Длительность песни в минутах
        /// </summary>
        int _duration;

        /// <summary>
        /// Жанр
        /// </summary>
        string _genre;

        /// <summary>
        /// Автор песни.
        /// </summary>
        string _singer;

        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт длительность песни.
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
        /// Возвращает и задаёт жанр песни.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт автора песни.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/> без инициализации полей.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="singer">Автор.</param>
        /// <param name="name">Название.</param>
        /// <param name="duration">Длительность.</param>
        /// <param name="genre">Жанр.</param>
        public Song(string name, int duration, string genre, string singer)
        {
            Name = name;
            Duration = duration;
            Genre = genre;
            Singer = singer;
        }
    }
}
