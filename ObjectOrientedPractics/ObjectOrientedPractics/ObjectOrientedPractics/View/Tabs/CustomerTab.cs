using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
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
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса CustomerTab.
    /// </summary>
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// Покупатель типа Customer.
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();               

        /// <summary>
        /// Покупатель, выбранный в CustomersListBox.
        /// </summary>
        private Customer _currentCustomerList;        

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstname = "Stock Name";
     
        /// <summary>
        /// Создаёт экземпляр класса CustomerTab.
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();                   

            CustomersListBox.DataSource = _customers;
        }

        /// <summary>
        /// Создаёт строку с информацией о покупателе.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <returns>Возвращает строку с информацией о клиенте.</returns>
        public static string TakeInfoFromCustomer(Customer customer)
        {
            var info = $"{customer.Id}. " +
               $"Name={customer.FullName}, " +
               $"Index ={customer.Adress.Index} ";            
            
            return info;
        }

        /// <summary>
        /// Обновляет параметры покупателя.
        /// </summary>
        /// <param name="customer">Покупатель</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            IdTextBox.Text = customer.Id.ToString();
            NameTextBox.Text = customer.FullName;
            adressControl1.Adress = customer.Adress;
        }

        /// <summary>
        /// Очищает информацию о покупателе.
        /// </summary>
        private void ClearCustomerInfo()
        {
            IdTextBox.Text = " ";
            NameTextBox.Text = " ";            

            NameTextBox.BackColor = System.Drawing.Color.White;                       
        }
        
        /// <summary>
        /// При нажатии на конкретного покупателя в списке покупателей даёт о нём информацию.
        /// </summary>
        public void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomerList = _customers[CustomersListBox.SelectedIndex];
                UpdateCustomerInfo(_currentCustomerList);                               
            }
            catch
            {
                ClearCustomerInfo();
            }
        }

        /// <summary>
        /// При изменении символа в строке имени окрашивает её в белый цвет.
        /// </summary>        
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameTextBox.BackColor = System.Drawing.Color.White;
        }        

        /// <summary>
        /// При нажатии пробела присваивает имя клиенту из NameTextBox. 
        /// Если не получается, окрашивает background поля NameTextBox в красный цвет.
        /// </summary>        
        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

                var currentName = NameTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentCustomerList.FullName = currentName;
                    
                    
                }
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        } 
   
        public void AddButton_Click(object sender, EventArgs e)
        {
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

            Adress stockAdress = new Adress(defaultindex, defaultcountry, defaultcity, defaultstreet, defaultbuilding, defaultapartament);

            var newCustomer = new Customer(firstname, stockAdress);
            _customers.Add(newCustomer);           
            
        }

        /// <summary>
        /// Удаляет покупателя и всю информацию о нём из списка.
        /// </summary>        
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _customers.RemoveAt(CustomersListBox.SelectedIndex);
                CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            }
            catch
            {
            }

        }
    }
}
