using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса RectanglesFinderControl.
    /// </summary>
    public partial class RectanglesControl : UserControl
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
        /// Массив из 100 прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[100];

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Экземпляр класса Random.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Создаёт экземпляр класса RectanglesFinderControl.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            FillRectangles();

            /// <summary>
            /// Список из 5 изначальных прямоугольников.
            /// </summary>
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
        }

        /// <summary>
        /// Заполняет массив 5 случайными экземплярами класса <see cref="Rectangle"/>.
        /// </summary>        
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

        /// <summary>
        /// При изменении выбранного прямоугольника в списке прямоугольников меняются характеристики на новые значения.
        /// </summary>
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

        /// <summary>
        /// При изменении длины выбранного прямоугольника запоминает новое значение.
        /// </summary>
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

        /// <summary>
        /// При изменении ширины выбранного прямоугольника запоминает новое значение.
        /// </summary>
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

        /// <summary>
        /// При изменении цвета выбранного прямоугольника запоминает новое значение.
        /// </summary>
        private void ColorBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorBox.Text;
        }

        /// <summary>
        /// Выбирает прямоугольник с наибольшей шириной в списке прямоугольников по нажатию кнопки find.
        /// </summary>
        private void RectengleFindButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth();
        }

        /// <summary>
        /// Определяет прямоугольник с наибольшей шириной.
        /// </summary>        
        /// <returns>Возвращает индекс с наибольшей шириной в списке.</returns>
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
    }
}
