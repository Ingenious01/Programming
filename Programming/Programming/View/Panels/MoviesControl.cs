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
using Film = Programming.Model.Film;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        object[] enums = new object[]
        {
            typeof(Model.Enums.Color),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };

        private Film[] _films = new Film[5];
        private Film _currentFilm;

        private Random _random = new Random();
        public MoviesControl()
        {
            InitializeComponent();

            FillFilms();

            var listFilms = new string[]
            {
                "Film 1",
                "Film 2",
                "Film 3",
                "Film 4",
                "Film 5"
            };

            FilmsListBox.DataSource = listFilms;
            FilmsListBox.SelectedIndex = 0;
        }

        private void FillFilms()
        {
            var genreValues = Enum.GetValues((Type)enums[2]);
            for (int i = 0; i < 5; i++)
            {
                string number = Convert.ToString(i + 1);
                string name = "Film " + number;
                int duration = _random.Next(1, 601);
                int year = _random.Next(1900, 2023);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                double rating = Math.Round(_random.Next(1, 11) * _random.NextDouble(), 1);
                _films[i] = new Model.Film(name, duration, year, genre, rating);
            }
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];
            NameBox.Text = _films[FilmsListBox.SelectedIndex].Name;
            DurationBox.Text = _films[FilmsListBox.SelectedIndex].Duration.ToString();
            YearBox.Text = _films[FilmsListBox.SelectedIndex].Year.ToString();
            GenreBox.Text = _films[FilmsListBox.SelectedIndex].Genre;
            RatingBox.Text = _films[FilmsListBox.SelectedIndex].Rating.ToString();

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = NameBox.Text;
        }

        private void DurationBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Duration = Convert.ToInt32(DurationBox.Text);
            }
            catch
            {
                DurationBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void YearBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Year = Convert.ToInt32(YearBox.Text);
            }
            catch
            {
                YearBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void RatingBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Rating = Convert.ToDouble(RatingBox.Text);
            }
            catch
            {
                RatingBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void GenreBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreBox.Text;
        }

        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            FindFilmWithMaxRating();
        }

        public void FindFilmWithMaxRating()
        {
            int index = 0;
            double maxRating = 0;
            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i].Rating > maxRating)
                {
                    maxRating = _films[i].Rating;
                    index = i;
                }
                FilmsListBox.SelectedIndex = index;
            }

        }
    }
}
