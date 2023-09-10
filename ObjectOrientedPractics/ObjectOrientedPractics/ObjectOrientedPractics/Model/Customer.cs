using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит информацию о покупателе.
    /// </summary>
    internal class Customer
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
        private string _adress;

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

                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт домашний адрес покупателя. Длинна строки с адресом должна быть не больше 500.
        /// </summary>
        public string Adress
        {
            get => _adress;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Adress));

                _adress = value;
            }

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>    
        /// <param name="fullname">ФИО</param>
        /// <param name="adress">Адрес</param>
        public Customer(string fullname, string adress)
        {
            Id = IdGenerator.GetNextCustomerId();
            FullName = fullname;
            Adress = adress;
        }
    }
}
