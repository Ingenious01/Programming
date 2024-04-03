using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model.Services;
using View.Model;
using System.Windows.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Класс, соуществляющий удаление элемента из <see cref="MainVM.Contacts"/>
    /// </summary>
    public class RemoveCommand: ICommand
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM">.
        /// </summary>
        private MainVM _viewModel;

        /// <summary>
        /// Принимает экземпляр класса <see cref="MainVM">.
        /// </summary>
        /// <param name="viewModel">Текущий контакт</param>
        public RemoveCommand(MainVM viewModel)
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
        /// Удаляет контакт и записывает изменения в файл.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            try
            {
                _viewModel.Contacts.RemoveAt(_viewModel.SelectedIndex);
                ContactSerializer.UpdateData(_viewModel.Contacts);
                _viewModel.Contacts = ContactSerializer.GetData();
                _viewModel.ClearText();
            } 
            catch
            {

            }
        }
    }
}
