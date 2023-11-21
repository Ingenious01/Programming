using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order">
        /// </summary>
        /// <param name="adress">Адресс доставки</param>
        /// <param name="items">Список предметов в заказе(корзина покупателя)</param>
        public Order(Address adress, Cart cart)
        {
            Id = IdGenerator.GetNextOrderId();
            Date = DateTime.Now;
            Address = adress;
            Items = new List<Item>();
            foreach (var item in cart.ListOfItems)
            {
                if(item != null)
                {
                    Items.Add(item);
                }
            }
            TotalPrice = cart.Amount();
            Status = OrderStatus.New;
        }
    }
}
