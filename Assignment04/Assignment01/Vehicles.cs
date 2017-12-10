using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class Vehicles : Form
    {

        private CarsLibrary.CarsEntities dbcontext = new CarsLibrary.CarsEntities();

        public Vehicles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Vehicles_Load(object sender, EventArgs e)
        {
            dbcontext.Vehicles.Load();
            vehicleBindingSource.DataSource = dbcontext.Vehicles.Local;
        }
    }
}
