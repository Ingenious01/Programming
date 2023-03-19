using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        string _name;
        string _surname;
        int _age;
        string _phonenumber;        

        public string Name
        {
            get => _name;
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentException("Введите имя человека");
            }

        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (value != null)
                    _surname = value;
                else
                    throw new ArgumentException("Введите фамилию человека)");
            }

        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0 && value <= 120)
                    _age = value;
                else
                    throw new ArgumentException("Введите возраст человека");
            }

        }

        public string PhoneNumber
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

        public Contact()
        {

        }

        public Contact(string name, string surname, int age, string phonenumber)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PhoneNumber = phonenumber;            
        }
    }
}
