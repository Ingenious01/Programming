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
    public class Cart : INotifyPropertyChanged
    {
        /// <summary>
        /// Список предметов в корзине покупателя.
        /// </summary>
        private List<Item> _listOfItems;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Задаёт и возращает список предметов в корзине покупателя.
        /// </summary>
        public List<Item> ListOfItems
        {
            get => _listOfItems;
            set
            {
                _listOfItems = value;

                OnPropertyChanged();
            }    

        }

        /// <summary>
        /// Считает общую стоимость всех пердметов в корзине у покупателя.
        /// </summary>
        public double Amount()
        {
            double total = 0;

            foreach (var item in _listOfItems)
            {
                if (item != null)
                {
                    total = total + item.Cost;
                }
            }

            return total;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>    
        public Cart()
        {
            ListOfItems = new List<Item>();
        }
    }
}
