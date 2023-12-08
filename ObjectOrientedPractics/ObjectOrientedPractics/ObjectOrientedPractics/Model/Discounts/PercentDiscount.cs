using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : PointsDiscount, IDiscount, INotifyPropertyChanged
    {
        private Category _category;

        private double _totalSpent =0;

        private double _discount =0.0;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public double TotalSpent
        {
            set { _totalSpent = value; OnPropertyChanged(); }
            get { return _totalSpent; }
        }

        public double Discount
        {
            set { _discount = value; OnPropertyChanged(); }
            get { return _discount; }
        }        

        public override int Calculate(List<Item> items)
        {
            if (Amount(items) <= 0)
            {
                return 0;
            }

            double amount = 0;
            foreach (var item in items)
            {
                if (item.Category == _category)
                {
                    amount = amount + item.Cost;
                }
            }

            int discount = (int)((amount * Discount)/10);
            return discount;
        }

        public override int Apply(List<Item> items)
        {
            if (Amount(items) <= 0)
            {
                return 0;
            }

            int discount =Calculate(items);

            double price = Amount(items);

            int newPrice = (int)(price - discount);

            return newPrice;
        }

        public override void Update(List<Item> items)
        {
            TotalSpent = TotalSpent + Amount(items);

            Discount = Math.Floor((TotalSpent / 10000) * 10) / 10;
            
            if (Discount >1)
            {
                Discount = 1;
            }
        }

        public override string ToString()
        {
            double discount = Discount *10;
            Category category = _category;

            string info = $"Процентная в катеоргии {category} - {discount}%";
            return info;
        }

        public PercentDiscount(Category category)
        {
            _category = category;
        }
    }
}
