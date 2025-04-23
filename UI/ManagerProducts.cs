

namespace UI
{
    public partial class ManagerProducts : Form
    {
        static readonly BlApi.IBl _bl = BlApi.Factory.Get();

        public ManagerProducts()
        {
            InitializeComponent();
        }

        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ManagerProducts_Load(object sender, EventArgs e)
        {
            listBoxProducts.DataSource = _bl.Product.ReadAll().SelectMany(p => p.ToString().Split("\n")).ToList(); 
            comboBoxCategory.DataSource = Enum.GetValues(typeof(BO.Categories));

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int  price, amount;
                string name = textBoxName.Text;
                BO.Categories category = comboBoxCategory.SelectedItem != null ? (BO.Categories)comboBoxCategory.SelectedItem : BO.Categories.sport;

                if ( int.TryParse(textBoxAmont.Text, out amount) && int.TryParse(textBoxPrice.Text, out price))
                {
                    _bl.Product.Create(new BO.Product(0, name, category, price, amount));
                    ManagerProducts_Load(sender, e);
                    //clean inputs
                    textBoxName.Clear();
                    textBoxAmont.Clear();
                    textBoxPrice.Clear();
                    comboBoxCategory.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("Invalid params");
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
                    BO.Product product = _bl.Product.Read(id);
                    if (product != null)
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        textBoxUpdateName.Visible = true;
                        textBoxUpdatePrice.Visible = true;
                        textBoxUpdateAmount.Visible = true;
                        BtnUpdate.Visible = true;
                        comboBoxUpdateCategory.Visible = true;
                        textBoxUpdateName.Text = product.Name;
                        textBoxUpdatePrice.Text = product.Price.ToString();
                        textBoxUpdateAmount.Text = product.Amount.ToString();
                        comboBoxUpdateCategory.DataSource = Enum.GetValues(typeof(BO.Categories));
                        comboBoxUpdateCategory.Text = product.Category.ToString();
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
            _bl.Product.Update(new BO.Product(int.Parse(textBoxUpdateId.Text), textBoxName.Text, (BO.Categories)comboBoxUpdateCategory.SelectedItem, double.Parse(textBoxUpdatePrice.Text), int.Parse(textBoxUpdateAmount.Text)));
            ManagerProducts_Load(sender, e);
            //clean inputs
            textBoxUpdateId.Clear();
            textBoxUpdateName.Clear();
            textBoxUpdatePrice.Clear();
            textBoxUpdateAmount.Clear();
            comboBoxUpdateCategory.SelectedIndex = -1;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(textBoxDeleteId.Text, out id))
                {
                    _bl.Product.Delete(id);
                    ManagerProducts_Load(sender, e);
                    //clean inputs
                    textBoxDeleteId.Clear();
                }
                else
                    MessageBox.Show("Invalid id");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(textBoxReadId.Text, out id))
                {
                    BO.Product product = _bl.Product.Read(id);
                    if (product != null)
                    {
                        textBoxReadName.Visible = true;
                        textBoxReadCategory.Visible = true;
                        textBoxReadPrice.Visible = true;
                        textBoxReadAmount.Visible = true;
                        textBoxReadName.Text = product.Name;
                        textBoxReadCategory.Text = product.Category.ToString();
                        textBoxReadPrice.Text = product.Price.ToString();
                        textBoxReadAmount.Text = product.Amount.ToString();
                        labelReadName.Visible = true;
                        labelReadCategort.Visible = true;
                        labelReadPrice.Visible = true;
                        labelReadAmount.Visible = true;
                    }
                    else
                        MessageBox.Show("Product not found");
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
