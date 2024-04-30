using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using View.Model;
using View.ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Экземпляр класса ChangeVisibilityForAddingCommand>.
        /// </summary>
        private ICommand _changeVisibilityForAddingCommand;

        /// <summary>
        /// Экземпляр класса ChangeVisibilityForEditingCommand>.
        /// </summary>
        private ICommand _changeVisibilityForEditingCommand;

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

        public ContactControl()
        {
            _contact = new Contact();
            _changeVisibilityForAddingCommand = new ChangeVisibilityForAddingCommand(this);
            _changeVisibilityForEditingCommand = new ChangeVisibilityForEditingCommand(this);

            InitializeComponent();
        }

        public Contact Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                Name = _contact.Name;
                PhoneNumber = _contact.PhoneNumber;
                Email = _contact.Email;
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
        /// Определяет какое действие происходит: добавление или изменение контакта.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Задает и возвращает значение, которое определяет какое действие
        /// происходит: добавление или изменение контакта.
        /// </summary>
        public bool IsEditing
        {
            get { return _isEditing; }
            set
            {
                _isEditing = value;
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
        /// Возвращает и задает значение, отвечающее за значение параметра ReadOnly у некоторых
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
        /// Значение, отвечающее за значение параметра IsEnabled у некоторых элементов верстки.
        /// </summary>
        private bool _isEnabled;

        /// <summary>
        /// Возвращает и задает значение, отвечающее за значение параметра IsEnable у некоторых
        /// элементов верстки.
        /// </summary>
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Значение, отвечающее за значение параметра Visivility у некоторых элементов верски.
        /// </summary>
        private bool _isVisible;

        /// <summary>
        /// Возвращает и задает значение, отвечающее за значение параметра Visibility у некоторых
        /// элементов верски.
        /// </summary>
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged();
            }
        }
    }
}
