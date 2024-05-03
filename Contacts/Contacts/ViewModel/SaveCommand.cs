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
        /// Экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        private ContactVM _contactVM = new ContactVM();

        /// <summary>
        /// Принимает экземпляр класса <see cref="MainVM">.
        /// </summary>
        /// <param name="viewModel">Текущий контакт</param>
        public SaveCommand(MainVM viewModel, ContactVM contactVM)
        {
            _viewModel = viewModel;
            _contactVM = contactVM;
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
            var isEditing = _viewModel.IsEditing;
            var name = _contactVM.Name;
            var phoneNumber = _contactVM.PhoneNumber;
            var email = _contactVM.Email;

            if (ValueValidator.CheckParameters(name, phoneNumber, email))
            {
            
                if (isEditing == true)
                {
                    if (_contactVM.IsReadOnly == false)
                    {
                        var index = _viewModel.SelectedIndex;
                        _viewModel.Contacts[_viewModel.SelectedIndex].Name = _contactVM.Name;
                        _viewModel.Contacts[_viewModel.SelectedIndex].PhoneNumber =
                            _contactVM.PhoneNumber;
                        _viewModel.Contacts[_viewModel.SelectedIndex].Email = _contactVM.Email;
                        ContactSerializer.UpdateData(_viewModel.Contacts);
                        _viewModel.Contacts = ContactSerializer.GetData();

                        _viewModel.IsVisible = false;
                        _contactVM.IsReadOnly = true;
                        _viewModel.IsEnabled = true;
                        _viewModel.SelectedIndex = index;
                    }
                    else
                    {
                        _contactVM.IsReadOnly = false;
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
                    _contactVM.ClearText();

                    _viewModel.IsVisible = false;
                    _contactVM.IsReadOnly = true;
                    _viewModel.IsEnabled = true;
                }
            }
        }
    }
}
