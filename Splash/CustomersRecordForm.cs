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
    public partial class CustomersRecordForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        bool check = false;
        CustomersForm cf;
        public CustomersRecordForm(CustomersForm c)
        {
            InitializeComponent();
            cf = c;
            clear();
        }

        public void Checkfields()
        {
            if (nametxtbox.Text == "")
            {
                MessageBox.Show("Name Required Field Must be Filled", "User Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            check = true;
        }
        public void clear()
        {
            nametxtbox.Clear();
            Pntxtbox.Clear();
            agetxtbox.Clear();
            addresstxtbox.Clear();
            inter.SelectedIndex = 0;

        }
        private void addresstxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Cancel Updates?", "Customers Record Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string name = nametxtbox.Text;
            string age = agetxtbox.Text;
            string adrs = addresstxtbox.Text;
            string phone = Pntxtbox.Text;
            string intr = inter.Text; 
           
            Checkfields();
            if (check)
            {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update tbCustomers Set Age='" + age + "',CustomerName='" + name + "',PhoneNumber='" + phone + "',Address='" + adrs + "',InterestedPet='" + intr + "'where ID='" + labelID.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfuly", "Cuatomers Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        cf.loadCustomer();
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

        private void savebtn_Click(object sender, EventArgs e)
        {
            string name = nametxtbox.Text;
            string age = agetxtbox.Text;
            string adrs = addresstxtbox.Text;
            string phone = Pntxtbox.Text;
            string intr = inter.Text;

            Checkfields();
            if (check)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into tbCustomers(CustomerName,Address,PhoneNumber,Age,InterestedPet)values(@CustomerName,@Address,@PhoneNumber,@Age,@InterestedPet)", con);
                    cmd.Parameters.AddWithValue("@CustomerName", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Address", adrs);
                    cmd.Parameters.AddWithValue("@InterestedPet", intr);
              
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfuly", "Cuatomers Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    cf.loadCustomer();
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

        private void agetxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void agetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
   
}
