using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Содержит метод, вызывающиеся при нажатии на кнопку Save.
    /// </summary>
    class SaveCommand : ICommand
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM">.
        /// </summary>
        private MainVM _viewModel;

        /// <summary>
        /// Принимает экземпляр класса <see cref="MainVM">.
        /// </summary>
        /// <param name="viewModel">Текущий контакт</param>
        public SaveCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
        }

        /// <inheritdoc/>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// Возращает возможность выполнения метода в классе.
        /// </summary>
        /// <param name="parameter">Входной параметр</param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Записывает данные о контакте в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            var fawf = _viewModel.Contacts;
            var name = _viewModel.Name;
            var phoneNumber = _viewModel.PhoneNumber;
            var email = _viewModel.Email;
            var isEditing = _viewModel.IsEditing;
            fawf = _viewModel.Contacts;

            if (isEditing == true)
            {
                if (_viewModel.IsReadOnly == false)
                {
                    var index = _viewModel.SelectedIndex;
                    _viewModel.Contacts[_viewModel.SelectedIndex].Name = _viewModel.Name;
                    _viewModel.Contacts[_viewModel.SelectedIndex].PhoneNumber =
                        _viewModel.PhoneNumber;
                    _viewModel.Contacts[_viewModel.SelectedIndex].Email = _viewModel.Email;
                    ContactSerializer.UpdateData(_viewModel.Contacts);
                    _viewModel.Contacts = ContactSerializer.GetData();

                    _viewModel.IsVisible = false;
                    _viewModel.IsReadOnly = true;
                    _viewModel.IsEnabled = true;
                    _viewModel.SelectedIndex = index;
                }
                else
                {
                    _viewModel.IsReadOnly = false;
                    _viewModel.IsEnabled = false;
                }
            }
            else if (isEditing == false)
            {
                ContactSerializer.IsCreateFolderAndFile();

                Contact newContact = new Contact(name, phoneNumber, email);
                _viewModel.Contacts.Add(newContact);

                ContactSerializer.UpdateData(_viewModel.Contacts);

                _viewModel.Contacts = ContactSerializer.GetData();
                _viewModel.ClearText();

                _viewModel.IsVisible = false;
                _viewModel.IsReadOnly = true;
                _viewModel.IsEnabled = true;
            }
        }
    }
}
