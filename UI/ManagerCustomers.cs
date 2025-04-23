

namespace UI
{

    public partial class ManagerCustomers : Form
    {
        static readonly BlApi.IBl _bl = BlApi.Factory.Get();
        public ManagerCustomers()
        {
            InitializeComponent();
        }
        private void ManagerCustomers_Load(object sender, EventArgs e)
        {
            listBoxCustomers.DataSource = _bl.Customer.ReadAll().SelectMany(p => p.ToString().Split("\n")).ToList(); ; // ודא שזו רשימה ולא IEnumerable
        }


        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("in list box hhhhhhhhhhhhhhhhhhh");
            //listBoxCustomers.DataSource = _bl.Customer.ReadAll().SelectMany(p => p.ToString().Split("\n")).ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                string name = textBoxName.Text;
                string address = textBoxAddress.Text;
                string phone = textBoxPhone.Text;
                if (int.TryParse(textBoxId.Text, out id))
                {
                    _bl.Customer.Create(new BO.Customer(id, name, address, phone));
                    ManagerCustomers_Load(sender, e);
                    //clean inputs
                    textBoxId.Clear();
                    textBoxName.Clear();
                    textBoxAddress.Clear();
                    textBoxPhone.Clear();
                }
                else
                    MessageBox.Show("Invalid id");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void sendIdToUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(textBoxUpdateId.Text, out id))
                {
                    BO.Customer customer = _bl.Customer.Read(id);
                    if (customer != null)
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        textBoxUpdateName.Visible = true;
                        textBoxUpdateAddress.Visible = true;
                        textBoxUpdatePhone.Visible = true;
                        BtnUpdate.Visible = true;
                        textBoxUpdateName.Text = customer.Name;
                        textBoxUpdateAddress.Text = customer.Address;
                        textBoxUpdatePhone.Text = customer.Phone;
                        textBoxUpdateId.Enabled = false;

                    }
                    else
                        MessageBox.Show("Customer not found");
                }
                else
                    MessageBox.Show("Invalid id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _bl.Customer.Update(new BO.Customer(int.Parse(textBoxUpdateId.Text), textBoxUpdateName.Text, textBoxUpdateAddress.Text, textBoxUpdatePhone.Text));
            ManagerCustomers_Load(sender, e);
            //clean inputs
            textBoxUpdateId.Clear();
            textBoxUpdateName.Clear();
            textBoxUpdateAddress.Clear();
            textBoxUpdatePhone.Clear();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            int id;
            if (int.TryParse(textBoxDeleteId.Text, out id))
            {
                _bl.Customer.Delete(id);
                ManagerCustomers_Load(sender, e);
                //clean inputs
                textBoxDeleteId.Clear();
            }
            else
                MessageBox.Show("Invalid id");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(textBoxReadId.Text, out id))
                {
                    BO.Customer customer = _bl.Customer.Read(id);
                    if (customer != null)
                    {
                        textBoxReadName.Visible = true;
                        textBoxReadAddress.Visible = true;
                        textBoxReadPhone.Visible = true;
                        textBoxReadName.Text = customer.Name;
                        textBoxReadAddress.Text = customer.Address;
                        textBoxReadPhone.Text = customer.Phone;
                        labelReadName.Visible = true;
                        labelReadAddress.Visible = true;
                        labelReadPhone.Visible = true;

                    }
                    else
                        MessageBox.Show("Customer not found");
                }
                else
                    MessageBox.Show("Invalid id");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
