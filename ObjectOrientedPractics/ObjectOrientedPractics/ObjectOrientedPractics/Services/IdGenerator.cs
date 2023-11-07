using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    static class IdGenerator
    {
        /// <summary>
        /// Счётчик индивидуального номера для товаров.
        /// </summary>
        static int currentItemID = 0;

        /// <summary>
        /// Метод, задающий товару его индивидуальный номер(Id).
        /// </summary>
        public static int GetNextItemId()
        {
            currentItemID++;
            return currentItemID;
        }

        /// <summary>
        /// Счётчик индивидуального номера для покупателей.
        /// </summary>
        static int currentCustomerID = 0;

        /// <summary>
        /// Метод, задающий покупателю его индивидуальный номер(Id).
        /// </summary>
        public static int GetNextCustomerId()
        {
            currentCustomerID++;
            return currentCustomerID;
        }

        /// <summary>
        /// Счётчик индивидуального номера для заказов.
        /// </summary>
        static int currentOrderID = 0;

        /// <summary>
        /// Метод, задающий заказу его индивидуальный номер(Id).
        /// </summary>
        public static int GetNextOrderId()
        {
            currentCustomerID++;
            return currentCustomerID;
        }
    }
}
