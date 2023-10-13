using ObjectOrientedPractics.Services;
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
        private List<Item> _items;
        private BindingList<Customer> _customers;

        public List<Item> Items { get; set; }

        public BindingList<Customer> Customers { get; set; }

        public Store() 
        { 
            Items = new List<Item>();
            Customers = new BindingList<Customer>();   
        }

    }
}
