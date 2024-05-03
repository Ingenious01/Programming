using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View.Model;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();

            MainVM mainVm = new MainVM();

            ContactVM contactVM = new ContactVM();

            this.DataContext = contactVM.Contact;
        }

        /// <summary>
        /// Проверка вводимого символа (разрешить цифры, скобки, плюс и минус).Предотвращение ввода недопустимых символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {            
            if (!char.IsDigit(e.Text, e.Text.Length - 1) && e.Text != "(" && e.Text != ")" && e.Text != "+" && e.Text != "-")
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Проверка вставляемого текста (разрешить цифры, скобки, плюс и минус).Предотвращение вставки недопустимых символов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(DataFormats.Text))
            {
                string pastedText = e.DataObject.GetData(DataFormats.Text) as string;

                if (!string.IsNullOrEmpty(pastedText) && !pastedText.All(c => char.IsDigit(c) || c == '(' || c == ')' || c == '+' || c == '-'))
                {
                    e.CancelCommand();
                }
            }
        }
    }
}
