using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics
{
    public partial class DiscountCategory : Form
    {      
        public event EventHandler<CategoryEventsArgs> ValueChanged;

        private Category _value;

        public DiscountCategory()
        {
            InitializeComponent();

            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            categoryComboBox.SelectedItem = null;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _value = (Category)categoryComboBox.SelectedItem;
            var categoryEventsArgs = new CategoryEventsArgs(_value);
            ValueChanged?.Invoke(this, categoryEventsArgs);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
