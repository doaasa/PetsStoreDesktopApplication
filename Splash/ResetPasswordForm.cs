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
    public partial class ResetPasswordForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            if (username != "")
            {
                con.Open();
                if (passtxt.Text == guna2TextBox1.Text)
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Update tbUsers set Password='" + passtxt + "' where Name='" + username + "'", con);
                        cmd.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("Password Updated Successfully", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login l = new Login();
                        l.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter the username", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
