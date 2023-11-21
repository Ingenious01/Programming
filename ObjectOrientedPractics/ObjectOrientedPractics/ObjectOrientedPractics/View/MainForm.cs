using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();        
        public MainForm()
        {
            InitializeComponent();            

            customersTab1.Customers = _store.Customers;
            itemsTab1.Items = _store.Items;

            cartsTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;

            ordersTab1.Customers = _store.Customers;
        }        
    }
}
