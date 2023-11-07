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
        private BindingList<Item> _items;

        private BindingList<Customer> _customers;

        public BindingList<Item> Items { get; set; }

        public BindingList<Customer> Customers { get; set; }

        public Store()
        {
            Items = new BindingList<Item>();
            Customers = new BindingList<Customer>();
        }

    }
}
