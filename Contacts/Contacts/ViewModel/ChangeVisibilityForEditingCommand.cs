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
        private MainVM _viewModel;

        /// <summary>
        /// Принимает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        /// <param name="viewModel">Текущий контакт</param>
        public ChangeVisibilityForEditingCommand(MainVM viewModel)
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
        /// В зависимости от значения поля Visible в <see cref="MainVM"/> меняет его значение.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {           
            if (_viewModel.IsVisible == false)
            {
                _viewModel.IsEnabled = false;
                _viewModel.IsVisible = true;
                _viewModel.IsReadOnly = false;
                _viewModel.IsEditing = true;
            }
            else if (_viewModel.IsVisible == true)
            {
                _viewModel.ClearText();
            }
        }
    }
}
