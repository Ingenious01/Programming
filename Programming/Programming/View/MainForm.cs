using Microsoft.VisualBasic.Devices;
using Programming.Model;
using System.Drawing;
using Rectangle = Programming.Model.Rectangle;
using Film = Programming.Model.Film;

namespace Programming
{
    public partial class MainForm : Form
    {
        object[] enums = new object[]
        {
            typeof(Color),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Manufactures),
            typeof(Season),
            typeof(Weekday)
        };

        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle;

        private Film[] _films = new Film[5];
        private Film _currentFilm;

        private Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();

            FillRectangles();
            FillFilms();
            

            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;      
            

            SeasonComboBox.Items.AddRange(new string[]  {Convert.ToString(Season.Autumn),
                                                         Convert.ToString(Season.Summer),
                                                         Convert.ToString(Season.Spring),
                                                         Convert.ToString(Season.Winter)});

            var listRectangles = new string[]
            {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4",
            "Rectangle 5"
            };

            RectanglesListBox.DataSource = listRectangles; 
            RectanglesListBox.SelectedIndex = 0;

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

        //-----------------------------------Rectangles-------------------------------------------\\
        private void FillRectangles()
        {
            var colorValues = Enum.GetValues((Type)enums[0]);
            for (int i = 0; i < 5; i++)
            {
                int length = _random.Next(1, 30);
                int width = _random.Next(1, 30);
                string color = colorValues.GetValue(_random.Next(0, 6)).ToString();
                _rectangles[i] = new Model.Rectangle(length, width, color);
            }
        }       

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Length.ToString();
            WidthBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Width.ToString();
            ColorBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Color;
            
        }

        private void LengthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LengthBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Length = Convert.ToDouble(LengthBox.Text);
            }
            catch
            {
                LengthBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Convert.ToDouble(WidthBox.Text);
            }
            catch
            {
                WidthBox.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ColorBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorBox.Text;
        }

        private void RectengleFindButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            double maxWidth = 0;
            for (int i = 0; i < _rectangles.Length; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    index = i;
                }
                RectanglesListBox.SelectedIndex = index;
            }           

        }

        //-----------------------------------Films-------------------------------------------\\

        private void FillFilms()
        {
            var genreValues = Enum.GetValues((Type)enums[2]);
            for (int i = 0; i < 5; i++)
            {
                int duration = _random.Next(1, 601);
                int year = _random.Next(1900, 2023);
                string genre = genreValues.GetValue(_random.Next(0, 6)).ToString();
                double rating = Math.Round(_random.Next(1,11) *_random.NextDouble(), 1);                
                _films[i] = new Model.Film(duration, year, genre, rating);
            }
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];
            DurationBox.Text = _films[FilmsListBox.SelectedIndex].Duration.ToString();
            YearBox.Text = _films[FilmsListBox.SelectedIndex].Year.ToString();
            GenreBox.Text = _films[FilmsListBox.SelectedIndex].Genre;
            RatingBox.Text = _films[FilmsListBox.SelectedIndex].Rating.ToString();

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

        //-------------------------------------Enums------------------------------------------\\

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }            

        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ValuesListBox.Items == null)
            {
                return;
            }

            else
            {
                ValuesTextBox.Text = ((int)Enum.Parse(Type.GetType(EnumsListBox.Text), ValuesListBox.Text)).ToString();
            }

        }      
       
        private void WeekDayParsingButton_Click(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(Weekday), ParsingTextBox.Text))
            {
                int num = (int)Enum.Parse(typeof(Weekday), ParsingTextBox.Text);
                ParsingResultLabel.Text = $"Это день недели ({ParsingTextBox.Text} = {num})";  
                
                ParsingResultLabel.Visible= true ;

            }

            else
            {
                ParsingResultLabel.Text = "Не такого дня недели";

                ParsingResultLabel.Visible = true;
            }
        }      

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    BackColor = ColorTranslator.FromHtml("#559c45"); ;
                    break;
                
                default:
                    MessageBox.Show("Выберите время года!");
                    break;

            }    
        }
       
    }
}
    
