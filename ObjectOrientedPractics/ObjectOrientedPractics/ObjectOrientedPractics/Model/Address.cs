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
    public class Address : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartament;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Возвращает и задаёт индивидуальный номер товара.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                var check = Convert.ToString(value);

                if ((check.Length != 6) || (check == "000000"))
                {
                    throw new ArgumentException("Введён неверный почтовый индекс");
                }

                _index = value;

                OnPropertyChanged();
            }

        }

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));               

                _country = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));

                _city = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));

                _street = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));

                _building = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре.
        /// </summary>
        public string Apartament
        {
            get => _apartament;
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartament));

                _apartament = value;

                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>    
        /// <param name="index">Индекс</param>
        /// <param name="country">Страна</param>
        /// <param name="city">Город</param>
        /// <param name="street">Улица</param>
        /// <param name="building">Номер дома</param>
        /// <param name="apartament">Номер квартиры</param>
        public Address(int index, string country, string city, string street, string building, string apartament)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartament = apartament;
        }
        

        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartament);
        }

        public override bool Equals(object other)
        {
            // Обязательные проверки прежде чем мы сравним поля
            if (other == null)
                return false;

            if (other is Address)
            {
                if (object.ReferenceEquals(this, other))
                    return true;

                var address2 = (Address)other;

                // Только теперь мы можем сделать собственное сравнение
                return (this.Index == address2.Index);
            }

            else
            {
                return false;
            }
        }
    }
}
