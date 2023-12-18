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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public AddressControl()
        {
            InitializeComponent();
        }       

        public Address Address
        {
            get => _address;
            set
            {
                _address = value;
                if (value != null) 
                { 
                    UpdateAdressInfo(_address); 
                }
            }
        }

        public void ClearInfo()
        {
            PostIndexTextBox.Text = null;
            CountryTextBox.Text = null;
            CityTextBox.Text = null;
            StreetTextBox.Text = null;
            BuildingTextBox.Text = null;
            ApartamentTextBox.Text = null;
        }

        public void UpdateAdressInfo(Address value)
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
                    _address.Index = currentIndex;

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
                    _address.Country = currentCountry;

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
                    _address.City = currentCity;

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
                    _address.Street = currentStreet;

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
                    _address.Building = currentBuilding;

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
                    _address.Apartament = currentApartament;

                }
            }
            catch
            {
                ApartamentTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }
    }
}
