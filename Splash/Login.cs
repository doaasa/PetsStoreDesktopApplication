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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        public Login()
        {
            InitializeComponent();
        }

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passtxt.Text;
            if (username != "" && password != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select Role from tbUsers where Name='" + username + "'and Password='" + password + "'", con);
                    SqlDataReader data;
                    data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        MainForm main = new MainForm();
                        main.UserNameLabel.Text = username;
                        main.RoleLabel.Text = data.GetString(0);
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password is WRONG!!", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else if  (username != "" || password == "")
            {
                MessageBox.Show("Password Field must be FILLED!!!", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username == "" || password != "")
            {
                MessageBox.Show("UserName Field must be FILLED!!!", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username == "" && password == "")
            {
                MessageBox.Show("Required Fields must be FILLED!!!", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = usernametxt.Text;
            if (username != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Role from tbUsers where Name='" + username + "'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                if (data.Read())
                {
                    if (data.GetString(0).ToString() == "Owner" || data.GetString(0).ToString() == "Admin")
                    {
                        ResetPasswordForm r = new ResetPasswordForm();
                        r.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Ask Owner to change your Password!!", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter valid username!!", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            else
            {
                MessageBox.Show("Please enter your username", "Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}

