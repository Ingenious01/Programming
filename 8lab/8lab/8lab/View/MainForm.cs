using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8lab
{
    /// <summary>
    /// Создает главное окно.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        ///  Перечисление жанров.
        /// </summary>
        private object[] _genre = Enum.GetNames(typeof(Genre));

        /// <summary>
        /// Список фильмов.
        /// </summary>
        private List<Movie> _movies;


        /// <summary>
        /// Список информаций по фильмам.
        /// </summary>
        private List<string> _infoMovies = new List<string>();

        /// <summary>
        /// Текущий выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Флаг для смены события AcceptButton. Если он == true добавляем фильм, иначе редактируем.
        /// </summary>
        private bool _flagButton;

        /// <summary>
        /// Создает экземпляр класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            DataBase.IsCreateFolderAndFile();
            _movies = DataBase.GetData();

            if (_movies.Count > 0)
            {
                SortedMoviesAdd();
            }

            genreComboBox.Items.AddRange(_genre);
        }

        /// <summary>
        /// Выбор элемента в moviesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledAcceptButton();
            if (moviesListBox.SelectedIndex == -1)
            {
                deleteButton.Enabled = false;
                editButton.Enabled = false;
            }
            else
            {
                _currentMovie = _movies[moviesListBox.SelectedIndex];
                editButton.Enabled = true;
                deleteButton.Enabled = true;
                FillInfo();
            }
        }

        /// <summary>
        /// Заполнение textbox.
        /// </summary>
        private void FillInfo()
        {
            titleTextBox.Text = _currentMovie.Title;
            yearTextBox.Text = _currentMovie.Year.ToString();
            genreComboBox.Text = _currentMovie.Genre;
            ratingTextBox.Text = _currentMovie.Rating.ToString();
            durationTextBox.Text = _currentMovie.DurationMinutes.ToString();
        }

        /// <summary>
        /// Событие добавления фильма.
        /// </summary>
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            moviesListBox.SelectedIndex = -1;
            _flagButton = true;
            DisableButtonsClicks();
            EnableVisibleButtons();
            EnableElements();
            ClearTextBox();

            titleTextBox.BackColor = Color.Red;
            yearTextBox.BackColor = Color.Red;
            ratingTextBox.BackColor = Color.Red;
            durationTextBox.BackColor = Color.Red;
            acceptButton.Enabled = false;
        }


        /// <summary>
        /// Сортировка по алфавиту add.
        /// </summary>
        private void SortedMoviesAdd()
        {
            _movies.Sort(delegate (Movie movie, Movie movie1)
            {
                return movie.Title.CompareTo(movie1.Title);
            });

            for (int i = 0; i < _movies.Count; i++)
            {
                _infoMovies.Add($"{_movies[i].Title} / {_movies[i].Year} / {_movies[i].Genre}");
                moviesListBox.Items.Add($"{_movies[i].Title} / {_movies[i].Year} / {_movies[i].Genre}");
            }
        }

        /// <summary>
        /// Сортировка по алфавиту delete.
        /// </summary>
        private void SortedMoviesDelete()
        {
            _infoMovies.Clear();
            moviesListBox.Items.Clear();
        }

        /// <summary>
        /// Добавление фильма.
        /// </summary>
        private void AddMovieButtonAccept()
        {
            SortedMoviesDelete();
            Movie newMovie = new Movie(titleTextBox.Text, Convert.ToInt32(durationTextBox.Text),
                Convert.ToInt32(yearTextBox.Text), genreComboBox.Text, Convert.ToDouble(ratingTextBox.Text));

            _movies.Insert(0, newMovie);

            SortedMoviesAdd();

            DataBase.UpdateData(_movies);


            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();
            moviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Событие изменения фильма.
        /// </summary>
        private void EditMovieButton_Click(object sender, EventArgs e)
        {
            _flagButton = false;
            DisableButtonsClicks();
            EnableVisibleButtons();
            EnableElements();
        }

        /// <summary>
        /// Изменения фильма.
        /// </summary>
        private void EditMovieButtonAccept()
        {
            Movie newMovie = new Movie(titleTextBox.Text, Convert.ToInt32(durationTextBox.Text),
                Convert.ToInt32(yearTextBox.Text), genreComboBox.Text, Convert.ToDouble(ratingTextBox.Text));

            _movies.RemoveAt(moviesListBox.SelectedIndex);
            SortedMoviesDelete();
            _movies.Add(newMovie);

            SortedMoviesAdd();

            DataBase.UpdateData(_movies);

            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();
            moviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Событие принятия добавления или редактирования фильма.
        /// </summary>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (_flagButton)
            {
                AddMovieButtonAccept();
            }
            else
            {
                EditMovieButtonAccept();
            }
        }

        /// <summary>
        /// Событие отмены добавления или редактирования фильма.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            EnableButtonsClicks();
            DisableElements();
            DisableVisibleButtons();

            if (moviesListBox.SelectedIndex == -1)
            {
                deleteButton.Enabled = false;
                ClearTextBox();
            }
            else
            {
                FillInfo();
            }
        }

        /// <summary>
        /// Событие удаления фильма.
        /// </summary>
        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            _movies.RemoveAt(moviesListBox.SelectedIndex);
            _infoMovies.RemoveAt(moviesListBox.SelectedIndex);
            moviesListBox.Items.RemoveAt(moviesListBox.SelectedIndex);
            DataBase.UpdateData(_movies);
            ClearTextBox();
        }

        /// <summary>
        /// Включение всех элементов в groupBox.
        /// </summary>
        private void EnableElements()
        {
            moviesListBox.Enabled = false;
            titleTextBox.Enabled = true;
            ratingTextBox.Enabled = true;
            genreComboBox.Enabled = true;
            yearTextBox.Enabled = true;
            durationTextBox.Enabled = true;
        }

        /// <summary>
        /// Отключение всех элементов groupBox.
        /// </summary>
        private void DisableElements()
        {
            moviesListBox.Enabled = true;
            titleTextBox.Enabled = false;
            ratingTextBox.Enabled = false;
            genreComboBox.Enabled = false;
            yearTextBox.Enabled = false;
            durationTextBox.Enabled = false;
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        private void ClearTextBox()
        {
            titleTextBox.Text = "";
            ratingTextBox.Text = "";
            genreComboBox.Text = "";
            yearTextBox.Text = "";
            durationTextBox.Text = "";

            titleTextBox.BackColor = Color.White;
            ratingTextBox.BackColor = Color.White;
            yearTextBox.BackColor = Color.White;
            durationTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Включение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void EnableVisibleButtons()
        {
            cancelButton.Visible = true;
            acceptButton.Visible = true;
        }

        /// <summary>
        /// Отключение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void DisableVisibleButtons()
        {
            cancelButton.Visible = false;
            acceptButton.Visible = false;
        }

        /// <summary>
        /// Включение нажатий кнопок addButton и deleteButton.
        /// </summary>
        private void EnableButtonsClicks()
        {
            addButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        /// <summary>
        /// Отключение нажатий кнопок addButton и deleteButton.
        /// </summary>
        private void DisableButtonsClicks()
        {
            addButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        /// <summary>
        /// Событие изменения titleTextBox.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (titleTextBox.Text.Length > 100 || titleTextBox.Text.Length == 0)
            {
                acceptButton.Enabled = false;
                titleTextBox.BackColor = Color.Red;
            }
            else
            {
                titleTextBox.BackColor = Color.White;
            }
            EnabledAcceptButton();
        }

        /// <summary>
        /// Событие изменения yearTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var year = Convert.ToInt32(yearTextBox.Text);
                if (year < 0)
                {
                    acceptButton.Enabled = false;
                    yearTextBox.BackColor = Color.Red;
                }
                else
                {
                    yearTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                acceptButton.Enabled = false;
                yearTextBox.BackColor = Color.Red;
            }
            EnabledAcceptButton();
        }

        /// <summary>
        /// Событие изменения ratingTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var rating = Convert.ToDouble(ratingTextBox.Text);
                if (rating < 0 || rating > 10)
                {
                    acceptButton.Enabled = false;
                    ratingTextBox.BackColor = Color.Red;
                }
                else
                {
                    ratingTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                acceptButton.Enabled = false;
                ratingTextBox.BackColor = Color.Red;
            }
            EnabledAcceptButton();
        }

        /// <summary>
        /// Событие изменения durationTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var duration = Convert.ToInt32(durationTextBox.Text);
                if (duration < 1 || duration > 300)
                {
                    acceptButton.Enabled = false;
                    durationTextBox.BackColor = Color.Red;
                }
                else
                {
                    durationTextBox.BackColor = Color.White;
                }
            }
            catch
            {
                acceptButton.Enabled = false;
                durationTextBox.BackColor = Color.Red;
            }
            EnabledAcceptButton();
        }

        /// <summary>
        /// Включение acceptButton.
        /// </summary>
        private void EnabledAcceptButton()
        {
            var title = titleTextBox.BackColor == Color.White;
            var rating = ratingTextBox.BackColor == Color.White;
            var duration = durationTextBox.BackColor == Color.White;
            var year = yearTextBox.BackColor == Color.White;
            if (title && rating && duration && year)
            {
                acceptButton.Enabled = true;
            }
        }

        /// <summary>
        /// Событие вызова toolTip для TitleTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_MouseHover(object sender, EventArgs e)
        {
            titleToolTip.SetToolTip(titleTextBox, "Длина строки меньше 100");

        }

        /// <summary>
        /// Событие вызова toolTip для YearTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YearTextBox_MouseHover(object sender, EventArgs e)
        {
            yearToolTip.SetToolTip(yearTextBox, "Больше 0");
        }

        /// <summary>
        /// Событие вызова toolTip для RatingTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatingTextBox_MouseHover(object sender, EventArgs e)
        {
            ratingToolTip.SetToolTip(ratingTextBox, "От 1 до 10");
        }

        /// <summary>
        /// Событие вызова toolTip для DurationTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DurationTextBox_MouseHover(object sender, EventArgs e)
        {
            durationToolTip.SetToolTip(durationTextBox, "От 1 до 300");
        }
    }
}
