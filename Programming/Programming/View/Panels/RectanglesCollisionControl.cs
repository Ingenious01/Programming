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

    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса RectanglesCollisionControl.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Прямоугольники типа Panel.
        /// </summary>
        private List<Panel> _rectanglePanel = new List<Panel>();
        /// <summary>
        /// Прямоугольники на панели.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();
        /// <summary>
        /// Выбранный прямоугольник на панели.
        /// </summary>
        private Rectangle _currentRectangleList;

        /// <summary>
        /// Создаёт экземпляр класса RectanglesCollisionControl.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создаёт строку с информацией о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает строку с информацией о прямоугольнике.</returns>
        private static string TakeInfoFromRectangle(Rectangle rectangle)
        {
            var info = $"{rectangle.Id}. " +
                       $"(X={rectangle.Center.X}; " +
                       $"Y={rectangle.Center.Y};" +
                       $" W={rectangle.Width}; " +
                       $"L={rectangle.Length})";

            return info;
        }

        /// <summary>
        /// Обновляет параметры прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник</param>
        private void UpdateRectangleInfo(ref Rectangle rectangle)
        {
            rectangle = _rectanglesList[GeometryRectanglesListBox1.SelectedIndex];

            GeometryRectanglesIdTextBox1.Text = rectangle.Id.ToString();
            GeometryRectanglesXTextBox1.Text = rectangle.Center.X.ToString();
            GeometryRectanglesYTextBox1.Text = rectangle.Center.Y.ToString();
            GeometryRectanglesWidthTextBox1.Text = rectangle.Width.ToString();
            GeometryRectanglesLengthTextBox1.Text = rectangle.Length.ToString();
        }

        /// <summary>
        /// Очищает информацию о прямоугольнике.
        /// </summary>
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

        /// <summary>
        /// Добавляет прямоугольник на панель.
        /// </summary>
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

        /// <summary>
        /// Удаляет прямоугольник с панели.
        /// </summary>
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

        /// <summary>
        /// При нажатии на конкретный прямоугольник в списке прямоугольников даёт о нём информацию.
        /// </summary>
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

        /// <summary>
        /// Определяет пересекаются ли прямоугольники на панели.
        /// </summary>
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

        /// <summary>
        /// Запрещает изменять текст в поле ID.
        /// </summary>
        private void GeometryRectanglesIdTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// При изменении у конкретного прямоугольника X координаты перерисовывет положение прямоугольника и обновляет
        /// информацию о нём.
        /// </summary>
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

        /// <summary>
        /// При изменении у конкретного прямоугольника Y координаты перерисовывет положение прямоугольника и обновляет
        /// информацию о нём.
        /// </summary>
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

        /// <summary>
        /// При изменении у конкретного прямоугольника ширины перерисовывет положение прямоугольника и обновляет
        /// информацию о нём.
        /// </summary>
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

        /// <summary>
        /// При изменении у конкретного прямоугольника высоты перерисовывет положение прямоугольника и обновляет
        /// информацию о нём.
        /// </summary>
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
