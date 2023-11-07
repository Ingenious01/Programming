using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Order
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
        private Cart _items;

        /// <summary>
        /// Стоимость заказа.
        /// </summary>
        private double _totalPrice;

        /// <summary>
        /// Возвращает и задаёт персональный номер заказа.
        /// </summary>
        public int Id { get { return _id; } set { _id = value; } }

        /// <summary>
        /// Возвращает и задаёт время создания заказа.
        /// </summary>
        public DateTime Date { get { return _date; } set { _date = value; } }

        /// <summary>
        /// Возвращает и задаёт адресс доставки.
        /// </summary>
        public Address Address { get { return _address; } set { _address = value; } }

        /// <summary>
        /// Возвращает и задаёт список предметов в заказе.
        /// </summary>
        public Cart Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Возвращает и задаёт общую стоимость заказа.
        /// </summary>
        public double TotalPrice { get { return _totalPrice; } set { _totalPrice = value; } }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order">
        /// </summary>
        /// <param name="adress">Адресс доставки</param>
        /// <param name="items">Список предметов в заказе(корзина покупателя)</param>
        public Order(Address adress, Cart items)
        {
            Id = IdGenerator.GetNextOrderId();
            Date = DateTime.Now;
            Address = adress;
            Items = items;
            TotalPrice = items.Amount();
        }
    }
}
