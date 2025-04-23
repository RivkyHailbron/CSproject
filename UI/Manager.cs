using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void products_Click(object sender, EventArgs e)
        {
            ManagerProducts managerProducts = new ManagerProducts();
            managerProducts.Show();
        }

        private void customers_Click(object sender, EventArgs e)
        {
            ManagerCustomers managerCustomers = new ManagerCustomers();
            managerCustomers.Show();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            ManagerSales managerSales = new ManagerSales();
            managerSales.Show();
        }
    }
}
