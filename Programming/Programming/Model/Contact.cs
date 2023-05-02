using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Contact
    {
        string _name;
        string _surname;
        int _age;
        string _phonenumber;     
        

        private string Name
        {
            get => _name;
            set
            {
                bool check = Validator.AssertStringContainsOnlyLetters(value);
                
                _name = value;                
            }

        }

        private string Surname
        {
            get => _surname;
            set
            {
                bool check = Validator.AssertStringContainsOnlyLetters(value);
                                 
                _surname = value;                
            }

        }

        private int Age
        {
            get => _age;
            set
            {                
                Validator.AssertValueInRange(nameof(Age),value,0,120);
                
                _age = value;                
            }
            

        }

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
