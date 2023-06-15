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
    public partial class AllEnumerationsControl : UserControl
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

        public AllEnumerationsControl()
        {
            InitializeComponent();

            EnumsListBox1.DisplayMember = nameof(Type.Name);
            EnumsListBox1.Items.AddRange(enums);
            EnumsListBox1.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox1.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox1.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox1.Items.Add(enumValue);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ValuesListBox1.Items == null)
            {
                return;
            }

            else
            {
                ValuesTextBox1.Text = ValuesListBox1.SelectedIndex.ToString();
            }
        }


    }
}
