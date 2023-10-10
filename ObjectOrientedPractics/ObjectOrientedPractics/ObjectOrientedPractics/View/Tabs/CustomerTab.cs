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
        private List<Customer> _customers = new List<Customer>();

        public AdressControl adresscontrol = new AdressControl();

        /// <summary>
        /// Покупатель, выбранный в CustomersListBox.
        /// </summary>
        private Customer _currentCustomerList;        

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstname = "Stock Name";

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static int firstindex = 111111;

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstcountry = "Country";

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstcity = "City";

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firststreet = "Street";

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstbuilding = "Building";

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstapartament = "Apartament";

        static Adress stockAdress = new Adress(firstindex, firstcountry, firstcity, firststreet, firstbuilding, firstapartament);

        /// <summary>
        /// The first default Customer.
        /// </summary>             
        Customer stockCustomer = new Customer(firstname, stockAdress);

        /// <summary>
        /// Создаёт экземпляр класса CustomerTab.
        /// </summary>
        public CustomerTab()
        {
            InitializeComponent();                   

            _customers.Add(stockCustomer);
            var info = TakeInfoFromCustomer(stockCustomer);

            CustomersListBox.Items.Add(info);
        }

        public void RefreshIndexValue(int value)
        {
            _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

            _currentCustomerList.Adress.Index= value;
        }

        public void RefreshCountryValue(string value)
        {
            _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

            _currentCustomerList.Adress.Country = value;
        }

        public void RefreshCityValue(string value)
        {
            _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

            _currentCustomerList.Adress.City = value;
        }

        public void RefreshStreetValue(string value)
        {
            _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

            _currentCustomerList.Adress.Street = value;
        }

        public void RefreshBuildingValue(string value)
        {
            _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

            _currentCustomerList.Adress.Building = value;
        }

        public void RefreshApartamentValue(string value)
        {
            _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

            _currentCustomerList.Adress.Apartament = value;
        }



        /// <summary>
        /// Создаёт строку с информацией о покупателе.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <returns>Возвращает строку с информацией о клиенте.</returns>
        private static string TakeInfoFromCustomer(Customer customer)
        {
            var info = $"{customer.Id}. " +
               $"Name={customer.FullName}," +
               $"Adress Index ={customer.Adress.Index} ";
            
            return info;
        }

        /// <summary>
        /// Обновляет параметры покупателя.
        /// </summary>
        /// <param name="customer">Покупатель</param>
        private void UpdateCustomerInfo(ref Customer customer)
        {
            customer = _customers[CustomersListBox.SelectedIndex];

            IdTextBox.Text = customer.Id.ToString();
            NameTextBox.Text = customer.FullName;
            //
            //СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! 
            //
            adresscontrol.UpdateAdressInfo(customer.Adress.Index, customer.Adress.Country, customer.Adress.City,
                customer.Adress.Street, customer.Adress.Building, customer.Adress.Apartament);
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////
            adressControl1.UpdateAdressInfo(customer.Adress.Index, customer.Adress.Country, customer.Adress.City,
                customer.Adress.Street, customer.Adress.Building, customer.Adress.Apartament);
            //
            //СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! СПРОСИТЬ!!! 
            //
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
                UpdateCustomerInfo(ref _currentCustomerList);                               
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
                    
                    var info = TakeInfoFromCustomer(_currentCustomerList);

                    CustomersListBox.Items[CustomersListBox.SelectedIndex] = info;
                }
            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        } 
   
        public void AddButton_Click(object sender, EventArgs e)
        {
            var newAdress = stockAdress;
            var newCustomer = new Customer(firstname, newAdress);
            _customers.Add(newCustomer);
            
            var info = TakeInfoFromCustomer(newCustomer);

            CustomersListBox.Items.Add(info);
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

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
