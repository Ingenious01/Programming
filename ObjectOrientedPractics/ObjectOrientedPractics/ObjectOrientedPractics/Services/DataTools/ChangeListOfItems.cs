using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.Services.DataTools
{
    static class ChangeListOfItems
    {
        public static bool CheckName (Item item, string str)
        {            
            if (item.Name.ToLower().Contains(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckCategoryOfItem (Item item, string str)
        {
            Category category = (Category)Enum.Parse(typeof(Category), str);

            if (item.Category == category)
            {
                return true;
            }

            else
            { 
                return false; 
            }
        }

        public static BindingList<Item> ChangeByString (BindingList<Item> items, string str, Func<Item, string, bool> compare)
        {
            BindingList<Item> newList = new BindingList<Item>();

            foreach (var item in items)
            {
                if (compare (item, str))
                {
                    newList.Add (item);
                }
            }

            return newList;
        }
    }
}
