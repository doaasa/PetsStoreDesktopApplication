using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class UserRecordForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        UserForm user;
        bool check = false;

        public UserRecordForm(UserForm User)
        {
            InitializeComponent();
            user = User;
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = nametxtbox.Text;
            string age = agetxtbox.Text;
            string adrs = addresstxtbox.Text;
            string phone = Pntxtbox.Text;
            string password = passtxtbox.Text;
            string role = Role.Text;
            string ava;
            if (guna2CustomCheckBox1.Checked)
            {
                ava = "yes";
            }
            else
            {
                ava = "false";
            }
            Checkfields();
            if (check)
            { 
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into tbUsers(Name,Age,PhoneNumber,Address,Role,Available,Password)values(@Name,@Age,@PhoneNumber,@Address,@Role,@Available,@Password)", con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    cmd.Parameters.AddWithValue("@Address", adrs);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Available", ava);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfuly", "User Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    user.loadUser();
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
        public void clear()
        {
            nametxtbox.Clear();
            passtxtbox.Clear();
            Pntxtbox.Clear();
            agetxtbox.Clear();
            addresstxtbox.Clear();
            Role.SelectedIndex=0;
            guna2CustomCheckBox1.Checked = true;

        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you Sure you want to Cancel Updates?", "User Record Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
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
            string password = passtxtbox.Text;
            string role = Role.Text;
            string ava;
            if (guna2CustomCheckBox1.Checked)
            {
                ava = "yes";
            }
            else
            {
                ava = "false";
            }
            Checkfields();
            if (check)
            {
                if (password!="")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Update tbUsers Set Age='" + age + "',Name='" + name + "',PhoneNumber='" + phone + "',Address='" + adrs + "',Role='" + role + "',Available='" + ava + "',Password='" + password + "'where ID='" + labelID.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfuly", "User Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        user.loadUser();
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
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update tbUsers Set Age='" + age + "',Name='" + name + "',PhoneNumber='" + phone + "',Address='" + adrs + "',Role='" + role + "',Available='" + ava + "'where ID='" + labelID.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfuly", "User Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    user.loadUser();
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

        public void Checkfields()
        {
            if (nametxtbox.Text == "")
            {
                MessageBox.Show("Name Required Field Must be Filled", "User Record Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            check = true;
        }
        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Role.Text == "Employee" || Role.Text == "Cashier" || Role.Text == "Seller")
            {
                passtxtbox.Enabled = false;
                
            }
        }

        private void agetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Pntxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
