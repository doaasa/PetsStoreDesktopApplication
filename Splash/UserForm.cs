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
    public partial class UserForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        public UserForm()
        {
            InitializeComponent();
            loadUser();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            UserRecordForm user = new UserRecordForm(this);
            user.updatebtn.Enabled = false;
            user.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadUser()
        {
            int no = 0;
            UserDatagridview.Rows.Clear();
            string search = searchTxtbox.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from tbUsers where CONCAT(Name,Age,PhoneNumber,Address,Role,Available)LIKE '%" + search + "%'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    no++;
                    UserDatagridview.Rows.Add(no, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(),data[6].ToString());
                    
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

        private void UserDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = UserDatagridview.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserRecordForm user = new UserRecordForm(this);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Password from tbUsers where ID='"+ UserDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString()+"'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                if (data.Read())
                {
                    user.passtxtbox.Text = data.GetString(0);
                }
                con.Close();
                user.labelID.Text= UserDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
                user.nametxtbox.Text = UserDatagridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                user.agetxtbox.Text = UserDatagridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                user.Pntxtbox.Text = UserDatagridview.Rows[e.RowIndex].Cells[4].Value.ToString();
                user.addresstxtbox.Text = UserDatagridview.Rows[e.RowIndex].Cells[5].Value.ToString();
                user.Role.Text = UserDatagridview.Rows[e.RowIndex].Cells[6].Value.ToString();
                user.guna2CustomCheckBox1.Text = UserDatagridview.Rows[e.RowIndex].Cells[7].Value.ToString();
                user.savebtn.Enabled = false;
                user.labelID.Visible = true;
                user.Show();

            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you Sure you want to Delete Row?", "User Record Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from tbUsers where ID='" + UserDatagridview.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
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
                        loadUser();
                    }
                }
                
            }
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
