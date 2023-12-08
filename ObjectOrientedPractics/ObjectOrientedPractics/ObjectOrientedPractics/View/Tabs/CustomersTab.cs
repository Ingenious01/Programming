﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
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
        /// Список всех клиентов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Покупатель, выбранный в CustomersListBox.
        /// </summary>
        private Customer _currentCustomer;        

        /// <summary>
        /// Создаёт экземпляр класса CustomerTab.
        /// </summary>
        public customersTab()
        {
            InitializeComponent();

            customersListBox.DataSource = _customers;

            comboBox1.DataSource = Enum.GetValues(typeof(Category));
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
            if (customer.Discounts != null)
            {
                discountsListBox.DataSource = customer.Discounts;
            }
            
            if (customer.IsPriority == true)
            {
                priorityCheckBox.Checked = true;
            }
            else if(customer.IsPriority == false)
            {
                priorityCheckBox.Checked = false;
            }
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
                _currentCustomer = _customers[customersListBox.SelectedIndex];
                UpdateCustomerInfo(_currentCustomer);
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
        /// При нажатии enter присваивает имя клиенту из NameTextBox. 
        /// Если не получается, окрашивает background поля NameTextBox в красный цвет.
        /// </summary>        
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                _currentCustomer = _customers[customersListBox.SelectedIndex];

                var currentName = nameTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentCustomer.FullName = currentName;
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
            string firstname = "Stock Name";

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

            priorityCheckBox.Enabled = true;
            nameTextBox.Enabled = true;
            addressControl1.Enabled = true;
            removeButton.Enabled = true;

            _currentCustomer = _customers[customersListBox.SelectedIndex];
            UpdateCustomerInfo(_currentCustomer);

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
                UpdateCustomerInfo(_customers[customersListBox.SelectedIndex]);
            }
            catch
            {
            }

            if (customersListBox.SelectedIndex < 0)
            {
                priorityCheckBox.Enabled = false;
                nameTextBox.Enabled = false;
                addressControl1.ClearInfo();
                addressControl1.Enabled = false;
                removeButton.Enabled = false;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список клиентов.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                if (value != null)
                {
                    _customers = value;

                    customersListBox.DataSource = _customers;
                    
                }
            }
        }

        private void priorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentCustomer = _customers[customersListBox.SelectedIndex];
            if (priorityCheckBox.Checked == true)
            {
                _currentCustomer.IsPriority = true;
            }
            else if (priorityCheckBox.Checked == false) 
            {
                _currentCustomer.IsPriority = false;
            }
        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            PercentDiscount percentDiscount = new PercentDiscount((Category)comboBox1.SelectedItem);
            _currentCustomer.Discounts.Add(percentDiscount);

            discountsListBox.DataSource = null;
            discountsListBox.DataSource = _currentCustomer.Discounts;
        }
    }
}
