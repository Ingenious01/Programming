﻿using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonControl : UserControl
    {
        public SeasonControl()
        {
            InitializeComponent();

            SeasonComboBox.Items.AddRange(new string[]  {Convert.ToString(Season.Autumn),
                                                         Convert.ToString(Season.Summer),
                                                         Convert.ToString(Season.Spring),
                                                         Convert.ToString(Season.Winter)});
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    BackColor = ColorTranslator.FromHtml("#559c45"); ;
                    break;

                default:
                    MessageBox.Show("Выберите время года!");
                    break;
            }
        }
    }
}
