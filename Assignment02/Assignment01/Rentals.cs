using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class Rentals : Form
    {
        // Classwide objects for validating the fields
        ErrorProvider ErrorProvider1 = new ErrorProvider();
        Decimal NumberDecimal;

        public Rentals()
        {
            InitializeComponent();
        }

        private void BeginOdometereading_Validation(object sender, CancelEventArgs e)
        {
            Decimal.TryParse(OdometerBeginningTextBox.Text, out NumberDecimal);

            if (NumberDecimal == 0)
            {
                ErrorProvider1.SetError(OdometerBeginningTextBox, "Entry required!");
                OdometerBeginningTextBox.Focus();
                e.Cancel = true;
            }
            else
                ErrorProvider1.Clear();
        }
        private void DriversLicenseTextBox_Validation(object sender, CancelEventArgs e)
        {
            Decimal.TryParse(DriversLicenseTextBox.Text, out NumberDecimal);

            if (NumberDecimal == 0)
            {
                ErrorProvider1.SetError(DriversLicenseTextBox, "Entry required!");
                DriversLicenseTextBox.Focus();
                e.Cancel = true;
            }
            else
                ErrorProvider1.Clear();
        }

        private void CreditCardNumberTextBox_Validator(object sender, CancelEventArgs e)
        {
            Decimal.TryParse(CreditCardNumberTextBox.Text, out NumberDecimal);

            if (NumberDecimal == 0)
            {
                ErrorProvider1.SetError(CreditCardNumberTextBox, "Entry required!");
                CreditCardNumberTextBox.Focus();
                e.Cancel = true;
            }
            else
                ErrorProvider1.Clear();
        }

        private void DaysRentedTextBox_Validator(object sender, CancelEventArgs e)
        {
            Decimal.TryParse(DaysRentedTextBox.Text, out NumberDecimal);

            if (NumberDecimal == 0)
            {
                ErrorProvider1.SetError(DaysRentedTextBox, "Entry required!");
                DaysRentedTextBox.Focus();
                e.Cancel = true;
            }
            else
                ErrorProvider1.Clear();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void RunValidationTests(object sender, EventArgs e)
        {
            /*
            BeginOdometereading_Validation(sender, e);
            DriversLicenseTextBox_Validation(sender, e);
            CreditCardNumberTextBox_Validator(sender, e);
            DaysRentedTextBox_Validator(sender, e);
            */
        }
    }
}
