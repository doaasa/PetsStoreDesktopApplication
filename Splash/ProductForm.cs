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
    public partial class ProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");

        public ProductForm()
        {
            InitializeComponent();
            loadProduct();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductRecordForm prod = new ProductRecordForm(this);
            prod.updatebtn.Enabled = false;
            prod.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        { 
        
        }
        public void loadProduct()
        {
            int no = 0;
            ProductDatagridview.Rows.Clear();
            string search = searchTxtbox.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from tbProducts where CONCAT(ProductCode,ProductName,Type,Category,Quantity,Price)LIKE '%" + search + "%'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    no++;
                    ProductDatagridview.Rows.Add(no, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString());
                }
                data.Close();
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

        private void ProductDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = ProductDatagridview.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ProductRecordForm prod = new ProductRecordForm(this);
                
                con.Close();
                prod.lblprod.Text = ProductDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                prod.nametxtbox.Text = ProductDatagridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                prod.typtxtbox.Text = ProductDatagridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                prod.cat.Text = ProductDatagridview.Rows[e.RowIndex].Cells[4].Value.ToString();
                prod.qtyTextBox2.Text = ProductDatagridview.Rows[e.RowIndex].Cells[5].Value.ToString();
                prod.priceTextBox1.Text = ProductDatagridview.Rows[e.RowIndex].Cells[6].Value.ToString();
                prod.savebtn.Enabled = false;
                prod.lblprod.Visible = true;
                prod.Show();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you Sure you want to Delete Row?", "Product Record Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from tbProducts where ProductCode='" + ProductDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfuly", "Product Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        loadProduct();
                    }
                }

            }
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            loadProduct();
        }
    }
}
