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

namespace ObjectOrientedPractics
{
    public partial class DiscountCategory : Form
    {
        public DiscountCategory()
        {
            InitializeComponent();

            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        public Category GetCategory()
        {
            Category category = (Category)categoryComboBox.SelectedItem;
            return category;
        }

        private void okButton_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
