using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AdressControl : UserControl
    {
        public AdressControl()
        {
            InitializeComponent();                      
        }
       
        public void UpdateAdressInfo(int postIndex, string country, string city,
            string street, string building, string apartament)
        {
            PostIndexTextBox.Text = postIndex.ToString();
            CountryTextBox.Text = country;
            CityTextBox.Text = city;
            StreetTextBox.Text = street;
            BuildingTextBox.Text = building;
            ApartamentTextBox.Text = apartament; 
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            PostIndexTextBox.BackColor = System.Drawing.Color.White;
        }

        private void PostIndexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                var currentIndex = Convert.ToInt32(PostIndexTextBox.Text);

                if (e.KeyChar == (char)Keys.Enter)
                {
                    customertab.RefreshIndexValue(currentIndex);                                       
                }
            }
            catch
            {
                PostIndexTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        } 

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            CountryTextBox.BackColor = System.Drawing.Color.White;
        }

        private void CountryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityTextBox.BackColor = System.Drawing.Color.White;
        }

        private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            StreetTextBox.BackColor = System.Drawing.Color.White;
        }

        private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildingTextBox.BackColor = System.Drawing.Color.White;
        }

        private void BuildingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ApartamentTextBox_TextChanged(object sender, EventArgs e)
        {
            ApartamentTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ApartamentextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }        
    }
}