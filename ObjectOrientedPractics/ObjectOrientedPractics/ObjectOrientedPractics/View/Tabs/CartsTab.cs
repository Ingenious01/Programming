using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
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

            costLabel.Text = "0";

            totalCostLabel.Text = "0";

            costLabel.Text = Convert.ToString(CurrentCustomer.Cart.Amount());
        }

        public void RefreshDiscountInfo(Customer customer)
        {
            var discounts = customer.Discounts;

            foreach (var discount in discounts) 
            {
                if (discount is PercentDiscount)
                {
                    switch (discount.Category)
                    {
                        case Category.Processor:
                            processorDiscountСheckBox.Enabled = true;
                            processorDiscountСheckBox.Text = discount.ToString();
                            break;
                        case Category.GraphicsCard:
                            gpuDiscountСheckBox.Enabled = true;
                            gpuDiscountСheckBox.Text = discount.ToString();
                            break;
                        case Category.Motherboard:
                            motherboardDiscountСheckBox.Enabled = true;
                            motherboardDiscountСheckBox.Text = discount.ToString();
                            break;
                        case Category.RAM:
                            ramDiscountСheckBox.Enabled = true;
                            ramDiscountСheckBox.Text = discount.ToString();
                            break;
                        case Category.PowerSupplie:
                            powersupplieDiscountСheckBox.Enabled = true;
                            powersupplieDiscountСheckBox.Text = discount.ToString();
                            break;
                        case Category.SSD:
                            ssdDiscountСheckBox.Enabled = true;
                            ssdDiscountСheckBox.Text = discount.ToString();
                            break;
                        case Category.HDD:
                            hddDiscountСheckBox.Enabled = true;
                            hddDiscountСheckBox.Text = discount.ToString();
                            break;
                    }                    
                }
                else { pointsDiscountСheckBox.Text = discount.ToString(); }
               
            }
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
                processorDiscountСheckBox.Enabled = false;
                processorDiscountСheckBox.Text = "Процентная в категоргии Processor";

                gpuDiscountСheckBox.Enabled = false;
                gpuDiscountСheckBox.Text = "Процентная в категоргии GrahicsCard";

                motherboardDiscountСheckBox.Enabled = false;
                motherboardDiscountСheckBox.Text = "Процентная в категоргии MotherBoard";

                ramDiscountСheckBox.Enabled = false;
                ramDiscountСheckBox.Text = "Процентная в категоргии RAM";

                powersupplieDiscountСheckBox.Enabled = false;
                powersupplieDiscountСheckBox.Text = "Процентная в категоргии PowerSupplie";

                ssdDiscountСheckBox.Enabled = false;
                ssdDiscountСheckBox.Text = "Процентная в категоргии SSD";

                hddDiscountСheckBox.Enabled = false;
                hddDiscountСheckBox.Text = "Процентная в категоргии HDD";

                CurrentCustomer = Customers[customerComboBox.SelectedIndex];
                RefreshDiscountInfo(CurrentCustomer);
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
                NewPriorityOrder.TotalPrice = Convert.ToInt32(totalCostLabel.Text);
                CurrentCustomer.Orders.Add(NewPriorityOrder);
            }    
            else if (CurrentCustomer.IsPriority == false)
            {
                Order NewOrder = new Order(CurrentCustomer);
                NewOrder.TotalPrice = Convert.ToInt32(totalCostLabel.Text);
                CurrentCustomer.Orders.Add(NewOrder);
            }
            
            UpdateDiscount();
            CurrentCustomer.Cart.ListOfItems.Clear();
            Customers.ResetBindings();
            UpdateCartInfo();
            CurrentCustomer = Customers[customerComboBox.SelectedIndex];
            RefreshDiscountInfo(CurrentCustomer);
            CalculateDiscount();
        }

        public void CalculateDiscount()
        {
            if (CurrentCustomer == null)
            {
                return;
            }

            var Discount = 0;
            foreach (var discount in CurrentCustomer.Discounts)
            {

                if (discount is PointsDiscount)
                {
                    if (pointsDiscountСheckBox.Checked == true)
                    {
                        Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
                        totalCostLabel.Text = discount.Category.ToString();
                    }
                }
                else
                {
                    switch (discount.Category)
                    {
                        case Category.Processor:
                            if (processorDiscountСheckBox.Checked == true)
                            {
                                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);                                
                            }
                            break;

                        case Category.GraphicsCard:
                            if (gpuDiscountСheckBox.Checked == true)
                            {
                                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
                            }
                            break;

                        case Category.Motherboard:
                            if (motherboardDiscountСheckBox.Checked == true)
                            {
                                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
                            }
                            break;

                        case Category.RAM:
                            if (ramDiscountСheckBox.Checked == true)
                            {
                                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
                            }
                            break;

                        case Category.PowerSupplie:
                            if (powersupplieDiscountСheckBox.Checked == true)
                            {
                                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
                            }
                            break;

                        case Category.SSD:
                            if (ssdDiscountСheckBox.Checked == true)
                            {
                                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
                            }
                            break;

                        case Category.HDD:
                            if (hddDiscountСheckBox.Checked == true)
                            {
                                Discount = Discount + discount.Calculate(_currentCustomer.Cart.ListOfItems);
                            }
                            break;
                    }
                }                
            }

            int newPrice = (int)_currentCustomer.Cart.Amount() - Discount;
            discountAmountLabel.Text = Discount.ToString();

            totalCostLabel.Text = newPrice.ToString();
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

        private void pointsDiscountСheckBox_CheckedChanged(object sender, EventArgs e)  
        {
            CalculateDiscount();
        }

        private void processorDiscountСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void gpuDiscountСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void motherboardDiscountСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void ramDiscountСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void powersupplieDiscountСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void ssdDiscountСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        private void hddDiscountСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateDiscount();
        }
    }
}
