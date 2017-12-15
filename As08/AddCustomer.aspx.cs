using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

public partial class AddCustomer : System.Web.UI.Page
{
    private CarsEntities dbcontext = new CarsEntities();
    // private CarsEntities.Customer dbcontext = new CarsEntities.Customer();

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        if (IsPostBack)
        {
            Validate();
        }
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
            dbcontext.SaveChanges();
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
}