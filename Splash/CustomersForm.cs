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
    public partial class CustomersForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");

        public CustomersForm()
        {
            InitializeComponent();
            loadCustomer();
        }
        public void loadCustomer()
        {
            int no = 0;
            CustomersDatagridview.Rows.Clear();
            string search = searchTxtbox.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from tbCustomers where CONCAT(ID,CustomerName,Age,Address,PhoneNumber,InterestedPet)LIKE '%" + search + "%'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    no++;
                    CustomersDatagridview.Rows.Add(no, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString());

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

        private void CustomersDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName =CustomersDatagridview.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomersRecordForm cust = new CustomersRecordForm(this);
                
                cust.labelID.Text = CustomersDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                cust.nametxtbox.Text = CustomersDatagridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                cust.addresstxtbox.Text = CustomersDatagridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                cust.Pntxtbox.Text = CustomersDatagridview.Rows[e.RowIndex].Cells[4].Value.ToString();
                cust.agetxtbox.Text = CustomersDatagridview.Rows[e.RowIndex].Cells[5].Value.ToString();
                cust.inter.Text = CustomersDatagridview.Rows[e.RowIndex].Cells[6].Value.ToString();
                cust.savebtn.Enabled = false;
                cust.labelID.Visible = true;
                cust.Show();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you Sure you want to Delete Row?", "User Record Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from tbCustomers where ID='" + CustomersDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfuly", "User Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        loadCustomer();
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomersRecordForm crf = new CustomersRecordForm(this);
            crf.Show();

        }
    }
}
