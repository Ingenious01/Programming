using ObjectOrientedPractics.Model;
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
        /// Предмет типа Item.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Предмет, выбранный в ItemsListBox.
        /// </summary>
        private Item _currentItemList;

        /// <summary>
        /// Default value of Cost.
        /// </summary>
        static int firstcost = 100;

        /// <summary>
        /// Default value for Name.
        /// </summary>
        static string firstname = "Name";

        /// <summary>
        /// Default value for Info.
        /// </summary>
        static string firstdescription = "Info";

        /// <summary>
        /// Default value for Category.
        /// </summary>
        static Category firstCategory = Category.Processor;

        /// <summary>
        /// Создаёт экземпляр класса ItemsTab.
        /// </summary>
        public itemsTab()
        {
            InitializeComponent();

            categoryComboBox.DataSource = Enum.GetValues(typeof(Category));

            itemsListBox.DataSource = _items;
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
                _currentItemList = _items[itemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItemList);
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
                _currentItemList = _items[itemsListBox.SelectedIndex];

                var currentName = nameRichTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItemList.Name = currentName;                    
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
                _currentItemList = _items[itemsListBox.SelectedIndex];

                var currentCost = Convert.ToDouble(costTextBox.Text);

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItemList.Cost = currentCost;                    
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
                _currentItemList = _items[itemsListBox.SelectedIndex];

                var currentInfo = descriptionRichTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItemList.Info = currentInfo;                    
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
                _currentItemList = _items[itemsListBox.SelectedIndex];

                var currentCategory = categoryComboBox.Text;

                switch (currentCategory)
                {
                    case "Processor":
                        _currentItemList.Category = Category.Processor;
                        break;
                    case "GraphicsCard":
                        _currentItemList.Category = Category.GraphicsCard;
                        break;
                    case "Motherboard":
                        _currentItemList.Category = Category.Motherboard;
                        break;
                    case "RAM":
                        _currentItemList.Category = Category.RAM;
                        break;
                    case "PowerSupplie":
                        _currentItemList.Category = Category.PowerSupplie;
                        break;
                    case "SSD":
                        _currentItemList.Category = Category.SSD;
                        break;
                    case "HDD":
                        _currentItemList.Category = Category.HDD;
                        break;
                }
            }
        }

        /// <summary>
        /// Добавляет новый предмет в список. 
        /// </summary>        
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item(firstname, firstdescription, firstcost, firstCategory);
            _items.Add(newItem);           
        }

        /// <summary>
        /// Удаляет предмет и всю информацию о нём из списка.
        /// </summary>  
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _items.RemoveAt(itemsListBox.SelectedIndex);
                itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndex);
            }
            catch
            {
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
    }
}
