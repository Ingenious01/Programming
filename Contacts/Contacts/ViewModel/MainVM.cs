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

namespace View.ViewModel
{
    /// <summary>
    /// Метод связывающий поля в форме с Contact.
    /// </summary>
    public class MainVM: INotifyPropertyChanged
    {
        /// <summary>
        /// Текущий контакт.
        /// </summary>
        public Contact CurrentContact { get; set; }

        /// <summary>
        /// Список всех контактов.
        /// </summary>
        private List<Contact> _contacts;

        /// <summary>
        /// Список всех тех контактов, которые отображаются в ListBox.
        /// </summary>
        private List<Contact> _displayedContacts;        

        /// <summary>
        /// Экзменпляр класса SaveCommand.
        /// </summary>
        private ICommand _saveCommand;

        /// <summary>
        /// Экземпляр класса LoadCommand>.
        /// </summary>
        private ICommand _loadCommand;

        /// <summary>
        /// Экземпляр класса RemoveCommand>.
        /// </summary>
        private ICommand _removeCommand;

        /// <summary>
        /// Экземпляр класса ChangeVisibilityForAddingCommand>.
        /// </summary>
        private ICommand _changeVisibilityForAddingCommand;

        /// <summary>
        /// Экземпляр класса ChangeVisibilityForEditingCommand>.
        /// </summary>
        private ICommand _changeVisibilityForEditingCommand;

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
            _loadCommand = new LoadCommand(this);

            _removeCommand = new RemoveCommand(this, ContactVM);
            _changeVisibilityForAddingCommand = new ChangeVisibilityForAddingCommand(this, ContactVM);
            _changeVisibilityForEditingCommand = new ChangeVisibilityForEditingCommand(this, ContactVM);
            _saveCommand = new SaveCommand(this, ContactVM);

            ContactSerializer.IsCreateFolderAndFile();
            Contacts = new List<Contact>();
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
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set
            {
                _contacts = value;
                OnPropertyChanged();
                DisplayedContacts = Contacts;
            }
        }

        /// <summary>
        /// Возвращает и задает список всех тех контактов, которые отображаются в ListBox.
        /// </summary>
        public List<Contact> DisplayedContacts
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

        /// <summary>
        /// Свойство сохранения данных.
        /// </summary>
        public ICommand SaveCommand => _saveCommand;

        /// <summary>
        /// Свойство загрузки данных.
        /// </summary>
        public ICommand LoadCommand => _loadCommand;

        /// <summary>
        /// Свойство удаления данных.
        /// </summary>
        public ICommand RemoveCommand => _removeCommand;

        /// <summary>
        /// Свойство изменения параметра Visibility у некоторых элементов при изменении
        /// параметров клиента.
        /// </summary>
        public ICommand ChangeVisibilityForAddingCommand => _changeVisibilityForAddingCommand;

        /// <summary>
        /// Свойство изменения параметра Visibility у некоторых элементов при изменении
        /// параметров контакта.
        /// </summary>
        public ICommand ChangeVisibilityForEditingCommand => _changeVisibilityForEditingCommand;
    }
}
