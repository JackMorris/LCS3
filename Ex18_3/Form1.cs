using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ex18_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salesAmountField.Clear();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var salesAmount = Convert.ToDouble(salesAmountField.Text);
                var salesTax = Convert.ToDouble(salesTaxField.Value);
                var taxAmount = salesAmount * (salesTax/100);
                var totalAmount = salesAmount + taxAmount;

                taxLabel.Text = String.Format("Tax on £{0} at {1}% is £{2}.", 
                                                    salesAmount.ToString("F"), 
                                                    salesTax.ToString("F"), 
                                                    taxAmount.ToString("F"));
                totalLabel.Text = String.Format("The total is £{0}.", totalAmount.ToString("F"));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Sales amount must be a number");
                salesAmountField.Clear();
            }
        }
    }
}
