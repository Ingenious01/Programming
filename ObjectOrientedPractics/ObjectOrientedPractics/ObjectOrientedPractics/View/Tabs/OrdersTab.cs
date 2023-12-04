using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ordersTab : UserControl
    {

        private BindingList<Customer> _customers = new BindingList<Customer>();

        private BindingList<Order> _orders;

        private Order _currentOrder;

        public BindingList<Customer> Customers
        {
            get => _customers;
            set
            {
                if (value != null)
                {
                    _customers = value;
                    _customers.ListChanged += Customers_ListChanged;
                    _customers.ResetBindings();
                }                
            }
        }

        private void Customers_ListChanged(object sender, ListChangedEventArgs e)
        {

            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    {
                        foreach (var order in _orders)
                            if (!_orders.Contains(order)) _orders.Add(order);
                        break;
                    }
                case ListChangedType.Reset:
                    {
                        foreach (var customer in (BindingList<Customer>)sender)
                        {   
                            foreach (var order in customer.Orders)
                            {
                                order.Address = customer.Address;
                                order.CustomerFullName = customer.FullName;

                                if (!_orders.Contains(order)) _orders.Add(order);
                                else _orders[_orders.IndexOf(order)] = order;
                            }
                        }
                        ordersGridView_SelectionChanged(_orders, EventArgs.Empty);
                        break;
                    }
                case ListChangedType.ItemDeleted:
                    {
                        var newOrders = new BindingList<Order>();
                        foreach (var customer in (BindingList<Customer>)sender)
                            foreach (var order in customer.Orders)
                                newOrders.Add(order);

                        _orders = newOrders;
                        OrderBindingSource.DataSource = _orders;
                        break;
                    }            
            }
        }

        public Order CurrentOrder
        {
            get => _currentOrder;
            set
            {
                _currentOrder = value;
            }
        }

        public ordersTab()
        {
            InitializeComponent();            

            _orders = new BindingList<Order>();
            OrderBindingSource.DataSource = _orders;
        }

        private void ordersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersGridView.CurrentRow == null)
            {
                return;
            }
            CurrentOrder = _orders[ordersGridView.CurrentRow.Index];

            idTextBox.Text = Convert.ToString(CurrentOrder.Id);
            costTextBox.Text = Convert.ToString(CurrentOrder.TotalPrice);
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            statusComboBox.Text = Convert.ToString(CurrentOrder.Status);

            orderItemsListBox.DataSource = null;
            orderItemsListBox.DataSource = CurrentOrder.Items;

            addressControl1.Address = CurrentOrder.Address;
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersGridView.CurrentRow == null)
            {
                return;
            }
            CurrentOrder = _orders[ordersGridView.CurrentRow.Index];
            var currentStatus = statusComboBox.Text;

            OrderStatus newStatus = OrderStatus.New;
            switch (currentStatus)
            {
                case "New":
                    newStatus = OrderStatus.New;
                    break;
                case "Processing":
                    newStatus = OrderStatus.Processing;
                    break;
                case "Assembly":
                    newStatus = OrderStatus.Assembly;
                    break;
                case "Sent":
                    newStatus = OrderStatus.Sent;
                    break;
                case "Delivered":
                    newStatus = OrderStatus.Delivered;
                    break;
                case "Returned":
                    newStatus = OrderStatus.Returned;
                    break;
                case "Abandoned":
                    newStatus = OrderStatus.Abandoned;
                    break;
            }

            foreach(var customer in Customers)
            {
                foreach(var order in customer.Orders)
                {
                    if(order.Id == CurrentOrder.Id)
                    {
                        order.Status = newStatus;
                    }
                }
            }

           CurrentOrder.Status = newStatus;

        }
    }
}
