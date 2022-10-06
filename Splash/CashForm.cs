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
    public partial class CashForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        MainForm f;
     

        public CashForm(MainForm fo)
        {
            f = fo;
            InitializeComponent();
            loadCash();
            getTransNumber();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashProductForm cpf = new CashProductForm(this);
            cpf.userName = f.UserNameLabel.Text;
            cpf.ShowDialog();
        }
        public void getTransNumber()
        {
            try
            {
                string Nowdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;
                con.Open();
                SqlCommand cmd = new SqlCommand("Select top 1 TransactionNumber from tbCash where TransactionNumber like '" + Nowdate + "%' order by CashID desc", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbltransno.Text = Nowdate + (count + 1);
                }
                else
                {
                    transno = Nowdate + "2001";
                    lbltransno.Text = transno;
                }
                dr.Close();
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

        public void loadCash()
        {
            int no = 0;
            CashProductDataGridView1.Rows.Clear();
            try
            {
                con.Open();
                double total = 0;
                SqlCommand cmd = new SqlCommand("select CashID, ProductCode, ProductName, Quantity, Price, Total, cash.CustomerName, Cashier from tbCash as cash left join tbCustomers c on cash.CashID = c.ID where TransactionNumber like '" + lbltransno.Text + "'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    no++;
                    CashProductDataGridView1.Rows.Add(no, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString());
                    total += double.Parse(data[5].ToString());
                }
                data.Close();
                con.Close();
                lbltot.Text = total.ToString("#,##0.00");
            
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

       
        public int checkPqty(string ProductCode)
        {
            int i = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Quantity FROM tbProducts WHERE ProductCode='" + ProductCode + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    i = dr.GetInt32(0);
                }
                dr.Close();
                con.Close();

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
            return i;
        }
        private void CashProductDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // con.Close();
            string colName = CashProductDataGridView1.Columns[e.ColumnIndex].Name;
            removeitem:
            if (colName == "Del")
            {
                if (MessageBox.Show("Are you Sure you want to Delete Row?", "Cash Form for Pets Store", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from tbCash where CashID='" + CashProductDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfuly", "Cash Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        loadCash();
                    }
                }

            }
            else if (colName == "Increase")
            {
                try
                {
                    string code = CashProductDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int i = checkPqty((code));
                    if (int.Parse(CashProductDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) < i)
                    {
                        con.Open();
                        SqlCommand cmd= new SqlCommand("UPDATE tbCash SET Quantity = Quantity + " + 1 + " WHERE CashID LIKE '" + CashProductDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'",con);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Remaining quantity on hand is " + i + "!", "Out of Stock ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    con.Close();
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                loadCash();
            }
            loadCash();
            }
            else if (colName == "Decrease")
            {
                try
                {
                    con.Open();
                    if (int.Parse(CashProductDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) == 1)
                    {
                        colName = "Del";
                        goto removeitem;
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE tbCash SET Quantity = Quantity - " + 1 + " WHERE CashID LIKE '" + CashProductDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    loadCash();
                }
            }
            loadCash();
        }

        private void cashbutton_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
               
                for (int i = 0; i < CashProductDataGridView1.Rows.Count; ++i)
                {
                    int qtysum = 0;
                    qtysum += Convert.ToInt32(CashProductDataGridView1.Rows[i].Cells[4].Value);
                    SqlCommand cmd = new SqlCommand("UPDATE tbProducts SET Quantity = Quantity - '" + qtysum + "' WHERE ProductCode='" + CashProductDataGridView1.Rows[i].Cells[2].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Cashed Successfuly", "Cash Form for Pets Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                getTransNumber();
                f.loadDailySales();
                CashProductDataGridView1.Rows.Clear();
                lbltot.Text = "0.00";
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

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CashCustomerForm ccf = new CashCustomerForm(this);
            ccf.ShowDialog();
            
        }
    }
}
