using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет шаблон пользовательского интерфейса ItemsTab.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Предмет типа Item.
        /// </summary>
        private List<Item> _items = new List<Item>();

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
        /// The first default Item.
        /// </summary>  
        Item stockItem = new Item(firstname, firstdescription, firstcost, firstCategory);

        /// <summary>
        /// Создаёт экземпляр класса ItemsTab.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _items.Add(stockItem);
            var info = TakeInfoFromItem(stockItem);

            ItemsListBox.Items.Add(info);

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));          
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
        private void UpdateItemInfo(ref Item item)
        {
            item = _items[ItemsListBox.SelectedIndex];

            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameRichTextBox.Text = item.Name;
            DescriptionRichTextBox.Text = item.Info;
            CategoryComboBox.Text=item.Category.ToString();
        }

        /// <summary>
        /// Очищает информацию о предмете.
        /// </summary>
        private void ClearItemInfo()
        {
            IdTextBox.Text = " ";            
            CostTextBox.Text = " ";
            NameRichTextBox.Text = " ";
            DescriptionRichTextBox.Text = " ";           

            CostTextBox.BackColor = System.Drawing.Color.White;
            DescriptionRichTextBox.BackColor = System.Drawing.Color.White; 
            NameRichTextBox.BackColor= System.Drawing.Color.White;
        }        

        /// <summary>
        /// При нажатии на конкретный предмет в списке предметов даёт о нём информацию.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                UpdateItemInfo(ref _currentItemList);
            }
            catch
            {
                ClearItemInfo();
            }
        }
        
        /// <summary>
        /// При изменении символа в строке цены окрашивает её в белый цвет.
        /// </summary>  
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            CostTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При изменении символа в строке имени окрашивает её в белый цвет.
        /// </summary>  
        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            NameRichTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При изменении символа в строке описания окрашивает её в белый цвет.
        /// </summary>  
        private void DescriptionRichTextBox1_TextChanged(object sender, EventArgs e)
        {
            DescriptionRichTextBox.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// При нажатии пробела присваивает название предмету из NameRichTextBox. 
        /// Если не получается, окрашивает background поля NameRIchTextBox в красный цвет.
        /// </summary>   
        private void NameRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                _currentItemList = _items[ItemsListBox.SelectedIndex];

                var currentName = NameRichTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItemList.Name = currentName;

                    var info = TakeInfoFromItem(_currentItemList);

                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = info;
                }
            }
            catch  
            {
                NameRichTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        /// <summary>
        /// При нажатии пробела присваивает цену предмету из CostTextBox. 
        /// Если не получается, окрашивает background поля CostTextBox в красный цвет.
        /// </summary>  
        private void CostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                _currentItemList = _items[ItemsListBox.SelectedIndex];

                var currentCost = Convert.ToDouble(CostTextBox.Text);

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItemList.Cost = currentCost;

                    var info = TakeInfoFromItem(_currentItemList);

                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = info;
                }
            }
            catch
            {
                CostTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        /// <summary>
        /// При нажатии пробела присваивает описание предмету из DescriptionRichTextBox. 
        /// Если не получается, окрашивает background поля DescriptionRichTextBox в красный цвет.
        /// </summary>  
        private void DescriptionRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                _currentItemList = _items[ItemsListBox.SelectedIndex];

                var currentInfo = DescriptionRichTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _currentItemList.Info = currentInfo;

                    var info = TakeInfoFromItem(_currentItemList);

                    ItemsListBox.Items[ItemsListBox.SelectedIndex] = info;
                }
            }
            catch
            {
                DescriptionRichTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }
        /// <summary>
        /// При изменении значения в CategoryComboBox присваивает его значение параметру category товара. 
        /// </summary> 
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex >= 0)
            {
                _currentItemList = _items[ItemsListBox.SelectedIndex];

                var currentCategory = CategoryComboBox.Text;

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


                var info = TakeInfoFromItem(_currentItemList);

                ItemsListBox.Items[ItemsListBox.SelectedIndex] = info;
            }
        }

        /// <summary>
        /// Добавляет новый предмет в список. 
        /// </summary>        
        private void AddButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item(firstname, firstdescription, firstcost, firstCategory);
            _items.Add(newItem);
            var info = TakeInfoFromItem(newItem);

            ItemsListBox.Items.Add(info);
        }

        /// <summary>
        /// Удаляет предмет и всю информацию о нём из списка.
        /// </summary>  
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _items.RemoveAt(ItemsListBox.SelectedIndex);                
                ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);                
            }
            catch
            {
            }
        }        
    }
}
