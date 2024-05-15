using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Метод, содержащий логику ContactControl.xaml.
    /// </summary>
    public class ContactVM : ObservableObject, INotifyPropertyChanged, IDataErrorInfo
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _contact = new Contact();

        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Оповещает при изменении параметра экземпляра класса.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public ContactVM()
        {
            _contact = new Contact();

            IsReadOnly = true;
        }

        /// <summary>
        /// Устанавливает и возвращает текущий контакт.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
            set
            {
                Name = value.Name;
                PhoneNumber = value.PhoneNumber;
                Email = value.Email;
            }
        }

        /// <summary>
        /// Возвращает и задает имя текущего контакта.
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона текущего контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задает почту текущего контакта.
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Метод, очищающий строки для добавления нового контакта.
        /// </summary>
        public void ClearText()
        {
            Name = "";
            PhoneNumber = "";
            Email = "";
        }

        /// <summary>
        /// Значение, отвечающее за значение параметра ReadOnly у некоторых элементов верстки.
        /// </summary>
        private bool _isReadonly;

        /// <summary>
        /// Возвращает и задает значение, отвечающее за значение параметра ReadOnly у некоторых.
        /// элементов верстки.
        /// </summary>
        public bool IsReadOnly
        {
            get { return _isReadonly; }
            set
            {
                _isReadonly = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Ошибка ввода, выводимая пользователю.
        /// </summary>
        private string _error;

        /// <inheritdoc/>
        public string Error
        {
            get => _error;
        }

        /// <inheritdoc/>
        public string this[string columnName]
        {
            get
            {
                _error = string.Empty;
                if (Name != null && PhoneNumber != null && Email != null)
                {
                    switch (columnName)
                    {
                        case "Name":
                            if ((Name.Length > 100))
                            {
                                _error = "Имя не должно быть длиннее 100 символов!";
                            }
                            break;
                        case "PhoneNumber":
                            foreach (char c in PhoneNumber)
                            {
                                if (!char.IsDigit(c) && c != '+' && c != '-' && c != '(' && c != ')' || PhoneNumber.Length > 100)
                                {
                                    _error = "Номер телефона должен быть не длиннее 100 " +
                                        "символов\nи может содержать только цифры или символы +-() .";
                                }
                            }
                            break;
                        case "Email":
                            if (!Email.Contains('@') || Email.Length > 100)
                            {
                                _error = "Email должен быть не длиннее 100 символов \nи должен содержать символ @ .";
                            }
                            break;
                    }
                    return _error;
                }
                else { return _error; }
            }
        }
    }
}
