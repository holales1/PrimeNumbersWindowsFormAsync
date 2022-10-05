using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        private Calculations calculations;
        public Form1()
        {
            InitializeComponent();
            calculations = new Calculations();
        }

        private void firstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void secondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void calculatePrimeNumberSequential_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumber.Text))
            {
                return;
            }

            if (String.IsNullOrEmpty(secondNumber.Text))
            {
                return;
            }
            var first = (long)Convert.ToDouble(firstNumber.Text);
            var second = (long)Convert.ToDouble(secondNumber.Text);

            if (first > second)
            {
                return;
            }

            List<long> primeNumbersList = calculations.PrimeNumbersSequential(first, second);
            listBoxPrimeNumbers.DataSource = primeNumbersList;
        }

        private void CalculatePrimeNumbers_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(firstNumber.Text))
            {
                return;
            }

            if (String.IsNullOrEmpty(secondNumber.Text))
            {
                return;
            }
            var first = (long)Convert.ToDouble(firstNumber.Text);
            var second = (long)Convert.ToDouble(secondNumber.Text);

            if (first>second)
            {
                return;
            }

            List<long> primeNumbersList = calculations.PrimeNumbersAsync(first, second);
            listBoxPrimeNumbers.DataSource = primeNumbersList;
        }
    }
}
