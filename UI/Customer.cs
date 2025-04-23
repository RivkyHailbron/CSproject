using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Customer : Form
    {
        static readonly BlApi.IBl _bl = BlApi.Factory.Get();
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerOrder customerOrder = new CustomerOrder(checkBoxIsClub.Checked);
            customerOrder.Show();
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(textBoxGetCustomerId.Text, out id))
                {
                    if (checkBoxIsClub.Checked)
                    {
                        BO.Customer c = _bl.Customer.Read(id);

                        textBoxHello.Text = $"Hello club member {c.Name}";

                    }
                    else
                        textBoxHello.Text = $"hello new ----- {textBoxGetCustomerId.Text}";

                }
                checkBoxIsClub.Enabled = false;
                textBoxGetCustomerId.Enabled = false;
                send.Enabled = false;
                button2.Enabled = true;

            }
            catch (DalExceptionIdDoesNotExistInTheList ex)
            {
                textBoxHello.Text = $"hello new {textBoxGetCustomerId.Text}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


    }
}
