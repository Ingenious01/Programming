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
        private Adress _adress;

        public AdressControl()
        {
            InitializeComponent();
        }

        public Adress Adress
        {
            get => _adress;
            set
            {
                _adress = value;
                UpdateAdressInfo(_adress);
            }
        }

        public void UpdateAdressInfo(Adress value)
        {
            PostIndexTextBox.Text = value.Index.ToString();
            CountryTextBox.Text = value.Country;
            CityTextBox.Text = value.City;
            StreetTextBox.Text = value.Street;
            BuildingTextBox.Text = value.Building;
            ApartamentTextBox.Text = value.Apartament; 
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
                    _adress.Index = currentIndex;
                                        
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
            try
            {
                var currentCountry = CountryTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _adress.Country = currentCountry;

                }
            }
            catch
            {
                CountryTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            CityTextBox.BackColor = System.Drawing.Color.White;
        }

        private void CityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var currentCity = CityTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _adress.City = currentCity;
                    
                }
            }
            catch
            {
                CityTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            StreetTextBox.BackColor = System.Drawing.Color.White;
        }

        private void StreetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var currentStreet = StreetTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _adress.Street = currentStreet;

                }
            }
            catch
            {
                StreetTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildingTextBox.BackColor = System.Drawing.Color.White;
        }

        private void BuildingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var currentBuilding = BuildingTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _adress.Building = currentBuilding;

                }
            }
            catch
            {
                BuildingTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void ApartamentTextBox_TextChanged(object sender, EventArgs e)
        {
            ApartamentTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ApartamentextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var currentApartament = ApartamentTextBox.Text;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    _adress.Apartament = currentApartament;

                }
            }
            catch
            {
                ApartamentTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }        
    }
}