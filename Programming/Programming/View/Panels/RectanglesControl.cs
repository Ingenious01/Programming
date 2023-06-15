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
    public partial class RectanglesControl : UserControl
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

        private Rectangle[] _rectangles = new Rectangle[100];
        private Rectangle _currentRectangle;

        private Random _random = new Random();

        public RectanglesControl()
        {
            InitializeComponent();

            FillRectangles();

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


    }
}
