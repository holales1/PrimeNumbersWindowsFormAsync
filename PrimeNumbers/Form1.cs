using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
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
            var first = Convert.ToInt32(firstNumber.Text);
            var second = Convert.ToInt32(secondNumber.Text);

            if (first > second)
            {
                return;
            }

            List<int> primeNumbersList = calculations.PrimeNumbersSequential(first, second);
            listBoxPrimeNumbers.DataSource = primeNumbersList;
        }

        private void CalculatePrimeNumbers_ClickAsync(object sender, EventArgs e)
        {
            List<int> primeNumbersList = new List<int>();
            if (String.IsNullOrEmpty(firstNumber.Text))
            {
                return;
            }

            if (String.IsNullOrEmpty(secondNumber.Text))
            {
                return;
            }
            var first = Convert.ToInt32(firstNumber.Text);
            var second = Convert.ToInt32(secondNumber.Text);

            if (first>second)
            {
                return;
            }
            
            startTask(first, second);
            
        }

        private async void startTask(int first, int second)
        {
            List<int> p = new List<int>();
            p.Add(1);
            var primeNumberList = await Task.Run(() => calculations.PrimeNumbersSequential(first, second));
            listBoxPNAsync.DataSource = p;
        }
    }
}
