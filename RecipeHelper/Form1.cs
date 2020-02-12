using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /* This program converts degree celsius to fahrenheit and
         * milliliters to cups */
        private void btnConvFahr_Click(object sender, EventArgs e)
        {
            // Converting degree celsius to fahrenheit 
            // Declaring the variables
            double celsius;
            double fahrenheit;

            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                /* Calculate the Fahrenheit for the given Celsius
                 * and display the result into to 2 decimal places */

                 fahrenheit = Math.Round(((celsius * 9) / 5) + 32, 2);

                txtFahrenheit.Text = fahrenheit.ToString();

                txtFahrenheit.Focus();

            }

            else
            {
                /* Display an error message if the user
                 * enters non-numerical data for the Celsius */

                MessageBox.Show("Please enter numbers only", "Error");
            }

        }

        private void btnConvCups_Click(object sender, EventArgs e)
        {
            // Converting milliliters to cups using the converting factor
            // Declaring the variables
            double volumeFactor = 263.59;
            double milliliters;
            double cups;

            if (double.TryParse(txtMilliliters.Text, out milliliters))
            {
                /* Calculate the Cups for the given Milliliters
                 * and display the result into to 2 decimal places */

                cups = Math.Round((milliliters / volumeFactor), 2);

                txtCups.Text = cups.ToString();

                txtCups.Focus();


            }
            else
            {
                /* Display an error message if the user
                * enters non-numerical data for the Milliliters */

                MessageBox.Show("Please enter numbers only", "Error");
            }

        }
    }
}
