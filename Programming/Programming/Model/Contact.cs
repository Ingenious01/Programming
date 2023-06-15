using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст контакта
        /// </summary>
        private int _age;

        /// <summary>
        /// Телефонный номер
        /// </summary>
        private string _phonenumber;

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять только из букв.
        /// </summary>
        private string Name
        {
            get => _name;
            set
            {
                bool check = Validator.AssertStringContainsOnlyLetters(value);
                
                _name = value;                
            }

        }
        /// <summary>
        /// Возвращает и задает фамилию контакта. Должно состоять только из букв.
        /// </summary>
        private string Surname
        {
            get => _surname;
            set
            {
                bool check = Validator.AssertStringContainsOnlyLetters(value);
                                 
                _surname = value;                
            }

        }

        /// <summary>
        /// Возвращает и задает возраст контакта.
        /// </summary>
        private int Age
        {
            get => _age;
            set
            {                
                Validator.AssertValueInRange(nameof(Age),value,0,120);
                
                _age = value;                
            }
            

        }

        /// <summary>
        /// Возвращает и задает номер контакта.
        /// </summary>
        private string PhoneNumber
        {
            get => _phonenumber;
            set
            {
                if (value != null)
                    _phonenumber = value;
                else
                    throw new ArgumentException("Введите номер телефона");
            }

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/> без инициализации полей.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия контакта. Должно состоять только из букв.</param>
        /// <param name="number">Номер контакта.</param>
        /// <param name="age">Возраст контакта.</param>
        public Contact(string name, string surname, int age, string phonenumber)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PhoneNumber = phonenumber;            
        }
    }
}
