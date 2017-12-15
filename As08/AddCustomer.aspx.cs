using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {

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