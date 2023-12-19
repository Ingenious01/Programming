using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
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

        public static BindingList<Item> ChangeByString (BindingList<Item> items, string str, Func<Item, string, bool> find)
        {
            if (str == "")
            {
                return null;
            }

            BindingList<Item> newList = new BindingList<Item>();

            foreach (var item in items)
            {
                if (find (item, str))
                {
                    newList.Add (item);
                }
            }

            return newList;
        }

        public static BindingList<Item> SortByName (BindingList<Item> items)
        {
            List<Item> ItemsList = new List<Item>(items); // Создаем список из элементов BindingList

            ItemsList.Sort((x, y) => x.Name.CompareTo(y.Name)); // Сортируем элементы по свойству Name

            items.Clear(); // Очищаем BindingList

            foreach (var item in ItemsList)
            {
                items.Add(item); // Добавляем отсортированные элементы обратно в BindingList
            }

            return items;
        }

        public static bool SortByCost (Item item1, Item item2)
        {
            if (item1.Cost < item2.Cost)
            { 
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool SortByCategory(Item item1, Item item2)
        {

            if ((int)item1.Category < (int)item2.Category)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool SortById(Item item1, Item item2)
        {

            if ((int)item1.Id < (int)item2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static BindingList<Item> SortBySign (BindingList<Item> items, Func<Item, Item, bool> compare)
        {
            for (int i =0; i < items.Count - 1; i++) 
            {
                for (int j =0; j < items.Count -1; j++)
                {
                    if (compare(items[j], items[j + 1]))
                    {
                        Item temp = items[j];
                        items[j] = items[j + 1];
                        items[j+1] = temp;
                    }
                }                
            }
            return items;
        }        
    }
}
