using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Splash
{
    public partial class ProductRecordForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        bool check = false;
        ProductForm prod;
        public ProductRecordForm(ProductForm p)
        {
            InitializeComponent();
            prod = p;
            clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
        public void clear()
        {
            nametxtbox.Clear();
            typtxtbox.Clear();
            qtyTextBox2.Clear();
            priceTextBox1.Clear();
            cat.SelectedIndex = 0;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Cancel Updates?", "User Record Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Dispose();
            }
        }
        public void Checkfields()
        {
            if (nametxtbox.Text == "" || typtxtbox.Text=="" || priceTextBox1.Text=="")
            {
                MessageBox.Show("Required Fields Must be Filled", "User Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            check = true;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            string name = nametxtbox.Text;
            string type = typtxtbox.Text;
            string quant = qtyTextBox2.Text;
            string price = priceTextBox1.Text;
            string category = cat.Text;
            Checkfields();
            if (check)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into tbProducts(ProductName,Type,Category,Quantity,Price)values(@ProductName,@Type,@Category,@Quantity,@Price)", con);
                    cmd.Parameters.AddWithValue("@ProductName", name);
                    cmd.Parameters.AddWithValue("@Type", type);
                    cmd.Parameters.AddWithValue("@Quantity", quant);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Category", category);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfuly", "Product Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    prod.loadProduct();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string name = nametxtbox.Text;
            string type = typtxtbox.Text;
            string quant = qtyTextBox2.Text;
            string price = priceTextBox1.Text;
            string category = cat.Text;
            Checkfields();
            if (check)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("Update tbProducts set ProductName='" + name + "',Type='" + type + "',Category='" + category + "',Quantity='" + quant + "',Price='" + price + "' where ProductCode='" + lblprod.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfuly", "Product Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    prod.loadProduct();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void qtyTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void priceTextBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void priceTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}