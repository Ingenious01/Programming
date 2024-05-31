using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Printing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using View.Model;
using View.Model.Services;
using System.Windows.Data;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace View.ViewModel
{
    /// <summary>
    /// Метод связывающий поля в форме с Contact.
    /// </summary>
    public partial class MainVM : ObservableObject, INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        public Contact CurrentContact { get; set; }

        /// <summary>
        /// Список всех контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Список всех тех контактов, которые отображаются в ListBox.
        /// </summary>
        private ObservableCollection<Contact> _displayedContacts;

        /// <summary>
        /// Экзменпляр класса SaveCommand.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Экземпляр класса LoadCommand>.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Экземпляр класса RemoveCommand>.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Экземпляр класса ChangeVisibilityForAddingCommand>.
        /// </summary>
        public ICommand ChangeVisibilityForAddingCommand { get; }

        /// <summary>
        /// Экземпляр класса ChangeVisibilityForEditingCommand>.
        /// </summary>
        public ICommand ChangeVisibilityForEditingCommand { get; }

        /// <summary>
        /// Экземпляр класса <see cref="ContactVM"/>
        /// </summary>
        private ContactVM _contactVM = new ContactVM();

        /// <summary>
        /// Возвращает экземпляр класса <see cref="ContactVM"/>
        /// </summary>
        public ContactVM ContactVM
        {
            get { return _contactVM; }
        }

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
        /// Конструкторк класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            CurrentContact = new Contact();

            ChangeVisibilityForAddingCommand = new RelayCommand(Add);
            ChangeVisibilityForEditingCommand = new RelayCommand(Edit);

            LoadCommand = new RelayCommand(Load);
            RemoveCommand = new RelayCommand(Remove);
            SaveCommand = new RelayCommand(Save);

            ContactSerializer.IsCreateFolderAndFile();
            Contacts = new ObservableCollection<Contact>();
            try
            {
                Contacts = ContactSerializer.GetData();
                _selectedIndex = -2;
            }
            catch { }

            DisplayedContacts = Contacts;

            IsEnabled = true;
            IsVisible = false;


        }

        /// <summary>
        /// Возвращает и задает список всех контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = value;
                DisplayedContacts = Contacts;
            }
        }

        /// <summary>
        /// Возвращает и задает список всех тех контактов, которые отображаются в ListBox.
        /// </summary>
        public ObservableCollection<Contact> DisplayedContacts
        {
            get { return _displayedContacts; }
            set
            {
                _displayedContacts = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Текущий индекс в ListBox.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Возвращает и задает текущий индекс в ListBox.
        /// </summary>
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set
            {
                _selectedIndex = value;
                OnPropertyChanged();

                if (_selectedIndex != -1)
                {
                    _contactVM.Contact = Contacts[SelectedIndex];
                }
            }
        }

        /// <summary>
        /// Строка, по которой осуществляется поиск среди контактов.
        /// </summary>
        private string _findText;

        /// <summary>
        /// Возвращает и задает строку, по которой осуществляется поиск среди контактов.
        /// При изменении этой строки прозиводит поиск.
        /// </summary>
        public string FindText
        {
            get { return _findText; }
            set
            {
                _findText = value;
                OnPropertyChanged();

                if (_findText != null)
                {
                    DisplayedContacts = ValueValidator.ChangeByString(Contacts, _findText,
                        ValueValidator.CheckName);

                    if (DisplayedContacts == null)
                    {
                        DisplayedContacts = Contacts;
                    }
                }
                else
                {
                    DisplayedContacts = Contacts;
                }
            }
        }

        /// <summary>
        /// Определяет какое действие происходит: добавление или изменение контакта.
        /// </summary>
        //[ObservableProperty]
        private bool _isEditing;

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
        /// Значение, отвечающее за значение параметра IsEnabled у некоторых элементов верстки.
        /// </summary>
        //[ObservableProperty]
        private bool _isEnabled;

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
        //[ObservableProperty]
        private bool _isVisible;

        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged();
            }
        }

        public void Save()
        {
            var isEditing = IsEditing;
            var name = _contactVM.Name;
            var phoneNumber = _contactVM.PhoneNumber;
            var email = _contactVM.Email;

            if (ValueValidator.CheckParameters(name, phoneNumber, email))
            {

                if (isEditing == true)
                {
                    if (_contactVM.IsReadOnly == false)
                    {
                        var index = SelectedIndex;
                        Contacts[SelectedIndex].Name = _contactVM.Name;
                        Contacts[SelectedIndex].PhoneNumber =
                            _contactVM.PhoneNumber;
                        Contacts[SelectedIndex].Email = _contactVM.Email;
                        ContactSerializer.UpdateData(Contacts);
                        Contacts = ContactSerializer.GetData();

                        IsVisible = false;
                        _contactVM.IsReadOnly = true;
                        IsEnabled = true;
                        SelectedIndex = index;
                    }
                    else
                    {
                        _contactVM.IsReadOnly = false;
                        IsEnabled = false;
                    }
                }
                else if (isEditing == false)
                {
                    Contact contact = new Contact();
                    ContactSerializer.IsCreateFolderAndFile();

                    Contact newContact = new Contact(name, phoneNumber, email);
                    Contacts.Add(newContact);

                    ContactSerializer.UpdateData(Contacts);

                    Contacts = ContactSerializer.GetData();

                    _contactVM.ClearText();

                    IsVisible = false;
                    _contactVM.IsReadOnly = true;
                    IsEnabled = true;
                }
            }
        }

        public void Remove()
        {
            try
            {
                Contacts.RemoveAt(SelectedIndex);
                ContactSerializer.UpdateData(Contacts);
                Contacts = ContactSerializer.GetData();
                _contactVM.ClearText();
            }
            catch
            {

            }
        }

        public void Load()
        {
            Contacts = ContactSerializer.GetData();
        }

        public void Add()
        {
            if (IsVisible == false)
            {
                _contactVM.ClearText();
                IsEnabled = false;
                IsVisible = true;
                _contactVM.IsReadOnly = false;
                IsEditing = false;
            }
            else if (IsVisible == true)
            {
                _contactVM.ClearText();
            }
        }

        public void Edit()
        {
            if (IsVisible == false)
            {
                IsEnabled = false;
                IsVisible = true;
                _contactVM.IsReadOnly = false;
                IsEditing = true;
            }
            else if (IsVisible == true)
            {
                _contactVM.ClearText();
            }
        }
    }
}
