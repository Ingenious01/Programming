using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;
using System.IO;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Содержит метод, считывающий информацию из файла.
    /// </summary>
    public class LoadCommand: ICommand
    {
        /// <summary>
        /// Экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        private MainVM _viewModel;

        /// <summary>
        /// Принимает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        /// <param name="viewModel">Текущий контакт</param>
        public LoadCommand(MainVM viewModel)
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
        /// Считывание данных из файла.
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _viewModel.Contacts = ContactSerializer.GetData();
        }
    }
}
