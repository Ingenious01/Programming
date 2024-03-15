using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    class SaveCommand : ICommand
    {
        private MainVM _viewModel;

        public SaveCommand(MainVM viewModel)
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
            ContactSerializer.IsCreateFolderAndFile();

            var name = _viewModel.Name;
            var phoneNumber = _viewModel.PhoneNumber;
            var email = _viewModel.Email;
            Contact contact = new Contact(name,phoneNumber, email);

            ContactSerializer.UpdateData(contact);
        }
    }
}
