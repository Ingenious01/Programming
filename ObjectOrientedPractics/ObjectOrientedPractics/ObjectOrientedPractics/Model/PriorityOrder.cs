using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        private DateTime _deliveryDate;

        private DeliveryTime _deliveryTime;

        public DateTime DelivertDate { get; set; }

        public DeliveryTime DeliveryTime { get; set; }

        public PriorityOrder() 
        { 
        }

        public PriorityOrder(Customer customer, DateTime deliveryDate, DeliveryTime deliveryTime)
            : base(customer)
        {
            _deliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
