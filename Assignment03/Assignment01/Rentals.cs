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

        private void OdometerBeginningTextBox_Validating(object sender, CancelEventArgs e)
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

        private void OdometerEndingTextBox_Validating(object sender, CancelEventArgs e)
        {
            Decimal.TryParse(OdometerEndingTextBox.Text, out NumberDecimal);

            if (NumberDecimal == 0)
            {
                ErrorProvider1.SetError(OdometerEndingTextBox, "Entry required!");
                OdometerEndingTextBox.Focus();
                e.Cancel = true;
            }
            else
                ErrorProvider1.Clear();
        }

        private void DriversLicenseTextBox_Validating(object sender, CancelEventArgs e)
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

        private void CreditCardNumberTextBox_Validating(object sender, CancelEventArgs e)
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

        private void DaysRentedTextBox_Validating(object sender, CancelEventArgs e)
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
            int OdometerBeginning, OdometerEnding, DaysRented, CarSizeInt, Discount = 0;

            // Validate that entries have been made for the DL# & days rented, & that a car size is selected
            if (DriversLicenseTextBox.Text != "")
            {
                if (DaysRentedTextBox.Text != "")
                {
                    if (SizeCompactRadioButton.Checked || SizeMidsizeRadioButton.Checked || SizeLuxuryRadioButton.Checked)
                    {
                        // Begin seeing if values are parsable
                        Int32.TryParse(DaysRentedTextBox.Text, out DaysRented);
                        Int32.TryParse(OdometerBeginningTextBox.Text, out OdometerBeginning);

                        // If there is a positive value in the beginning mileage, parse the ending mileage
                        if (OdometerBeginning > 0)
                        {
                            Int32.TryParse(OdometerEndingTextBox.Text, out OdometerEnding);

                            // If days rented, beginning mileage, and ending mileage are all valid, assign CarSizeInt value
                            if (OdometerEnding > 0)
                            {
                                // Casts carsizeint values to the corresponding values in the enum
                                if (SizeCompactRadioButton.Checked)
                                    CarSizeInt = (int)CarSize.Compact;
                                else if (SizeMidsizeRadioButton.Checked)
                                    CarSizeInt = (int)CarSize.MidSize;
                                else
                                    CarSizeInt = (int)CarSize.Luxury;

                                // Validates that the starting mileage should be lesser than the ending milage
                                if (OdometerBeginning > OdometerEnding)
                                {
                                    ErrorProvider1.SetError(OdometerBeginningTextBox, "The beginning mileage must be lower than the ending mileage.");
                                    OdometerBeginningTextBox.Focus();
                                    OdometerBeginningTextBox.SelectAll();
                                }
                                else
                                {
                                    // Determines which discount - if any - to use in CorporateRate class's Discount enum, then calculates amounts owed
                                    if (DiscountCorporateRadioButton.Checked)
                                    {
                                        Discount = 1;
                                        CorporateRate corporateTotal = new CorporateRate(OdometerBeginning, OdometerEnding, CarSizeInt, DaysRented, Discount);
                                        AmountDueTextBox.Text = corporateTotal.getAmountDue().ToString("C");
                                    }
                                    else if (DiscountInsuranceAcctRadioButton.Checked)
                                    {
                                        Discount = 2;
                                        CorporateRate insuranceTotal = new CorporateRate(OdometerBeginning, OdometerEnding, CarSizeInt, DaysRented, Discount);
                                        AmountDueTextBox.Text = insuranceTotal.getAmountDue().ToString("C");
                                    }
                                    else // If no CorporateRate subclass discount is necessary, calculate the amount due from standard RentalRate object
                                    {
                                        Discount = 0;
                                        RentalRate totalCost = new RentalRate(OdometerBeginning, OdometerEnding, CarSizeInt, DaysRented);
                                        AmountDueTextBox.Text = totalCost.getAmountDue().ToString("C");
                                    }
                                }
                            }
                            // Begin the error handling and focusing back to the required controls
                            else
                            {
                                ErrorProvider1.SetError(OdometerEndingTextBox, "Please enter the ending mileage.");
                                OdometerEndingTextBox.Focus();
                                OdometerEndingTextBox.SelectAll();
                            }
                        }
                        else
                        {
                            ErrorProvider1.SetError(OdometerBeginningTextBox, "Please enter the beginning mileage.");
                            OdometerBeginningTextBox.Focus();
                            OdometerBeginningTextBox.SelectAll();
                        }
                    }
                    else
                    {
                        ErrorProvider1.SetError(SizeCompactRadioButton, "Please check one of the car size values.");
                    }
                }
                else
                {
                    ErrorProvider1.SetError(DaysRentedTextBox, "Please enter the amount of days the car was rented.");
                    DaysRentedTextBox.Focus();
                    DaysRentedTextBox.SelectAll();
                }
            }
            else
            {
                ErrorProvider1.SetError(DriversLicenseTextBox, "Please enter your drivers' license number.");
                DriversLicenseTextBox.Focus();
                DriversLicenseTextBox.SelectAll();
            }
        }
    }
}
