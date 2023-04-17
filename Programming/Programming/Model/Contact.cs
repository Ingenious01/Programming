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
        
        private static bool AssertStringContainsOnlyLetters(string value)
        {
            bool check = !string.IsNullOrEmpty(value) && !Regex.IsMatch(value, @"[^a-zA-z]\w");

            if (check == true)
            {

                int lenght = value.Length;

                for (int i = 0; i < value.Length; i++)
                {
                    if ((value[i] == '0') || (value[i] == '1') || (value[i] == '2') || (value[i] == '3') || (value[i] == '4')
                         || (value[i] == '5') || (value[i] == '6') || (value[i] == '7') || (value[i] == '8') || (value[i] == '9'))
                    {
                        return false;                        
                    }
                }
                return true;
            }
            else return false;
        }

        private string Name
        {
            get => _name;
            set
            {
                bool check = AssertStringContainsOnlyLetters(value);                

                if (check == true)
                    _name = value;
                else
                    throw new ArgumentException("Имя введено не правильно");
            }

        }

        private string Surname
        {
            get => _surname;
            set
            {
                bool check = AssertStringContainsOnlyLetters(value);

                if (check == true)                    
                    _surname = value;
                else
                    throw new ArgumentException("Фамилия введена не правильно");
            }

        }

        private int Age
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
