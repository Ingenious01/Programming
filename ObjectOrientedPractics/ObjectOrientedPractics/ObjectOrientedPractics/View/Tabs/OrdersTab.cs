using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ordersTab : UserControl
    {
        private List<Order> _orders = new List<Order>();

        private Order _currentOrder;

        public List<Order> Orders
        {
            get => _orders;
            set
            {
                _orders = value;
            }
        }

        public Order CurrentOrder
        {
            get => _currentOrder;
            set
            {
                _currentOrder = value;
            }
        }

        public void CreateOrder(Order order)
        {
            Orders.Add(order);
        }

        public ordersTab()
        {
            InitializeComponent();

            ordersGridView.DataSource = Orders;
        }

        private void cartsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ordersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
