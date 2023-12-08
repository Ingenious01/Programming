using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Orders
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Персональный номер заказа.
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private DateTime _date;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список предметов в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Стоимость заказа.
        /// </summary>
        private double _totalPrice;

        /// <summary>
        /// Стоимость заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Имя покупателя.
        /// </summary>
        private string _customerFullName;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Возвращает и задаёт персональный номер заказа.
        /// </summary>
        public int Id { get { return _id; } set { _id = value;} }

        /// <summary>
        /// Возвращает и задаёт время создания заказа.
        /// </summary>
        public DateTime Date { get { return _date; } set { _date = value; OnPropertyChanged();} }

        /// <summary>
        /// Возвращает и задаёт адресс доставки.
        /// </summary>
        public Address Address { get { return _address; } set { _address = value; OnPropertyChanged(); } }

        /// <summary>
        /// Возвращает и задаёт персональный номер заказа.
        /// </summary>
        public OrderStatus Status { get { return _status; } set { _status = value; OnPropertyChanged(); } }

        /// <summary>
        /// Возвращает и задаёт список предметов в заказе.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; OnPropertyChanged(); } }

        /// <summary>
        /// Возвращает и задаёт общую стоимость заказа.
        /// </summary>
        public double TotalPrice { get { return _totalPrice; } set { _totalPrice = value; OnPropertyChanged(); } }
        
        /// <summary>
        /// Возвращает и задаёт список предметов в заказе.
        /// </summary>
        public string CustomerFullName { get { return _customerFullName; } set { _customerFullName = value; OnPropertyChanged(); } }

        public int DiscountAmount { get; set; }

        public int Total { get; set; }

        /// <summary>
        /// Считает общую стоимость всех пердметов в заказе у покупателя.
        /// </summary>
        public double Amount()
        {
            double total = 0;

            foreach (var item in _items)
            {
                if (item != null)
                {
                    total = total + item.Cost;
                }
            }

            return total;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order">
        /// </summary>
        public Order()
        {
            Id = IdGenerator.GetNextOrderId();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order">
        /// </summary>
        /// <param name="customer">Клиент, заказ которого создаётся</param>
        public Order(Customer customer)
        {
            Id = IdGenerator.GetNextOrderId();
            Date = DateTime.Now;
            Address = customer.Address;
            Items = new List<Item>();
            foreach (var item in customer.Cart.ListOfItems)
            {
                if(item != null)
                {
                    Items.Add(item);
                }
            }
            TotalPrice = customer.Cart.Amount();
            Status = OrderStatus.New;
            CustomerFullName = customer.FullName;
        }
    }
}
