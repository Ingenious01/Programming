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
    public class LoadCommand: ICommand
    {
        private MainVM _viewModel;

        public LoadCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var contact = ContactSerializer.GetData();

            _viewModel.Name = contact.Name;
            _viewModel.PhoneNumber = contact.PhoneNumber;
            _viewModel.Email = contact.Email;
        }
    }
}
