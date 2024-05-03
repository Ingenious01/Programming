using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    /// <summary>
    /// Предоставляет методы для валидации значений.
    /// </summary>
    static public class ValueValidator
    {
        /// <summary>
        /// Проверяет параметры контакта на соответствие со стандартами.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Адрес электронной почты</param>
        /// <returns></returns>
        public static bool CheckParameters(string name, string phoneNumber, string email)
        {
            if (name.Length > 100 || phoneNumber.Length > 100 || email.Length > 100)
            {
                return false;
            }

            foreach (char c in phoneNumber)
            {
                if (!char.IsDigit(c) && c != '+' && c != '-' && c != '(' && c != ')')
                {
                    return false;
                }
            }

            if (!email.Contains("@"))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверяет, содержится ли в имени контакта введенная строка.
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool CheckName(Contact contact, string str)
        {
            if (contact.Name.ToLower().Contains(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Возвращает список контактов, содержащих в себе введеную строку.
        /// </summary>
        /// <param name="contacts">Список контактов</param>
        /// <param name="str">Строка поиска</param>
        /// <param name="find">Функция, по которой выполняется поиск</param>
        /// <returns></returns>
        public static List<Contact> ChangeByString(List<Contact> contacts, string str,
            Func<Contact, string, bool> find)
        {
            if (str == "")
            {
                return null;
            }

            List<Contact> newList = new List<Contact>();

            foreach (var item in contacts)
            {
                if (find(item, str))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}
