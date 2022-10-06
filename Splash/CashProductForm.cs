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

    public partial class CashProductForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        CashForm cf;
        public string userName;
        public CashProductForm(CashForm c)
        {
            cf = c;
       
            InitializeComponent();
            loadProduct();
        }
        public void loadProduct()
        {
            int no = 0;
            CashProductDatagridview.Rows.Clear();
            string search = searchTxtbox.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ProductCode,ProductName,Type,Category,Price from tbProducts WHERE CONCAT(ProductCode,ProductName,Type,Category,Price)LIKE '%" + search + "%' AND Quantity>0", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    no++;
                    CashProductDatagridview.Rows.Add(no, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString());
                }
                data.Close();
                con.Close();
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

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void cashbtn_Click(object sender, EventArgs e)
        {
            bool insert = false;
            foreach(DataGridViewRow dr in CashProductDatagridview.Rows)
            {
                bool checkBox = Convert.ToBoolean(dr.Cells["Select"].Value);
                if (checkBox == true)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Insert into tbCash(TransactionNumber,ProductCode,ProductName,Quantity,Price,Cashier) Values(@TransactionNumber,@ProductCode,@ProductName,@Quantity,@Price,@Cashier)", con);
                        cmd.Parameters.AddWithValue("@TransactionNumber",cf.lbltransno.Text);
                        cmd.Parameters.AddWithValue("@ProductCode",dr.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@ProductName", dr.Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@Quantity", 1);
                        cmd.Parameters.AddWithValue("@Price",Convert.ToDouble( dr.Cells[5].Value.ToString()));
                        cmd.Parameters.AddWithValue("@Cashier", userName);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        insert = true;
                        // loadProduct();
                    }
                    catch (Exception ex)
                {
                    con.Close();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

                }
            }
            if (insert)
            {
                MessageBox.Show("Saved Successfuly", "Cash Product Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            cf.loadCash();
            this.Dispose();
        }

        private void CashProductDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
