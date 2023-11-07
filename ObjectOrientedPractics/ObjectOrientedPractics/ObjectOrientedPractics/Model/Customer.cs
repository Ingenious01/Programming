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
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    public class Customer : INotifyPropertyChanged
    {
        /// <summary>
        /// Персональный номер покупателя.
        /// </summary>
        private int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Домашний адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Заказы покупателя.
        /// </summary>
        private List<Order> _orders;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Возвращает и задаёт персональный номер покупателя.
        /// </summary>
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// Возвращает и задаёт ФИО покупателя. Длинна строки с ФИО должна быть не больше 200.
        /// </summary>
        public string FullName
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));

                ValueValidator.AssertFullNameStringOnSymbols(value, nameof(FullName));

                _fullname = value;

                OnPropertyChanged();
            }
        }        

        public override string ToString()
        {
            var info = $"{Id}. " +
               $"Name={FullName}, " +
               $"Index ={Address.Index} ";

            return info;
        }


        /// <summary>
        /// Возвращает и задаёт домашний адрес покупателя. Длинна строки с адресом должна быть не больше 500.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                _address.PropertyChanged += AddressChanged;
                void AddressChanged(object sender, PropertyChangedEventArgs args) =>
                    OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт персональный номер покупателя.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт заказ покупателя.
        /// </summary>
        public List<Order> Orders
        {
            set => _orders = value;
            get => _orders;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>    
        /// <param name="fullname">ФИО</param>
        /// <param name="adress">Адрес</param>
        public Customer(string fullname, Address address)
        {
            Id = IdGenerator.GetNextCustomerId();
            FullName = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
        }
    }
}
