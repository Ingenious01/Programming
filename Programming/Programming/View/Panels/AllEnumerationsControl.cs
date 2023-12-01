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
    /// Предоставляет шаблон пользовательского интерфейса Enumerations.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
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
        /// Создаёт экземпляр класса Enumerations.
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();

            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// При изменении выбранного перечисления в списке перечислений меняет содержимое списка значений.
        /// </summary>
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

        /// <summary>
        /// При изменении выбранного значения в списке значений меняет порядковый номер значения.
        /// </summary>
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
    }
}
