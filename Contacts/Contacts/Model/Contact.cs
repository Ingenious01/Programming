using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace View.Model
{
    /// <summary>
    /// Содержит информацию о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задает имя текущего контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает имя текущего контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задает имя текущего контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Конструкток класса <see cref="Contact">.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="email">Почта</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        /// <summary>
        /// Конструкток класса <see cref="Contact"/>.   
        /// </summary>
        public Contact()
        { 
        }
    }
}
