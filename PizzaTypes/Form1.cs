using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaTypes
{
    public partial class Form1 : Form
    {
        float pizzaPrice;
        float totalPrice;
        string selectedPizza;
        public Form1()
        {
            InitializeComponent();
            pizzaPrice = 0f;
            totalPrice = 0f;
        }

        private void PizzaSize_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CalulatePizzaCost()
        {

            switch (selectedPizza)
            {
                case "Cheese": 
                    pizzaPrice = 10;
                    break;
                case "Neapolitan":
                    pizzaPrice = 10;
                    break;
                case "Margherita":
                    pizzaPrice = 10;
                    break;
                case "Calzone":
                    pizzaPrice = 12.5f;
                    break;
                case "Stromboli":
                    pizzaPrice = 12.5f;
                    break;
                case "Deep dish":
                    pizzaPrice = 12.5f;
                    break;
                case "Marinara":
                    pizzaPrice = 12.5f;
                    break;
                case "Hawaiian":
                    pizzaPrice = 12.5f;
                    break;
            }

            totalPrice = pizzaPrice;
            if (cbMushroom.Checked)
            {
                totalPrice += 2;
            }
            if (cbBlackOlive.Checked)
            {
                totalPrice += 3;
            }
            if (cbPepperoni.Checked)
            {
                totalPrice += 5;
            }

                txtTotal.Text = String.Format("{0:C}", totalPrice);
        }

        private bool IsAtLeastOneSizeChecked()
        {
            return rdoSmallSize.Checked || rdoMediumSize.Checked || rdoLargeSize.Checked;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPizza = listBox1.SelectedItem.ToString();
            CalulatePizzaCost();
        }
    }
}