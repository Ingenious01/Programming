using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, реализующий изменение уже существующих экземпляров класса <see cref="Contact"/>
    /// </summary>
    public class EditCommand: ICommand
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM">.
        /// </summary>
        private MainVM _viewModel;

        /// <summary>
        /// Принимает экземпляр класса <see cref="MainVM">.
        /// </summary>
        /// <param name="viewModel">Текущий контакт</param>
        public EditCommand(MainVM viewModel)
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
        /// Меняет параметры экземпляра класса <see cref="Contact"/> и перезаписывает данные в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (_viewModel.IsReadOnly == false)
            {
                
                _viewModel.Contacts[_viewModel.SelectedIndex].Name = _viewModel.Name;
                _viewModel.Contacts[_viewModel.SelectedIndex].PhoneNumber =
                    _viewModel.PhoneNumber;
                _viewModel.Contacts[_viewModel.SelectedIndex].Email = _viewModel.Email;
                ContactSerializer.UpdateData(_viewModel.Contacts);
                _viewModel.Contacts = ContactSerializer.GetData();

                _viewModel.IsReadOnly = true;
                _viewModel.IsEnabled = true;
            }
            else
            {
                _viewModel.IsReadOnly = false;
                _viewModel.IsEnabled = false;
            }
        }
    }
}
