using BO;


namespace UI
{
    public partial class Customer : Form
    {
        static readonly BlApi.IBl _bl = BlApi.Factory.Get();
        private bool isClub= false;

        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerOrder customerOrder = new CustomerOrder(isClub);
            customerOrder.Show();
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                
                if (int.TryParse(textBoxGetCustomerId.Text, out id))
                {
                    BO.Customer c = _bl.Customer.Read(id);
                    if (c!=null )
                    {
                        isClub = true;
                        textBoxHello.Text = $"Hello club member {c.Name}";

                    }
                    textBoxGetCustomerId.Enabled = false;
                    send.Enabled = false;
                    button2.Enabled = true;
                }
             

            }
            catch (BLExceptionIdDoesNotExistInTheList ex)
            {
                textBoxHello.Text = $"hello new ----------- {textBoxGetCustomerId.Text}";
                textBoxGetCustomerId.Enabled = false;
                send.Enabled = false;
                button2.Enabled = true;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                textBoxHello.Text = $"hello new ----------- {textBoxGetCustomerId.Text}";
                textBoxGetCustomerId.Enabled = false;
                send.Enabled = false;
                button2.Enabled = true;
            }

        }


    }
}
