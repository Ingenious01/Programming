using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        /// <summary>
        /// Список всех предметов в магазине.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Список всех клиентов.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список всех предметов в магазине.
        /// </summary>
        public BindingList<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает список всех клиентов магазина.
        /// </summary>
        public BindingList<Customer> Customers { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>
        /// </summary>
        public Store()
        {
            Items = new BindingList<Item>();
            Customers = new BindingList<Customer>();
        }

    }
}
