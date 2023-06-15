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

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Panel> _rectanglePanel = new List<Panel>();
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        private Rectangle _currentRectangleList;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

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
            rectangle = _rectanglesList[GeometryRectanglesListBox1.SelectedIndex];

            GeometryRectanglesIdTextBox1.Text = rectangle.Id.ToString();
            GeometryRectanglesXTextBox1.Text = rectangle.Center.X.ToString();
            GeometryRectanglesYTextBox1.Text = rectangle.Center.Y.ToString();
            GeometryRectanglesWidthTextBox1.Text = rectangle.Width.ToString();
            GeometryRectanglesLengthTextBox1.Text = rectangle.Length.ToString();
        }

        private void ClearRectangleInfo()
        {
            GeometryRectanglesIdTextBox1.Text = " ";
            GeometryRectanglesXTextBox1.Text = " ";
            GeometryRectanglesYTextBox1.Text = " ";
            GeometryRectanglesWidthTextBox1.Text = " ";
            GeometryRectanglesLengthTextBox1.Text = " ";

            GeometryRectanglesXTextBox1.BackColor = System.Drawing.Color.White;
            GeometryRectanglesYTextBox1.BackColor = System.Drawing.Color.White;
            GeometryRectanglesWidthTextBox1.BackColor = System.Drawing.Color.White;
            GeometryRectanglesLengthTextBox1.BackColor = System.Drawing.Color.White;
        }

        private void GeometryAddButton1_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize(576, 635);
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);

            _rectanglesList.Add(rectangle);
            GeometryRectanglesListBox1.Items.Add(info);

            panel.Height = Convert.ToInt32(rectangle.Length);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            _rectanglePanel.Add(panel);
            rectanglesPanel1.Controls.Add(panel);
            FindCollision();
        }

        private void GeometryRemoveButton1_Click(object sender, EventArgs e)
        {
            try
            {
                _rectanglesList.RemoveAt(GeometryRectanglesListBox1.SelectedIndex);
                _rectanglePanel.RemoveAt(GeometryRectanglesListBox1.SelectedIndex);
                rectanglesPanel1.Controls.RemoveAt(GeometryRectanglesListBox1.SelectedIndex);
                GeometryRectanglesListBox1.Items.RemoveAt(GeometryRectanglesListBox1.SelectedIndex);
                FindCollision();
            }
            catch
            {

            }

        }

        private void GeometryRectanlesListBox1_SelectedIndexChanged(object sender, EventArgs e)
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

            foreach (Panel rectangle in rectanglesPanel1.Controls)
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

        private void GeometryRectanglesIdTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void GeometryRectanglesXTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesIdTextBox1.BackColor = System.Drawing.Color.White;

                var x = Convert.ToDouble(GeometryRectanglesXTextBox1.Text);
                var y = _currentRectangleList.Center.Y;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[GeometryRectanglesListBox1.SelectedIndex].Location = coordinatePoint;
                GeometryRectanglesListBox1.Items[GeometryRectanglesListBox1.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesXTextBox1.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void GeometryRectanglesYTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesYTextBox1.BackColor = System.Drawing.Color.White;

                var x = _currentRectangleList.Center.X;
                var y = Convert.ToDouble(GeometryRectanglesYTextBox1.Text);
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Center = coordinatePoint2D;
                _rectanglePanel[GeometryRectanglesListBox1.SelectedIndex].Location = coordinatePoint;
                GeometryRectanglesListBox1.Items[GeometryRectanglesListBox1.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesYTextBox1.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GeometryRectanglesWidthTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesWidthTextBox1.BackColor = System.Drawing.Color.White;
                var widthDouble = Convert.ToDouble(GeometryRectanglesWidthTextBox1.Text);
                var widthInt = Convert.ToInt32(GeometryRectanglesWidthTextBox1.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Width = widthDouble;
                _rectanglePanel[GeometryRectanglesListBox1.SelectedIndex].Width = widthInt;
                GeometryRectanglesListBox1.Items[GeometryRectanglesListBox1.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesWidthTextBox1.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void GeometryRectanglesLengthTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GeometryRectanglesLengthTextBox1.BackColor = System.Drawing.Color.White;
                var lengthDouble = Convert.ToDouble(GeometryRectanglesLengthTextBox1.Text);
                var lengthInt = Convert.ToInt32(GeometryRectanglesLengthTextBox1.Text);
                var info = TakeInfoFromRectangle(_currentRectangleList);

                _currentRectangleList.Length = lengthDouble;
                _rectanglePanel[GeometryRectanglesListBox1.SelectedIndex].Height = lengthInt;
                GeometryRectanglesListBox1.Items[GeometryRectanglesListBox1.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesLengthTextBox1.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
