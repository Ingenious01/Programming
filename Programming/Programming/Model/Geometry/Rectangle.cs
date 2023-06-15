using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Programming.Model.Geometry
{
    /// <summary>
    /// Создает прямоугольники и хранит их параметры.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Счетчик все созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 1;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Центр координат прямоугольника.
        /// </summary>
        private Point2D _center;

        /// <summary>
        /// Уникальный идентификатор для объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает счётчик всех созданных экземпляров данного класса.
        /// </summary>
        public static int AllRectanglesCount
        {
            get => _allRectanglesCount;
            private set => _allRectanglesCount = value;
        }

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Должна быть положительным числом.
        /// </summary>
        public double Length
        {
            get => _length;
            set
            {

                Validator.AssertOnPositiveValue(nameof(Length), value);

                _length = value;
            }

        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должна быть положительным числом.
        /// </summary>
        public double Width
        {
            get => _width;
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);

                _width = value;
            }

        }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возращает и задаёт уникальный идентификатор для объектов данного класса.
        /// </summary>
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// Центр координат прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/> без инициализации полей.
        /// </summary>
        public Rectangle()
        {

        }

        /// <summary>
        /// Создает экземпляр класса. <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина прямоугольника.Должна быть положительным числом.</param>
        /// <param name="width">Ширина прямоугольника.Должна быть положительным числом.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Центр координат прямоугольника.</param>
        public Rectangle(float length, float width, string color, Point2D center)
        {
            Id = AllRectanglesCount;
            AllRectanglesCount++;
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }

        /// <summary>
        /// Создает экземпляр класса. <see cref="Rectangle"/>
        /// </summary>
        /// <param name="length">Длина прямоугольника.Должна быть положительным числом.</param>
        /// <param name="width">Ширина прямоугольника.Должна быть положительным числом.</param>
        /// <param name="center">Центр координат прямоугольника.</param>
        public Rectangle(float length, float width, Point2D center)
        {
            Id = AllRectanglesCount;
            AllRectanglesCount++;
            Length = length;
            Width = width;            
            Center = center;
        }
    }
}
