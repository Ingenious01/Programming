using ObjectOrientedPractics.Services;
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

        /// <summary>
        /// Покупатель, выбранный в CustomersListBox.
        /// </summary>
        private Customer _currentCustomerList;
        
        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstname = "Stock Name";

        /// <summary>
        /// Default value for Adress.
        /// </summary>
        static string firstadress = "Adress";

        /// <summary>
        /// The first default Customer.
        /// </summary>             
        Customer stockCustomer = new Customer(firstname, firstadress);

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

        /// <summary>
        /// Создаёт строку с информацией о покупателе.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <returns>Возвращает строку с информацией о клиенте.</returns>
        private static string TakeInfoFromCustomer(Customer customer)
        {
             var info = $"{customer.Id}. " + 
                $"Name={customer.FullName}, " + 
                $"Adress={customer.Adress} ";

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
            AdressRichTextBox.Text = customer.Adress;
        }

        /// <summary>
        /// Очищает информацию о покупателе.
        /// </summary>
        private void ClearCustomerInfo()
        {
            IdTextBox.Text = " ";
            NameTextBox.Text = " ";
            AdressRichTextBox.Text = " ";            

            NameTextBox.BackColor = System.Drawing.Color.White;
            AdressRichTextBox.BackColor = System.Drawing.Color.White;
        }
        
        /// <summary>
        /// При нажатии на конкретного покупателя в списке покупателей даёт о нём информацию.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
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
        /// При изменении символа в строке адреса окрашивает её в белый цвет.
        /// </summary>   
        private void AdressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            AdressRichTextBox.BackColor = System.Drawing.Color.White;
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

        /// <summary>
        /// При нажатии пробела присваивает адрес клиенту из AdressRichTextBox. 
        /// Если не получается, окрашивает background поля AdressRichTextBox в красный цвет.
        /// </summary>  
        private void AdressRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                _currentCustomerList = _customers[CustomersListBox.SelectedIndex];

                var currentAdress = AdressRichTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentCustomerList.Adress = currentAdress;

                    var info = TakeInfoFromCustomer(_currentCustomerList);

                    CustomersListBox.Items[CustomersListBox.SelectedIndex] = info;
                }
            }
            catch
            {
                AdressRichTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        /// <summary>
        /// Добавляет нового клинта в список.
        /// </summary>        
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer(firstname, firstadress);
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
    }
}
