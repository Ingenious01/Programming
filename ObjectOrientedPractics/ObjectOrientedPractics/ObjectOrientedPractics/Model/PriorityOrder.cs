using System;
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
        /// <summary>
        /// Ориентировачная дата доставки.
        /// </summary>
        private DateTime _deliveryDate;

        /// <summary>
        /// Ориентировачое время доставки.
        /// </summary>
        private DeliveryTime _deliveryTime;

        /// <summary>
        /// Возвращает и задаёт ориентировачную дату доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; }
         
        /// <summary>
        /// Возвращает и задаёт ориентировачное время доставки.
        /// </summary>
        public DeliveryTime DeliveryTime { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder() 
        { 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer">Клиент</param>
        /// <param name="deliveryDate">Дата доставки</param>
        /// <param name="deliveryTime">Время доставки</param>
        public PriorityOrder(Customer customer, DateTime deliveryDate, DeliveryTime deliveryTime)
            : base(customer)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="customer">Клиент</param>
        public PriorityOrder(Customer customer)
            : base(customer)
        {
            
        }
    }
}
