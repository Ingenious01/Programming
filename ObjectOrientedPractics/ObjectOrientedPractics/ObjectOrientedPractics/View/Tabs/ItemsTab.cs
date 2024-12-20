﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services.DataTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class itemsTab : UserControl
    {
        /// <summary>
        /// Список предметов в магазине типа <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        private BindingList<Item> _displayedItems = new BindingList<Item>();

        public BindingList<Item> DisplayedItems 
        { 
            get 
            { 
                return _displayedItems; 
            }
            set 
            { 
                _displayedItems = value; 
            } 
        }
        /// <summary>
        /// Предмет, выбранный в ItemsListBox.
        /// </summary>
        private Item _currentItem;        

        /// <summary>
        /// Создаёт экземпляр класса ItemsTab.
        /// </summary>
        public itemsTab()
        {
            InitializeComponent();

            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            itemsListBox.DataSource = _items;

            DisplayedItems = null;

            orderbyComboBox.Items.Add("By Name");

            orderbyComboBox.Items.Add("By Category");

            orderbyComboBox.Items.Add("By Cost");

            orderbyComboBox.Items.Add("By Id");

            orderbyComboBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// Создаёт строчку с информацией о предмете.
        /// </summary>
        /// <param name="item">Предмет</param>
        /// <returns>Возвращает строку с информацией о предмете</returns>
        private static string TakeInfoFromItem(Item item)
        {
            var info = $"{item.Id}. " + $"{item.Name}, " + $"{item.Category}, " + $"{item.Cost}";

            return info;
        }

        /// <summary>
        /// Обновляет параметры предмета.
        /// </summary>
        /// <param name="item">Предмет</param>
        private void UpdateItemInfo(Item item)
        {
            idTextBox.Text = item.Id.ToString();
            costTextBox.Text = item.Cost.ToString();
            nameRichTextBox.Text = item.Name;
            descriptionRichTextBox.Text = item.Info;
            categoryComboBox.Text = item.Category.ToString();
        }

        /// <summary>
        /// Очищает информацию о предмете.
        /// </summary>
        private void ClearItemInfo()
        {
            idTextBox.Text = " ";
            costTextBox.Text = " ";
            nameRichTextBox.Text = " ";
            descriptionRichTextBox.Text = " ";

            costTextBox.BackColor = System.Drawing.Color.White;
            descriptionRichTextBox.BackColor = System.Drawing.Color.White;
            nameRichTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При нажатии на конкретный предмет в списке предметов даёт о нём информацию.
        /// </summary>
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem = _items[itemsListBox.SelectedIndex];

                if (DisplayedItems != null)
                {
                    _currentItem = DisplayedItems[itemsListBox.SelectedIndex];

                    foreach (var item in _items)
                    {
                        if (_currentItem.Id == item.Id)
                        {
                            _currentItem = item;
                        }
                    }
                }

                UpdateItemInfo(_currentItem);
            }
            catch
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// При изменении символа в строке цены окрашивает её в белый цвет.
        /// </summary>  
        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            costTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При изменении символа в строке имени окрашивает её в белый цвет.
        /// </summary>  
        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            nameRichTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При изменении символа в строке описания окрашивает её в белый цвет.
        /// </summary>  
        private void DescriptionRichTextBox1_TextChanged(object sender, EventArgs e)
        {
            descriptionRichTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При нажатии пробела присваивает название предмету из NameRichTextBox. 
        /// Если не получается, окрашивает background поля NameRIchTextBox в красный цвет.
        /// </summary>   
        private void nameRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (_currentItem == null)
                {
                    return;
                }

                var currentName = nameRichTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItem.Name = currentName;                    
                }
            }
            catch
            {
                nameRichTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При нажатии пробела присваивает цену предмету из CostTextBox. 
        /// Если не получается, окрашивает background поля CostTextBox в красный цвет.
        /// </summary>  
        private void costTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (_currentItem == null)
                {
                    return;
                }

                var currentCost = Convert.ToDouble(costTextBox.Text);

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItem.Cost = currentCost;                    
                }
            }
            catch
            {
                costTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        /// <summary>
        /// При нажатии пробела присваивает описание предмету из DescriptionRichTextBox. 
        /// Если не получается, окрашивает background поля DescriptionRichTextBox в красный цвет.
        /// </summary>  
        private void descriptionRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (_currentItem == null)
                {
                    return;
                }

                var currentInfo = descriptionRichTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItem.Info = currentInfo;                    
                }
            }
            catch
            {
                descriptionRichTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }
        /// <summary>
        /// При изменении значения в CategoryComboBox присваивает его значение параметру category товара. 
        /// </summary> 
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex >= 0)
            {
                if (_currentItem == null)
                {
                    return;
                }

                var currentCategory = categoryComboBox.Text;

                switch (currentCategory)
                {
                    case "Processor":
                        _currentItem.Category = Category.Processor;
                        break;
                    case "GraphicsCard":
                        _currentItem.Category = Category.GraphicsCard;
                        break;
                    case "Motherboard":
                        _currentItem.Category = Category.Motherboard;
                        break;
                    case "RAM":
                        _currentItem.Category = Category.RAM;
                        break;
                    case "PowerSupplie":
                        _currentItem.Category = Category.PowerSupplie;
                        break;
                    case "SSD":
                        _currentItem.Category = Category.SSD;
                        break;
                    case "HDD":
                        _currentItem.Category = Category.HDD;
                        break;
                }
            }
        }

        /// <summary>
        /// Добавляет новый предмет в список. 
        /// </summary>        
        private void AddButton_Click(object sender, EventArgs e)
        {
            costTextBox.Enabled = true;
            categoryComboBox.Enabled = true;
            descriptionRichTextBox.Enabled = true;
            nameRichTextBox.Enabled = true;
            removeButton.Enabled = true;
            findItemLabel.Enabled = true;
            findItemTextBox.Enabled = true;
            orderbyComboBox.Enabled = true;

            /// <summary>
            /// Default value of Cost.
            /// </summary>
            int firstcost = 100;

            /// <summary>
            /// Default value for Name.
            /// </summary>
            string firstname = "Name";

            /// <summary>
            /// Default value for Info.
            /// </summary>
            string firstdescription = "Info";

            /// <summary>
            /// Default value for Category.
            /// </summary>
            Category firstCategory = Category.Processor;

            var newItem = new Item(firstname, firstdescription, firstcost, firstCategory);
            _items.Add(newItem);
            UpdateItemInfo(_items[itemsListBox.SelectedIndex]);

            if (DisplayedItems != null)
            {
                DisplayedItems.Add(newItem);
                UpdateItemInfo(DisplayedItems[itemsListBox.SelectedIndex]);
            }            
        }

        /// <summary>
        /// Удаляет предмет и всю информацию о нём из списка.
        /// </summary>  
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DisplayedItems != null)
                {
                    _currentItem = DisplayedItems[itemsListBox.SelectedIndex];

                    foreach (var item in _items)
                    {
                        if (_currentItem.Id == item.Id)
                        {
                            DisplayedItems.RemoveAt(itemsListBox.SelectedIndex);
                            _items.Remove(item);
                            itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);                            
                        }
                    }
                }

                else
                {
                    _items.RemoveAt(itemsListBox.SelectedIndex);
                    itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
                }                
            }
            catch
            {

            }

            if (itemsListBox.SelectedIndex < 0)
            {
                costTextBox.Enabled = false;
                categoryComboBox.SelectedItem = null;
                categoryComboBox.Enabled = false;
                descriptionRichTextBox.Enabled = false;
                nameRichTextBox.Enabled = false;
                removeButton.Enabled = false;

                ClearItemInfo();
            }
        }

        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {
                if (value != null)
                {
                    _items = value;

                    itemsListBox.DataSource = _items;
                }
                        
            }
        }

        private void findItemTextBox_TextChanged(object sender, EventArgs e)
        {
            DisplayedItems = null;
            DisplayedItems = ChangeListOfItems.ChangeByString(Items, findItemTextBox.Text, ChangeListOfItems.CheckName);

            if (DisplayedItems != null)
            {
                itemsListBox.DataSource = null;
                itemsListBox.DataSource = DisplayedItems;
                return;
            }

            itemsListBox.DataSource = null;
            itemsListBox.DataSource = _items;
        }

        private void orderbyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (orderbyComboBox.Text)
            {
                case "By Name":
                    if (itemsListBox.DataSource == DisplayedItems)
                    {
                        DisplayedItems = ChangeListOfItems.SortByName(DisplayedItems);
                        itemsListBox.DataSource = DisplayedItems;
                    }
                    else if (itemsListBox.DataSource == Items)
                    {
                        Items = ChangeListOfItems.SortByName(Items);
                        itemsListBox.DataSource = Items;
                    }
                    break;

                case "By Cost":
                    if (itemsListBox.DataSource == DisplayedItems)
                    {
                        DisplayedItems = ChangeListOfItems.SortBySign(DisplayedItems, ChangeListOfItems.SortByCost);
                        itemsListBox.DataSource = DisplayedItems;
                    }
                    else if (itemsListBox.DataSource == Items)
                    {
                        Items = ChangeListOfItems.SortBySign(Items, ChangeListOfItems.SortByCost);
                        itemsListBox.DataSource = Items;
                    }
                    break;

                case "By Category":
                    if (itemsListBox.DataSource == DisplayedItems)
                    {
                        DisplayedItems = ChangeListOfItems.SortBySign(DisplayedItems, ChangeListOfItems.SortByCategory);
                        itemsListBox.DataSource = DisplayedItems;
                    }
                    else if (itemsListBox.DataSource == Items)
                    {
                        Items = ChangeListOfItems.SortBySign(Items, ChangeListOfItems.SortByCategory);
                        itemsListBox.DataSource = Items;
                    }
                    break;

                case "By Id":
                    if (itemsListBox.DataSource == DisplayedItems)
                    {
                        DisplayedItems = ChangeListOfItems.SortBySign(DisplayedItems, ChangeListOfItems.SortById);
                        itemsListBox.DataSource = DisplayedItems;
                    }
                    else if (itemsListBox.DataSource == Items)
                    {
                        Items = ChangeListOfItems.SortBySign(Items, ChangeListOfItems.SortById);
                        itemsListBox.DataSource = Items;
                    }
                    break;
            }

        }
    }
}
