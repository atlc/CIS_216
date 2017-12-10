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
        public Vehicles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private CarsLibrary.CarsEntities dbcontext = new CarsLibrary.CarsEntities();

        private void Vehicles_Load(object sender, EventArgs e)
        {
            dbcontext.Vehicles.Load();
            vehicleBindingSource.DataSource = dbcontext.Vehicles.Local;
        }

        private void sizeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = sizeComboBox.SelectedIndex;
            switch (index)
            {
                case 0:
                    vehicleBindingSource.DataSource = dbcontext.Vehicles.Local.Where(Vehicles => Vehicles.CarSize1.Size == "Economy");
                    break;
                case 1:
                    vehicleBindingSource.DataSource = dbcontext.Vehicles.Local.Where(Vehicles => Vehicles.CarSize1.Size == "Luxury");
                    break;
                case 2:
                    vehicleBindingSource.DataSource = dbcontext.Vehicles.Local.Where(Vehicles => Vehicles.CarSize1.Size == "Mid-size");
                    break;
            }
            vehicleBindingSource.MoveFirst();
        }
    }
}
