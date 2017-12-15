using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RentalCars : System.Web.UI.Page
{
    private CarsEntities dbcontext = new CarsEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        dbcontext.Vehicles.Load();
        //RentalCarsGridView.DataSource = dbcontext.Vehicles.Local;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        int index = DropDownList1.SelectedIndex;
        switch (index)
        {
            case 0:
                RentalCarsGridView.DataSource = dbcontext.Vehicles.Where(CarSize => CarSize.CarSize1.Size == "Economy");
                break;
            case 1:
                RentalCarsGridView.DataSource = dbcontext.Vehicles.Where(CarSize => CarSize.CarSize1.Size == "Luxury");
                break;
            case 2:
                RentalCarsGridView.DataSource = dbcontext.Vehicles.Where(CarSize => CarSize.CarSize1.Size == "Mid-size");
                break;
        }
    }
}