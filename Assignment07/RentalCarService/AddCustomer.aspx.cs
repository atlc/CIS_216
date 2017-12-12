using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentalCarService
{
    public partial class AddCustomer : System.Web.UI.Page
    {
        private RentalCarService.CarsEntities dbcontext = new RentalCarService.CarsEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (IsPostBack)
            {
                Validate();
            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            StreetAddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            ZIPCodeTextBox.Text = "";
            DriversLicenseTextBox.Text = "";
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var newCust = new Customer
                {
                    FName = FirstNameTextBox.Text,
                    LName = LastNameTextBox.Text,
                    Phone = PhoneNumberTextBox.Text,
                    Street = StreetAddressTextBox.Text,
                    City = CityTextBox.Text,
                    State = StateTextBox.Text,
                    Zip = ZIPCodeTextBox.Text,
                    Drivers_License = DriversLicenseTextBox.Text
                };

                dbcontext.Customers.Add(newCust);
                // Didn't know if we needed persistent state beyond session or not, so wrote it to db anyway
                dbcontext.SaveChanges();
            }
        }
    }
}