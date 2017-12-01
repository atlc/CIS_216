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
            Customers customerForm = new Customers();
            customerForm.MdiParent = this;
            customerForm.Show();
            customerForm.Focus();
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehicles vehicleForm = new Vehicles();
            vehicleForm.MdiParent = this;
            vehicleForm.Show();
            vehicleForm.Focus();
        }

        private void rentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rentals rentalForm = new Rentals();
            rentalForm.MdiParent = this;
            rentalForm.Show();
            rentalForm.Focus();
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
            Customers customerForm = new Customers();
            customerForm.MdiParent = this;
            customerForm.Show();
            customerForm.Focus();
        }
    }
}
