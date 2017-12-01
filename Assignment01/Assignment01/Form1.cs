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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] customerFormChildren = this.MdiChildren;
            bool arePresent = false;

            if (customerFormChildren.Length == 0)
            {
                Customers aCustomerForm = new Customers();
                aCustomerForm.MdiParent = this;
                aCustomerForm.Show();
                aCustomerForm.Focus();
                arePresent = true;
            } 
            else
            {
                foreach (Form child in customerFormChildren)
                {
                    if (child.Name == "Customers")
                    {
                        child.Activate();
                        arePresent = true;
                        break;
                    }
                    else
                        arePresent = false;
                }
            if (!arePresent)
            {
                    Customers aCustomerForm = new Customers();
                    aCustomerForm.MdiParent = this;
                    aCustomerForm.Show();
                    aCustomerForm.Focus();
                }
           }
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] vehicleFormChildren = this.MdiChildren;
            bool arePresent = false;

            if (vehicleFormChildren.Length == 0)
            {
                Vehicles aVehicleForm = new Vehicles();
                aVehicleForm.MdiParent = this;
                aVehicleForm.Show();
                aVehicleForm.Focus();
                arePresent = true;
            }
            else
            {
                foreach (Form child in vehicleFormChildren)
                {
                    if (child.Name == "Vehicles")
                    {
                        child.Activate();
                        arePresent = true;
                        break;
                    }
                    else
                        arePresent = false;
                }
                if (!arePresent)
                {
                    Vehicles aVehicleForm = new Vehicles();
                    aVehicleForm.MdiParent = this;
                    aVehicleForm.Show();
                    aVehicleForm.Focus();
                }
            }
        }

        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] rentalFormChildren = this.MdiChildren;
            bool arePresent = false;

            if (rentalFormChildren.Length == 0)
            {
                Rentals aRentalForm = new Rentals();
                aRentalForm.MdiParent = this;
                aRentalForm.Show();
                aRentalForm.Focus();
                arePresent = true;
            }
            else
            {
                foreach (Form child in rentalFormChildren)
                {
                    if (child.Name == "Rentals")
                    {
                        child.Activate();
                        arePresent = true;
                        break;
                    }
                    else
                        arePresent = false;
                }
                if (!arePresent)
                {
                    Rentals aRentalForm = new Rentals();
                    aRentalForm.MdiParent = this;
                    aRentalForm.Show();
                    aRentalForm.Focus();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.MdiParent = this;
            aboutBox.Show();
            aboutBox.Focus();
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            customersToolStripMenuItem_Click(sender, e);
        }

        private void VehiclesButton_Click(object sender, EventArgs e)
        {
            vehiclesToolStripMenuItem_Click(sender, e);
        }

        private void RentalsButton_Click(object sender, EventArgs e)
        {
            rentalsToolStripMenuItem_Click(sender, e);
        }
    }
}
