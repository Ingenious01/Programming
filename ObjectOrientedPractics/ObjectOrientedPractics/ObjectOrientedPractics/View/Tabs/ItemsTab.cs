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
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();

        private Item _currentItemList;        

        static int firstcost = 100;
        static string firstname = "StockName";
        static string firstdescription = "Description here";

        Item stockItem = new Item(firstname, firstdescription, firstcost);

        public ItemsTab()
        {
            InitializeComponent();

            _items.Add(stockItem);
            var info = TakeInfoFromItem(stockItem);

            ItemsListBox.Items.Add(info);            
        }              

        private static string TakeInfoFromItem(Item item)
        {


            var info = $"{item.Id}. " + $"Name={item.Name}, " + $"Cost={item.Cost} ";

            return info;
        }

        private void UpdateItemInfo(ref Item item)
        {
            item = _items[ItemsListBox.SelectedIndex];

            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameRichTextBox.Text = item.Name;
            DescriptionRichTextBox.Text = item.Info;            
        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }       

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

        private void AddButton_Click(object sender, EventArgs e)
        {
            var cost = 100;
            var name = "Stock Name";
            var description = "Description here";

            var newItem = new Item(name, description, cost);
            _items.Add(newItem);
            var info = TakeInfoFromItem(newItem);

            ItemsListBox.Items.Add(info);            
            
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            
          
            
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void NameRichTextBox_TextChanged(object sender, EventArgs e)
        {
            

                        

            
        }

        private void DescriptionRichTextBox1_TextChanged(object sender, EventArgs e)
        {            

            

        }

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
                NameRichTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

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
