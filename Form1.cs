/*
/Tom Bielawski
/10-4-2020
/Starting Out With Visual C#: Tony Gaddis
/Chapter 3, Sale Price Calculator
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Calculator
{
    public partial class Form1 : Form
    {
        //Initialize the form
        public Form1()
        {
            InitializeComponent();
        }

        //Clear button event handler
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the text boxes and return focus to the top
            regularPriceTextBox.Clear();
            discountTextBox.Clear();
            regularPriceTextBox.Focus();

            //Clear the result labels
            amountDiscountLabel.Text = " ";
            resultsLabel.Text = " ";

        }

        //Close button event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Calculate button event handler
        private void calcButton_Click(object sender, EventArgs e)
        {
            //Declare variables
            double itemPrice = 0;
            double discountRate = 0;
            double discountAmount = 0;
            double salePrice = 0;

            //Convert the text box entries into doubles
            itemPrice = double.Parse(regularPriceTextBox.Text);
            discountRate = double.Parse(discountTextBox.Text);

            //Turn the discount rate into a percentage
            discountRate = discountRate / 100;

            //Calculate the amount discounted
            discountAmount = itemPrice * discountRate;

            //Convert the output to a string and display
            //Format with currency argument
            amountDiscountLabel.Text = discountAmount.ToString("c");

            //Calculate the final sale price
            salePrice = itemPrice - discountAmount;

            //Convert final sale price to string and display
            //Format with currency argument
            resultsLabel.Text = salePrice.ToString("c");
        }
    }
}
