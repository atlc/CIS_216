using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity; // Required for Load function call in Load method 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment01
{
    public partial class Customers : Form
    {

        private CarsLibrary.CarsEntities dbcontext = new CarsLibrary.CarsEntities();

        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dbcontext.Customers.OrderBy(Customers => Customers.LName).ThenBy(Customers => Customers.FName).Load();
            customerBindingSource.DataSource = dbcontext.Customers.Local;
        }
    }
}
