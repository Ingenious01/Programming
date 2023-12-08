using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ObjectOrientedPractics.Model.IDiscount;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class cartsTab : UserControl
    {

        /// <summary>
        /// Список всех предметов в магазине типа <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Список всех клиентов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Текущий выбранный клиент.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Текущий выбранный предмет.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задаёт список предметов в магазине.
        /// </summary>
        public BindingList<Item> Items
        {
            get => _items;
            set
            {
                if (value != null)
                {
                    _items = value;

                    itemsListBox.DataSource = Items;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт список клиентов.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get => _customers;
            set
            {
                if (value != null)
                {   

                    _customers = value;

                    customerComboBox.DataSource = Customers;
                }
            
            }
        }

        /// <summary>
        /// Возвращает и задаёт текущего клиента.
        /// </summary>
        private Customer CurrentCustomer
        {
            get => _currentCustomer;
            set
            {
                _currentCustomer = value;

                UpdateCartInfo();
            }
        }

        /// <summary>
        /// Возвращает и задаёт выбранный предмет.
        /// </summary>
        public Item CurrentItem
        {
            get => _currentItem;
            set
            {
                _currentItem = value;
            }
        }

        public cartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о карзине клиента.
        /// </summary>
        void UpdateCartInfo()
        {
            cartListBox.DataSource = null;

            cartListBox.DataSource = CurrentCustomer.Cart.ListOfItems;

            totalCostLabel.Text = "0";

            totalCostLabel.Text = Convert.ToString(CurrentCustomer.Cart.Amount());
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentItem = Items[itemsListBox.SelectedIndex];
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentCustomer = Customers[customerComboBox.SelectedIndex];
                CalculateDiscount();
            }
            catch (ArgumentOutOfRangeException)
            { 

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.ListOfItems.Add(CurrentItem);
                UpdateCartInfo();
                CalculateDiscount();
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart.ListOfItems.RemoveAt(cartListBox.SelectedIndex);
            UpdateCartInfo();
        }

        private void clearCartButton_Click(object sender, EventArgs e)
        {
            CurrentCustomer.Cart.ListOfItems.Clear();
            UpdateCartInfo();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {            
            if (CurrentCustomer.IsPriority == true)
            {
                PriorityOrder NewPriorityOrder = new PriorityOrder(CurrentCustomer);
                CurrentCustomer.Orders.Add(NewPriorityOrder);
            }    
            else if (CurrentCustomer.IsPriority == false)
            {
                Order NewOrder = new Order(CurrentCustomer);
                CurrentCustomer.Orders.Add(NewOrder);
            }

            UpdateDiscount();
            CurrentCustomer.Cart.ListOfItems.Clear();
            Customers.ResetBindings();
            UpdateCartInfo();
        }

        public void CalculateDiscount()
        {
            var Discount = 0;
            foreach (var discount in _currentCustomer.Discounts)
            {
                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
            }

            int newPrice = (int)_currentCustomer.Cart.Amount() - Discount;
            discountAmountLabel.Text = Discount.ToString();

            totalLabel.Text = newPrice.ToString();
        }

        public void UpdateDiscount()
        {
            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.ListOfItems);
            }
        }

        public void ApplyDiscount()
        {
            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Apply(_currentCustomer.Cart.ListOfItems);
            }
        }
    }
}
