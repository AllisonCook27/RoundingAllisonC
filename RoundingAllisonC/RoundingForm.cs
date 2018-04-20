/*
 * Created by: Allison Cook
 * Created on: 17 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * This program rounds a given decimal number to a given number of decimal places.
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

namespace RoundingAllisonC
{
    public partial class frmRounding : Form
    {
        //variables
        double decimalNumber;
        int round;

        public frmRounding()
        {
            InitializeComponent();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //setting the input
            decimalNumber = Convert.ToDouble(txtDecimal.Text);

            //seting the number of decimal places
            round = Convert.ToInt32(numRound.Value);

            //calling the function
            RoundDecimal(ref decimalNumber, round);
        }

        void RoundDecimal(ref double decimalNumber, int round)
        {
            double newNumber;

            //setting the new number to the decimal moved a certain number of decimal places
            newNumber = decimalNumber * Math.Pow(10,round);

            // adding 0.5
            newNumber = newNumber + 0.5;

            //getting ride of extra numbers
            newNumber = Math.Truncate(newNumber);

            //moving decimal point back
            newNumber = newNumber / Math.Pow(10, round);

            //displaying message box
            MessageBox.Show("The rounded answer is " + newNumber, "Rounding Program");
        }
    }
}
