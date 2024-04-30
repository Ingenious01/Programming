using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, позволяющий менять поле Visibility в класса <see cref="MainVM"/> при изменении
    /// параметров существующего контакта./>
    /// </summary>
    public class ChangeVisibilityForEditingCommand: ICommand
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        private ContactControl _contactControl;

        /// <summary>
        /// Экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        private MainVM _viewModel;

        /// <summary>
        /// Принимает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        /// <param name="viewModel">Текущий контакт</param>
        public ChangeVisibilityForEditingCommand(ContactControl contactControl)
        {
            _contactControl = contactControl;
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
        /// В зависимости от значения поля Visible в <see cref="MainVM"/> меняет его значение.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {           
            if (_contactControl.IsVisible == false)
            {
                _contactControl.IsEnabled = false;
                _contactControl.IsVisible = true;
                _contactControl.IsReadOnly = false;
                _contactControl.IsEditing = true;
            }
            else if (_contactControl.IsVisible == true)
            {
                _contactControl.ClearText();
            }
        }
    }
}
