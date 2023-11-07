using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class customersTab : UserControl
    {
        /// <summary>
        /// Покупатель типа Customer.
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Покупатель, выбранный в CustomersListBox.
        /// </summary>
        private Customer _currentCustomerList;

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstname = "Stock Name";

        /// <summary>
        /// Создаёт экземпляр класса CustomerTab.
        /// </summary>
        public customersTab()
        {
            InitializeComponent();

            customersListBox.DataSource = _customers;
        }      

        /// <summary>
        /// Обновляет параметры покупателя.
        /// </summary>
        /// <param name="customer">Покупатель</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            idTextBox.Text = customer.Id.ToString();
            nameTextBox.Text = customer.FullName;
            addressControl1.Address = customer.Address;
        }

        /// <summary>
        /// Очищает информацию о покупателе.
        /// </summary>
        private void ClearCustomerInfo()
        {
            idTextBox.Text = " ";
            nameTextBox.Text = " ";

            nameTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При нажатии на конкретного покупателя в списке покупателей даёт о нём информацию.
        /// </summary>
        public void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomerList = _customers[customersListBox.SelectedIndex];
                UpdateCustomerInfo(_currentCustomerList);
            }
            catch
            {
                ClearCustomerInfo();
            }
        }

        /// <summary>
        /// При изменении символа в строке имени окрашивает её в белый цвет.
        /// </summary>        
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При нажатии пробела присваивает имя клиенту из NameTextBox. 
        /// Если не получается, окрашивает background поля NameTextBox в красный цвет.
        /// </summary>        
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                _currentCustomerList = _customers[customersListBox.SelectedIndex];

                var currentName = nameTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentCustomerList.FullName = currentName;
                }
            }
            catch
            {
                nameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        public void addButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Default value for Name.
            /// </summary>
            int defaultindex = 111111;

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultcountry = "Country";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultcity = "City";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultstreet = "Street";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultbuilding = "Building";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultapartament = "Apartament";

            Address stockAdress = new Address(defaultindex, defaultcountry, defaultcity, defaultstreet, defaultbuilding, defaultapartament);

            var newCustomer = new Customer(firstname, stockAdress);
            _customers.Add(newCustomer);

        }

        /// <summary>
        /// Удаляет покупателя и всю информацию о нём из списка.
        /// </summary>        
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customers.RemoveAt(customersListBox.SelectedIndex);
                customersListBox.Items.RemoveAt(customersListBox.SelectedIndex);
            }
            catch
            {
            }

        }

        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;

                customersListBox.DataSource = _customers;
            }
        }
    }
}
