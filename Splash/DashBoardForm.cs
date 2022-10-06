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
    public partial class DashBoardForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        MainForm f;
        public DashBoardForm(MainForm ff)
        {
            f = ff;
            InitializeComponent();
        }
        public int extractDashBoardData(string sql)
        {
            int exdata = 0;
            try
            {
               
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader data;
                data=cmd.ExecuteReader();
                if (data.Read())
                {
                    exdata = data.GetInt32(0);
                }
                data.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return exdata;
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            string dogsql = "Select ISNULL(SUM(Quantity),0) as qty from tbProducts where Category='Dogs'";
            qtyDog.Text = extractDashBoardData(dogsql).ToString();
           string catsql= "Select ISNULL(SUM(Quantity),0) as qty from tbProducts where Category='Cats'";
            qtycats.Text= extractDashBoardData(catsql).ToString();
            string birdsql = "Select ISNULL(SUM(Quantity),0) as qty from tbProducts where Category='Birds'";
            qtybird.Text = extractDashBoardData(birdsql).ToString();
            string rabitsql = "Select ISNULL(SUM(Quantity),0) as qty from tbProducts where Category='Rabits'";
            qtyrabit.Text = extractDashBoardData(rabitsql).ToString();

        }
    }
}
