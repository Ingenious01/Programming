using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Services
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
        private Adress _adress;

        public event PropertyChangedEventHandler PropertyChanged;

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
        
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            var info = $"{Id}. " +
               $"Name={FullName}, " +
               $"Index ={Adress.Index} ";

            return info;
        }


        /// <summary>
        /// Возвращает и задаёт домашний адрес покупателя. Длинна строки с адресом должна быть не больше 500.
        /// </summary>
        public Adress Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
                _adress.PropertyChanged += AddressChanged;
                void AddressChanged(object sender, PropertyChangedEventArgs args) =>
                    OnPropertyChanged();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>    
        /// <param name="fullname">ФИО</param>
        /// <param name="adress">Адрес</param>
        public Customer(string fullname, Adress adress)
        {
            Id = IdGenerator.GetNextCustomerId();
            FullName = fullname;
            Adress = adress;
        }
    }
}
