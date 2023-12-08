using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о товаре.
    /// </summary>
    public class Item : INotifyPropertyChanged
    {
        /// <summary>
        /// Индивидуальный номер товара.
        /// </summary>
        private int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Возвращает и задаёт индивидуальный номер товара.
        /// </summary>
        public int Id
        {
            get => _id;
            set => _id = value;            
        }

        /// <summary>
        /// Возвращает и задаёт название товара.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));

                _name = value;

                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            var info = $"{Id}. " +
               $"Name={Name}, " +
               $"Cost ={Cost} ";

            return info;
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Info));                

                _info = value;

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара. Стоимость должна быть больше 0.
        /// </summary>
        public double Cost
        {
            get => _cost;

            set
            {
                if (value > 0)
                    _cost = value;
                else
                    throw new ArgumentException("Укажите корректную цену");
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category { get; set; }


        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>    
        /// <param name="name">Название товара</param>
        /// <param name="info">Информация о товаре</param>
        /// <param name="cost">Стоимость товара</param>
        /// /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Id = IdGenerator.GetNextItemId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }
    }
}
