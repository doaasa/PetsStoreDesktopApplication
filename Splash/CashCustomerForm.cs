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
    public partial class CashCustomerForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        CashForm cf;
        public CashCustomerForm(CashForm c)
        {
            cf = c;
            InitializeComponent();
            loadCustomer();
            cf.loadCash();
        }
        public void loadCustomer()
        {
            int no = 0;
            CashCustomerDatagridview.Rows.Clear();
            string search = searchTxtbox.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ID,CustomerName,PhoneNumber from tbCustomers where CONCAT(ID,CustomerName,PhoneNumber)LIKE '%" + search + "%'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    no++;
                    CashCustomerDatagridview.Rows.Add(no, data[0].ToString(), data[1].ToString(), data[2].ToString());

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

        private void CashCustomerDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = CashCustomerDatagridview.Columns[e.ColumnIndex].Name;
            if (colName == "Remove")
            {
                if (MessageBox.Show("Are you Sure you want to UnSelect this Row?", "Cash Customer Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CashCustomerDatagridview.ClearSelection();
                }

            }
            else if (colName == "Choice")
            {
                try
                {
                    con.Open();
                    string customerId = CashCustomerDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string customerName = CashCustomerDatagridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                    SqlCommand cmd = new SqlCommand("UPDATE tbCash set CustomerID='"+customerId+ "', CustomerName='" + customerName + "' where TransactionNumber='" + cf.lbltransno.Text+"'", con);
                    cmd.ExecuteReader();
                    cf.loadCash();
                    this.Dispose();
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
            cf.loadCash();

        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            loadCustomer();
        }
    }
}
