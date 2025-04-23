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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void manager_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.Show();
            //this.Close();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void TOGO_Click(object sender, EventArgs e)
        {

        }

        //private void pictureBox2_Click(object sender, EventArgs e)
        //{

        //}

        //private void Home_Load(object sender, EventArgs e)
        //{

        //}
    }
}
