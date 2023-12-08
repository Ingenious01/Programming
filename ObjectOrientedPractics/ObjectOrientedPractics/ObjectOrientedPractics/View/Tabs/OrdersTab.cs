using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
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
        /// <summary>
        /// Список, хранящий всех клиентов типа <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Список, хранящий все заказы типа <see cref="Order"/>.
        /// </summary>
        private BindingList<Order> _orders;

        /// <summary>
        /// Список, хранящий все предметы в магазине типа <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Текущий или выбранный заказ.
        /// </summary>
        private Order _currentOrder;

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
                    _customers.ListChanged += Customers_ListChanged;
                    _customers.ResetBindings();
                }                
            }
        }

        /// <summary>
        /// Возвращает и задает список предметов в магазине.
        /// </summary>
        public BindingList<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Метод, вызывающийся при любых изменениях чего-либо у клиетов.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт текущий выбранный заказ.
        /// </summary>
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

            /// <summary>
            /// Список из возможного времени доставки.
            /// </summary>
            var listDeliveryTime = new string[]
            {
                "None",
                "9:00 – 11:00",
                "11:00 – 13:00",
                "13:00 – 15:00",
                "15:00 – 17:00",
                "17:00 – 19:00",
                "19:00 – 21:00"
            };

            deliveryTimeComboBox.Items.AddRange(listDeliveryTime);
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        /// <summary>
        /// Метод, позволяющий на основе поля <see cref="PriorityOrder.DeliveryDate"/> вывести соответсвующее значение
        /// в строковом формате.
        /// </summary>
        /// <param name="order">Выбранныйы заказ</param>
        /// <returns></returns>
        public string DeliveryDateParse (PriorityOrder order)
        {
            switch (order.DeliveryTime)
            {
                case DeliveryTime.nineAm:
                    return "9:00 – 11:00";

                case DeliveryTime.elevenAm:
                    return "11:00 – 13:00";

                case DeliveryTime.onePm:
                    return "13:00 – 15:00";

                case DeliveryTime.threePm:
                    return "15:00 – 17:00";

                case DeliveryTime.fivePm:
                    return "17:00 – 19:00";

                case DeliveryTime.sevenPm:
                    return "19:00 – 21:00";

                case DeliveryTime.none:
                    return "None";
                default:
                    return " ";
            }
        }

        /// <summary>
        /// Обновляет информацию о заказе.
        /// </summary>
        public void RefreshOrderInfo()
        {
            idTextBox.Text = Convert.ToString(CurrentOrder.Id);

            costTextBox.Text = null;
            costTextBox.Text = Convert.ToString(CurrentOrder.TotalPrice);

            orderItemsListBox.DataSource = null;
            orderItemsListBox.DataSource = CurrentOrder.Items;

            statusComboBox.Text = null;
            statusComboBox.Text = Convert.ToString(CurrentOrder.Status);

            addressControl1.Address = CurrentOrder.Address;

            if (CurrentOrder is PriorityOrder)
            {
                priorityOptionsGroupBox.Enabled = true;
                var currentOrder = (PriorityOrder)CurrentOrder;
                deliveryTimeComboBox.Text = DeliveryDateParse(currentOrder);
            }
            else 
            {
                deliveryTimeComboBox.Text = " ";
                priorityOptionsGroupBox.Enabled = false;
            }
        }

        private void ordersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersGridView.CurrentRow == null)
            {
                priorityOptionsGroupBox.Enabled = false;
                return;
            }
            CurrentOrder = _orders[ordersGridView.CurrentRow.Index];

            RefreshOrderInfo();

            statusComboBox.Enabled = true;
            orderItemsListBox.Enabled = true;
            addItemButton.Enabled = true;
            removeItemButton.Enabled = true;
            clearOrderButton.Enabled = true;
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersGridView.CurrentRow == null || statusComboBox.SelectedItem == null)
            {
                return;
            }

            _orders[ordersGridView.CurrentRow.Index].Status = (OrderStatus)statusComboBox.SelectedItem;          
        }

        private void deliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentOrder is PriorityOrder)
            {
                PriorityOrder currentOrder = (PriorityOrder)CurrentOrder;

                switch (deliveryTimeComboBox.Text)
                {
                    case "9:00 – 11:00":
                        currentOrder.DeliveryTime = DeliveryTime.nineAm;
                        break;

                    case "11:00 – 13:00":
                        currentOrder.DeliveryTime = DeliveryTime.elevenAm;
                        break;

                    case "13:00 – 15:00":
                        currentOrder.DeliveryTime = DeliveryTime.onePm;
                        break;

                    case "15:00 – 17:00":
                        currentOrder.DeliveryTime = DeliveryTime.threePm;
                        break;

                    case "17:00 – 19:00":
                        currentOrder.DeliveryTime = DeliveryTime.fivePm;
                        break;

                    case "19:00 – 21:00":
                        currentOrder.DeliveryTime = DeliveryTime.sevenPm;
                        break;

                    case "None":
                        currentOrder.DeliveryTime = DeliveryTime.none;
                        break;
                }
            }       
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (orderItemsListBox.SelectedItem == null || CurrentOrder == null)
            {
                return;
            }

            CurrentOrder.Items.RemoveAt(orderItemsListBox.SelectedIndex);
            CurrentOrder.TotalPrice = CurrentOrder.Amount();

            RefreshOrderInfo();           
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (CurrentOrder == null)
            {
                return;
            }

            int max = 0;

            foreach (var item in Items)
            {
                max++;
            }

            Random random = new Random();
            int i = random.Next(0, max);

            foreach (var item in Items)
            {                
                if(i==0)
                {
                    CurrentOrder.Items.Add(item);
                }
                i--;
            }

            CurrentOrder.TotalPrice = CurrentOrder.Amount();

            RefreshOrderInfo();
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentOrder.TotalPrice == 0)
            {
                return;
            }

            if (CurrentOrder is PriorityOrder)
            {
                var name = _orders[ordersGridView.CurrentRow.Index].CustomerFullName;
                _orders[ordersGridView.CurrentRow.Index] = null;
                _orders[ordersGridView.CurrentRow.Index] = new PriorityOrder();
                _orders[ordersGridView.CurrentRow.Index].Items = new List<Item>();
                _orders[ordersGridView.CurrentRow.Index].CustomerFullName = name;
                _orders[ordersGridView.CurrentRow.Index].Date = DateTime.Now;
                CurrentOrder = _orders[ordersGridView.CurrentRow.Index];
            }

            else 
            {
                var name = _orders[ordersGridView.CurrentRow.Index].CustomerFullName;
                _orders[ordersGridView.CurrentRow.Index] = null;
                _orders[ordersGridView.CurrentRow.Index] = new Order();
                _orders[ordersGridView.CurrentRow.Index].Items = new List<Item>();
                _orders[ordersGridView.CurrentRow.Index].CustomerFullName = name;
                _orders[ordersGridView.CurrentRow.Index].Date = DateTime.Now;
                CurrentOrder = _orders[ordersGridView.CurrentRow.Index];
            }
            RefreshOrderInfo();
        }
    }
}
