using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel
{
    public class MainVM: INotifyPropertyChanged
    {
        private Contact _contact;
        private ICommand _saveCommand;
        private ICommand _loadCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainVM()
        {
            _contact = new Contact();
            _saveCommand = new SaveCommand(this);
            _loadCommand = new LoadCommand(this);
        }

        public ICommand SaveCommand => _saveCommand;

        public ICommand LoadCommand => _loadCommand;

        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged();
            }
        }

        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged();
            }
        }        
    }
}
