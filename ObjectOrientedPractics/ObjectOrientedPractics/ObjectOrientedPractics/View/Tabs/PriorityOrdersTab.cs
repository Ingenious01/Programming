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
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Список всех предметов.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        private PriorityOrder _priorityOrder = new PriorityOrder();

        public PriorityOrder PriorityOrder
        {
            get => _priorityOrder;            
        }

        public PriorityOrdersTab()
        {
            InitializeComponent();

            /// <summary>
            /// Список из возможного времени доставки.
            /// </summary>
            var listDeliveryTime = new string[]
            {
                "9:00 – 11:00",
                "11:00 – 13:00",
                "13:00 – 15:00",
                "15:00 – 17:00",
                "17:00 – 19:00",
                "19:00 – 21:00"
            };

            deliveryTimeComboBox.Items.AddRange(listDeliveryTime);

            /// <summary>
            /// Default value for Name.
            /// </summary>
            int defaultindex = 111111;

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultcountry = "Country";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultcity = "City";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultstreet = "Street";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultbuilding = "Building";

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string defaultapartament = "Apartament";

            PriorityOrder.Address = new Address(defaultindex, defaultcountry, defaultcity,
                defaultstreet, defaultbuilding, defaultapartament);

            addressControl1.Address = PriorityOrder.Address;

            idTextBox.Text = Convert.ToString(PriorityOrder.Id);

            createdTextBox.Text = Convert.ToString(PriorityOrder.Date);

            PriorityOrder.Status = OrderStatus.New;
            statusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            statusComboBox.Text = Convert.ToString(PriorityOrder.Status);

            orderItemsListBox.DataSource = PriorityOrder.Items;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {

        }

        private void deliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (deliveryTimeComboBox.Text)
            {
                case "9:00 – 11:00":
                    PriorityOrder.DeliveryTime = DeliveryTime.nineAm;
                    break;
                case "11:00 – 13:00":
                    PriorityOrder.DeliveryTime = DeliveryTime.elevenAm;
                    break;
                case "13:00 – 15:00":
                    PriorityOrder.DeliveryTime = DeliveryTime.onePm;
                    break;
                case "15:00 – 17:00":
                    PriorityOrder.DeliveryTime = DeliveryTime.threePm;
                    break;
                case "17:00 – 19:00":
                    PriorityOrder.DeliveryTime = DeliveryTime.fivePm; ;
                    break;
                case "19:00 – 21:00":
                    PriorityOrder.DeliveryTime = DeliveryTime.sevenPm; 
                    break;
            }
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
