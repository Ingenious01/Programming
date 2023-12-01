using Programming.Model;
using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movie = Programming.Model.Movie;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса MoviesFinderControl.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Все перечисления.
        /// </summary>
        object[] enums = new object[]
        {
            typeof(Model.Enums.Color),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };

        /// <summary>
        /// Массив из 5 фильмов.
        /// </summary>
        private Movie[] _movies = new Movie[5];

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Экземпляр класса Random.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Создаёт список из 5 фильмов
        /// </summary>
        string[] listMovies = new string[]
        {
            "Film 1",
            "Film 2",
            "Film 3",
            "Film 4",
            "Film 5"
        };

        /// <summary>
        /// Создаёт экземпляр класса MoviesFinderControl.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            FillMovies();

            MoviesListBox.DataSource = listMovies;
            MoviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполняет массив фильмов пятью экземплярами класса <see cref="Movie"/>.
        /// </summary>        
        private void FillMovies()
        {
            var genreValues = Enum.GetValues((Type)enums[2]);
            for (int i = 0; i < 5; i++)
            {
                string number = Convert.ToString(i + 1);
                string name = "Film " + number;
                int duration = _random.Next(1, 601);
                int year = _random.Next(1900, 2023);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                double rating = _random.NextDouble() * (10 - 0.1) + 0.1;
                _movies[i] = new Movie(name, duration, year, genre, rating);
            }
        }

        /// <summary>
        /// При изменении выбранного фильма в списке фильмов меняются характеристики на новые значения.
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.DataSource != null)
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
                NameBox.Text = _currentMovie.Name;
                DurationBox.Text = _currentMovie.Duration.ToString();
                YearBox.Text = _currentMovie.Year.ToString();
                GenreBox.Text = _currentMovie.Genre;
                RatingBox.Text = _currentMovie.Rating.ToString();
            }
        }

        /// <summary>
        /// При изменении названия выбранного фильма запоминает новое значение.
        /// </summary>
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = NameBox.Text;
            _movies[MoviesListBox.SelectedIndex].Name = NameBox.Text;
            listMovies[MoviesListBox.SelectedIndex] = NameBox.Text;
            MoviesListBox.DataSource = null;
            MoviesListBox.DataSource = listMovies;
        }

        /// <summary>
        /// При изменении длительности выбранного фильма запоминает новое значение.
        /// </summary>
        private void DurationBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Duration = Convert.ToInt32(DurationBox.Text);
            }
            catch
            {
                DurationBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// При изменении года выпуска выбранного фильма запоминает новое значение.
        /// </summary>
        private void YearBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Year = Convert.ToInt32(YearBox.Text);
            }
            catch
            {
                YearBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// При изменении рейтинга выбранного фильма запоминает новое значение.
        /// </summary>
        private void RatingBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingBox.BackColor = System.Drawing.Color.White;
                _currentMovie.Rating = Convert.ToDouble(RatingBox.Text);
            }
            catch
            {
                RatingBox.BackColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// При изменении жанра выбранного фильма запоминает новое значение.
        /// </summary>
        private void GenreBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreBox.Text;
        }

        /// <summary>
        /// Выбирает фильм с наибольшим рейтингом в списке фильмов по нажатию кнопки find.
        /// </summary>
        private void FilmMovieButton_Click(object sender, EventArgs e)
        {
            FindMovieWithMaxRating();
        }

        /// <summary>
        /// Определяет фильм с наибольшим рейтингом.
        /// </summary> 
        public void FindMovieWithMaxRating()
        {
            int index = 0;
            double maxRating = 0;
            for (int i = 0; i < _movies.Length; i++)
            {
                if (_movies[i].Rating > maxRating)
                {
                    maxRating = _movies[i].Rating;
                    index = i;
                }
                MoviesListBox.SelectedIndex = index;
            }
        }
    }
}
