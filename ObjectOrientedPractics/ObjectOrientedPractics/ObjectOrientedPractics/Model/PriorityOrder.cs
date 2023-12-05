﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        private DateTime _deliveryDate;

        private DeliveryTime _deliveryTime;

        public DateTime DeliveryDate { get; set; }

        public DeliveryTime DeliveryTime { get; set; }

        public PriorityOrder() 
        { 
        }

        public PriorityOrder(Customer customer, DateTime deliveryDate, DeliveryTime deliveryTime)
            : base(customer)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        public PriorityOrder(Customer customer)
            : base(customer)
        {

        }
    }
}
