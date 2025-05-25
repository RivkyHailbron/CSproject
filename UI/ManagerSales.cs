using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlApi;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class ManagerSales : Form
    {
        static readonly BlApi.IBl _bl = BlApi.Factory.Get();
        public ManagerSales()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }


        private void ManagerSales_Load(object sender, EventArgs e)
        {
            listBoxSales.DataSource = _bl.Sale.ReadAll().SelectMany(s => s.ToString().Split("\n")).ToList();
            listBoxFilter.DataSource = _bl.Sale.ReadAll().SelectMany(s => s.ToString().Split("\n")).ToList();
            List<BO.Product> products= _bl.Product.ReadAll();
            comboBoxlistProductAdd.DataSource = products;
            comboBoxlistProductAdd.DisplayMember = "Name";
            comboBoxlistProductAdd.ValueMember = "ID";

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            int idProduct, salePrice, minAmount;
            if ( int.TryParse(textBoxsalePrice.Text, out salePrice) &&
                int.TryParse(textBoxminAmountForSale.Text, out minAmount))
            {
                try
                {
                    _bl.Sale.Create(new BO.Sale(0,(int) comboBoxlistProductAdd.SelectedValue, salePrice, minAmount, checkBoxClub.Checked,
                        dateTimePickerStartDateSale.Value, dateTimePickerEndDateSale.Value));
                    MessageBox.Show("המבצע נוסף בהצלחה.");
                    textBoxsalePrice.Clear();
                    textBoxminAmountForSale.Clear();
                    checkBoxClub.Checked = false;
                    dateTimePickerStartDateSale.Value = DateTime.Now;
                    dateTimePickerEndDateSale.Value = DateTime.Now;
                    listBoxSales.DataSource = _bl.Sale.ReadAll().SelectMany(s => s.ToString().Split("\n")).ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"שגיאה בהוספת המבצע: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("אנא ודא שכל השדות מלאים כראוי.");
            }
        }

        private void sendIdToUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int id;
                if (int.TryParse(textBoxidSaleUpdate.Text, out id))
                {

                    BO.Sale sale = _bl.Sale.Read(id);
                    if (sale != null)
                    {
                        textBoxidSaleUpdate.Enabled = true;
                        BtnUpdate.Visible = true;
                        dateTimePickerendDateUpdate.Visible = true;
                        labelendDateUpdate.Visible = true;
                        dateTimePickerstartDateUpdate.Visible = true;
                        textBoxMinAmountForSaleUpdate.Visible = true;
                        labelMinAmountForSaleUpdate.Visible = true;
                        checkBoxClubUpdate.Visible = true;
                        textBoxSalePriceUpdate.Visible = true;
                        labelSalePriceUpdate.Visible = true;
                        labeProductUpdate.Visible = true;
                        textBox1productIdUpdate.Visible = true;
                        textBoxMinAmountForSaleUpdate.Text = sale.MinAmountForSale.ToString();
                        textBoxSalePriceUpdate.Text = sale.SalePrice.ToString();
                        textBox1productIdUpdate.Text = sale.ProductId.ToString();
                        checkBoxClubUpdate.Checked = sale.ForClub;
                        dateTimePickerendDateUpdate.Value = sale.EndDateSale;
                        dateTimePickerstartDateUpdate.Value = sale.StartDateSale;



                    }
                }
                else
                {
                    MessageBox.Show($"is not id");
                }
            }
            catch
            {
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int min, sale, id, pid;

                // בדוק אם כל הערכים תקינים
                if (int.TryParse(textBoxidSaleUpdate.Text, out id) &&
                    int.TryParse(textBoxMinAmountForSaleUpdate.Text, out min) &&
                    int.TryParse(textBoxSalePriceUpdate.Text, out sale) &&
                    int.TryParse(textBox1productIdUpdate.Text, out pid))
                {
                    // עדכון הערך
                    _bl.Sale.Update(new BO.Sale(id, pid, sale, min, checkBoxClubUpdate.Checked, dateTimePickerstartDateUpdate.Value, dateTimePickerendDateUpdate.Value));
                    ManagerSales_Load(sender, EventArgs.Empty);

                    // איפוס האינפוטים
                    textBoxMinAmountForSaleUpdate.Text = "";
                    textBoxSalePriceUpdate.Text = "";
                    textBox1productIdUpdate.Text = "";
                    textBoxidSaleUpdate.Text = "";
                    textBoxidSaleUpdate.Enabled = false;
                    BtnUpdate.Visible = false;
                    dateTimePickerendDateUpdate.Visible = false;
                    labelendDateUpdate.Visible = false;
                    dateTimePickerstartDateUpdate.Visible = false;
                    textBoxMinAmountForSaleUpdate.Visible = false;
                    labelMinAmountForSaleUpdate.Visible = false;
                    checkBoxClubUpdate.Visible = false;
                    textBoxSalePriceUpdate.Visible = false;
                    labelSalePriceUpdate.Visible = false;
                    labeProductUpdate.Visible = false;
                    textBox1productIdUpdate.Visible = false;

                }
                else
                {
                    MessageBox.Show("נא להזין ערכים תקינים עבור כל השדות.", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // הצגת הודעת שגיאה במקרה של שגיאה
                MessageBox.Show($"שגיאה במהלך העדכון: {ex.Message}", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(textBoxDeleteId.Text, out id))
                {
                    _bl.Sale.Delete(id);
                    ManagerSales_Load(sender, e);
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

        private void sendDisplay_Click(object sender, EventArgs e)
        {

            int id;
            if (int.TryParse(textBoxidSaledisplay.Text, out id))
            {
                BO.Sale sale = _bl.Sale.Read(id);

                if (sale != null)
                {
                    //tBoxidSaledisplay.Enabled = false;
                    labelsalePriceDisplay.Visible = true;
                    labelClubDisplay.Visible = true;
                    labelMinAmountDisplay.Visible = true;
                    label6endidend.Visible = true;
                    label7DateIdStart.Visible = true;
                    labelClubDisplay.Visible = false;
                    labelsalePriceDisplay.Text += " " + sale.SalePrice;
                    if (sale.ForClub)
                        labelClubDisplay.Visible = true;
                    label6endidend.Text += " " + sale.EndDateSale.ToString("dd/MM/yyyy");
                    label7DateIdStart.Text += " " + sale.StartDateSale.ToString("dd/MM/yyyy");
                    labelMinAmountDisplay.Text += " " + sale.MinAmountForSale;


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productId;
            if (int.TryParse(textBoxFilter.Text, out productId))
            {
                listBoxFilter.DataSource = _bl.Sale.ReadAll(s => s.ProductId ==productId).SelectMany(s => s.ToString().Split("\n")).ToList();
            }
        }
    }
}
