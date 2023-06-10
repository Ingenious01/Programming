using Microsoft.VisualBasic.Devices;
using System.Drawing;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Film = Programming.Model.Film;
using Color = Programming.Model.Enums.Color;
using System.Windows.Forms;
using System.Drawing.Text;
using Programming.Model.Enums;
using Programming.Model.Geometry;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private Rectangle[] _rectangles = new Rectangle[100];
        private Rectangle _currentRectangle;

        private Film[] _films = new Film[5];
        private Film _currentFilm;

        private Random _random = new Random();
        
        private List<Panel> _rectanglePanel = new List<Panel>();
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        private Rectangle _currentRectangleList;

        public MainForm()
        {
            InitializeComponent();

            FillRectangles();
            FillFilms();

            EnumsListBox.DisplayMember = nameof(Type.Name);
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

            RectanglesListBox.DataSource = listRectangles;
            RectanglesListBox.SelectedIndex = 0;         
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
                Point2D centre = new Point2D(_random.Next(0, 201), _random.Next(0, 201));
                _rectangles[i] = new Model.Geometry.Rectangle(length, width, color, centre);
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Length.ToString();
            WidthBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Width.ToString();
            ColorBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Color;
            XBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Center.X.ToString();
            YBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Center.Y.ToString();
            IdBox.Text = _rectangles[RectanglesListBox.SelectedIndex].Id.ToString();
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
            FindRectangleWithMaxWidth();
        }

        public void FindRectangleWithMaxWidth()
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

        //---------------------------------Geometry-----------------------------------------\\       
        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.Id}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Length})";

            return info;
        }

        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectanglesList[GeometryRectanglesListBox.SelectedIndex];

            GeometryRectanglesIdTextBox.Text = rectangle.Id.ToString();
            GeometryRectanglesXTextBox.Text = rectangle.Center.X.ToString();
            GeometryRectanglesYTextBox.Text = rectangle.Center.Y.ToString();
            GeometryRectanglesWidthTextBox.Text = rectangle.Width.ToString();
            GeometryRectanglesLengthTextBox.Text = rectangle.Length.ToString();
        }

        private void ClearRectangleInfo()
        {
            GeometryRectanglesIdTextBox.Text = " ";
            GeometryRectanglesXTextBox.Text = " ";
            GeometryRectanglesYTextBox.Text = " ";
            GeometryRectanglesWidthTextBox.Text = " ";
            GeometryRectanglesLengthTextBox.Text = " ";

            GeometryRectanglesXTextBox.BackColor = System.Drawing.Color.White;
            GeometryRectanglesYTextBox.BackColor = System.Drawing.Color.White;
            GeometryRectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
            GeometryRectanglesLengthTextBox.BackColor = System.Drawing.Color.White;
        }


        private void GeometryAddButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize(576, 635);
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);

            _rectanglesList.Add(rectangle);
            GeometryRectanglesListBox.Items.Add(info);

            panel.Height = Convert.ToInt32(rectangle.Length);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            _rectanglePanel.Add(panel);
            rectanglesPanel.Controls.Add(panel);
            FindCollision();
        }

        private void GeometryRemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _rectanglesList.RemoveAt(GeometryRectanglesListBox.SelectedIndex);
                _rectanglePanel.RemoveAt(GeometryRectanglesListBox.SelectedIndex);
                rectanglesPanel.Controls.RemoveAt(GeometryRectanglesListBox.SelectedIndex);
                GeometryRectanglesListBox.Items.RemoveAt(GeometryRectanglesListBox.SelectedIndex);
                FindCollision();
            }
            catch
            {
                
            }

        }

        private void GeometryRectanlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                UpdateRectangleInfo(ref _currentRectangleList);
            }
            catch
            {
                ClearRectangleInfo();
            }


        }

        private void FindCollision()
        {
            var colorRed = System.Drawing.Color.FromArgb(127, 255, 127, 127);
            var colorGreen = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            foreach (Panel rectangle in rectanglesPanel.Controls)
            {
                rectangle.BackColor = colorGreen;
            }

            for (int i = 0; i < _rectanglesList.Count; i++)
            {
                for (int j = 0; j < _rectanglesList.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]) && i != j)
                    {
                        _rectanglePanel[i].BackColor = colorRed;
                        _rectanglePanel[j].BackColor = colorRed;
                    }
                }
            }
        }

        private void GeometryRectanglesIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GeometryRectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesIdTextBox.BackColor = System.Drawing.Color.White;

                var x = Convert.ToDouble(GeometryRectanglesXTextBox.Text);
                var y = _currentRectangleList.Center.Y;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[GeometryRectanglesListBox.SelectedIndex].Location = coordinatePoint;
                GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesXTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void GeometryRectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesYTextBox.BackColor = System.Drawing.Color.White;

                var x = _currentRectangleList.Center.X;
                var y = Convert.ToDouble(GeometryRectanglesYTextBox.Text);
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[GeometryRectanglesListBox.SelectedIndex].Location = coordinatePoint;
                GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GeometryRectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
                var widthDouble = Convert.ToDouble(GeometryRectanglesWidthTextBox.Text);
                var widthInt = Convert.ToInt32(GeometryRectanglesWidthTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Width = widthDouble;
                _rectanglePanel[GeometryRectanglesListBox.SelectedIndex].Width = widthInt;
                GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void GeometryRectanglesLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesLengthTextBox.BackColor = System.Drawing.Color.White;
                var lengthDouble = Convert.ToDouble(GeometryRectanglesLengthTextBox.Text);
                var lengthInt = Convert.ToInt32(GeometryRectanglesLengthTextBox.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Length = lengthDouble;
                _rectanglePanel[GeometryRectanglesListBox.SelectedIndex].Height = lengthInt;
                GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }


        //-----------------------------------Films-------------------------------------------\\

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
                ValuesTextBox.Text = ValuesListBox.SelectedIndex.ToString();
            }
        }

        private void WeekDayParsingButton_Click(object sender, EventArgs e)
        {
            if (Enum.IsDefined(typeof(Weekday), ParsingTextBox.Text))
            {
                int num = (int)Enum.Parse(typeof(Weekday), ParsingTextBox.Text);
                ParsingResultLabel.Text = $"Это день недели ({ParsingTextBox.Text} = {num})";

                ParsingResultLabel.Visible = true;
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

