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
        /// Цвет ошибки(красный).
        /// </summary>
        Color colorRed = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Корректный цвет(зелёный).
        /// </summary>
        Color colorGreen = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Прямоугольники типа Panel.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Прямоугольники на панели.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// Выбранный прямоугольник на панели.
        /// </summary>
        private Rectangle _currentRectangle;

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
            rectangle = _rectangles[GeometryRectanglesListBox.SelectedIndex];

            GeometryRectanglesIdTextBox.Text = rectangle.Id.ToString();
            GeometryRectanglesXTextBox.Text = rectangle.Center.X.ToString();
            GeometryRectanglesYTextBox.Text = rectangle.Center.Y.ToString();
            GeometryRectanglesWidthTextBox.Text = rectangle.Width.ToString();
            GeometryRectanglesLengthTextBox.Text = rectangle.Length.ToString();
        }

        /// <summary>
        /// Очищает информацию о прямоугольнике.
        /// </summary>
        private void ClearRectangleInfo()
        {
            GeometryRectanglesIdTextBox.Text = "";
            GeometryRectanglesXTextBox.Text = "";
            GeometryRectanglesYTextBox.Text = "";
            GeometryRectanglesWidthTextBox.Text = "";
            GeometryRectanglesLengthTextBox.Text = "";

            GeometryRectanglesXTextBox.BackColor = System.Drawing.Color.White;
            GeometryRectanglesYTextBox.BackColor = System.Drawing.Color.White;
            GeometryRectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
            GeometryRectanglesLengthTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Добавляет прямоугольник на панель.
        /// </summary>
        private void GeometryAddButton_Click(object sender, EventArgs e)
        {
            var size_X = RectanglesPanel.Size.Width;
            var size_Y = RectanglesPanel.Size.Height;

            var rectangle = RectangleFactory.Randomize(size_X, size_Y);
            var panel = new Panel();

            var info = TakeInfoFromRectangle(rectangle);

            _rectangles.Add(rectangle);
            GeometryRectanglesListBox.Items.Add(info);

            panel.Height = Convert.ToInt32(rectangle.Length);
            panel.Width = Convert.ToInt32(rectangle.Width);
            var x = Convert.ToInt32(rectangle.Center.X);
            var y = Convert.ToInt32(rectangle.Center.Y);
            panel.Location = new Point(x, y);
            panel.BackColor = colorGreen;

            _rectanglePanels.Add(panel);
            RectanglesPanel.Controls.Add(panel);
            FindCollision();
        }

        /// <summary>
        /// Удаляет прямоугольник с панели.
        /// </summary>
        private void GeometryRemoveButton_Click(object sender, EventArgs e)
        {
            var currentIndex = GeometryRectanglesListBox.SelectedIndex;
            try
            {
                _rectangles.RemoveAt(currentIndex);
                _rectanglePanels.RemoveAt(currentIndex);
                RectanglesPanel.Controls.RemoveAt(currentIndex);
                GeometryRectanglesListBox.Items.RemoveAt(currentIndex);
                FindCollision();
                GeometryRectanglesListBox.SelectedIndex = currentIndex;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        /// <summary>
        /// При нажатии на конкретный прямоугольник в списке прямоугольников даёт о нём информацию.
        /// </summary>
        private void GeometryRectanlesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateRectangleInfo(ref _currentRectangle);
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
            foreach (Panel rectangle in RectanglesPanel.Controls)
            {
                rectangle.BackColor = colorGreen;
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                    {
                        _rectanglePanels[i].BackColor = colorRed;
                        _rectanglePanels[j].BackColor = colorRed;
                    }
                }
            }
        }

        /// <summary>
        /// Запрещает изменять текст в поле ID.
        /// </summary>
        private void GeometryRectanglesIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// При изменении у конкретного прямоугольника X координаты перерисовывет положение прямоугольника и обновляет
        /// информацию о нём.
        /// </summary>
        private void GeometryRectanglesXTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            try
            {
                GeometryRectanglesXTextBox.BackColor = System.Drawing.Color.White;

                var x = Convert.ToDouble(GeometryRectanglesXTextBox.Text);
                var y = _currentRectangle.Center.Y;
                var coordinatePoint2D = new Point2D(x, y);
                var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));

                _currentRectangle.Center = coordinatePoint2D;
                var info = TakeInfoFromRectangle(_currentRectangle);
                _rectanglePanels[GeometryRectanglesListBox.SelectedIndex].Location = coordinatePoint;
                GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesXTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При изменении у конкретного прямоугольника Y координаты перерисовывет положение прямоугольника и обновляет
        /// информацию о нём.
        /// </summary>
        private void GeometryRectanglesYTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            try
            {
                GeometryRectanglesYTextBox.BackColor = System.Drawing.Color.White;

                if (_currentRectangle != null)
                {
                    var x = _currentRectangle.Center.X;
                    var y = Convert.ToDouble(GeometryRectanglesYTextBox.Text);
                    var coordinatePoint2D = new Point2D(x, y);
                    var coordinatePoint = new Point(Convert.ToInt32(x), Convert.ToInt32(y));                    

                    _currentRectangle.Center = coordinatePoint2D;
                    var info = TakeInfoFromRectangle(_currentRectangle);
                    _rectanglePanels[GeometryRectanglesListBox.SelectedIndex].Location = coordinatePoint;
                    GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                    FindCollision();
                }
            }
            catch
            {
                GeometryRectanglesYTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При изменении у конкретного прямоугольника высоты перерисовывет положение прямоугольника 
        /// и обновляет информацию о нём.
        /// </summary>    
        private void GeometryRectanglesLengthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            try
            {
                GeometryRectanglesLengthTextBox.BackColor = System.Drawing.Color.White;

                var lengthDouble = Convert.ToDouble(GeometryRectanglesLengthTextBox.Text);
                var lengthInt = Convert.ToInt32(GeometryRectanglesLengthTextBox.Text);

                _currentRectangle.Length = lengthDouble;
                var info = TakeInfoFromRectangle(_currentRectangle);
                _rectanglePanels[GeometryRectanglesListBox.SelectedIndex].Height = lengthInt;
                GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesLengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При изменении у конкретного прямоугольника ширины перерисовывет положение прямоугольника и обновляет
        /// информацию о нём.
        /// </summary> 
        private void GeometryRectanglesWidthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            try
            {
                GeometryRectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
                var widthDouble = Convert.ToDouble(GeometryRectanglesWidthTextBox.Text);
                var widthInt = Convert.ToInt32(GeometryRectanglesWidthTextBox.Text);

                _currentRectangle.Width = widthDouble;
                var info = TakeInfoFromRectangle(_currentRectangle);
                _rectanglePanels[GeometryRectanglesListBox.SelectedIndex].Width = widthInt;
                GeometryRectanglesListBox.Items[GeometryRectanglesListBox.SelectedIndex] = info;
                FindCollision();
            }
            catch
            {
                GeometryRectanglesWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
