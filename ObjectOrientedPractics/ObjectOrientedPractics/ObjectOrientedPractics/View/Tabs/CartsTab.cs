using ObjectOrientedPractics.Model;
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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class cartsTab : UserControl
    {
        private BindingList<Item> _items = new BindingList<Item>();

        private BindingList<Customer> _customers = new BindingList<Customer>();

        private Customer _currentCustomer;

        private Item _currentItem;

        public BindingList<Item> Items
        {
            get => _items;
            set
            {
                _items = value;

                itemsListBox.DataSource = Items;
            }
        }

        public BindingList<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;

                customerComboBox.DataSource = Customers;
            }
        }

        private Customer CurrentCustomer
        {
            get => _currentCustomer;
            set
            {
                _currentCustomer = value;

                UpdateCartInfo();
            }
        }

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

        void UpdateCartInfo()
        {
            cartListBox.DataSource = null;

            cartListBox.DataSource = CurrentCustomer.Cart.ListOfItems;

            totalCostLabel.Text = "0";

            totalCostLabel.Text = Convert.ToString(CurrentCustomer.Cart.Amount());
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentItem = Items[itemsListBox.SelectedIndex];
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCustomer = Customers[customerComboBox.SelectedIndex];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.ListOfItems.Add(CurrentItem);
                UpdateCartInfo();
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
            Order NewOrder = new Order(CurrentCustomer.Address, CurrentCustomer.Cart);

            CurrentCustomer.Cart.ListOfItems.Clear();
            UpdateCartInfo();
        }
    }
}
