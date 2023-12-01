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

namespace Programming.View.Panels
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса Weekday Parsing.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса Weekday Parsing.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Считывает текст и определяет есть ли такой день недели.
        /// </summary>
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
    }
}
