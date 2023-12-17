using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        private int _points;

        private decimal _discount;
        public int Points
        {            
            get => _points;
        }

        public virtual Category Category { get { return Category.Processor; } }
        public virtual double Amount(List<Item> items)
        {
            double result = 0;

            foreach (var item in items) 
            {
                result = result + item.Cost;
            }

            return result;
        }

        public virtual int Calculate (List<Item> items)
        {
            if (Amount(items) <= 0)
            {
                return 0;
            }
            
            double amount = 0;

            foreach(var item in items)
            {
                amount = amount + item.Cost;
            }
            
            int Maxdiscount =(int)(amount *0.3);

            int discount;
            if (_points >= Maxdiscount)
            {
                discount = Maxdiscount;
            }
            else
            {
                discount = _points;
            }

            return discount;
        }

        public virtual int Apply(List<Item> items)
        {
            if (Amount(items) <= 0)
            {
                return 0;
            }

            int discount = Calculate(items);

            if(discount == 0)
            {
                return 0;
            }

            _points = _points - discount;

            int amount = (int)Amount(items);
            int newPrice = amount - discount;

            return newPrice;
        }

        public virtual void Update(List<Item> items)
        {
            int discount = Calculate(items);
            _points = _points - discount;
            _points = _points + (int)(Amount(items)*0.1);
        }

        public override string ToString()
        {
            int points = _points;
            string info = $"Накопительная - {points} баллов";
            return info;
        }

        public PointsDiscount()
        {

        }
    }
}
