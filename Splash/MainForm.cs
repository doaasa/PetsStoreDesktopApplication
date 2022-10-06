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
using System.Timers;

namespace Splash
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=PetsStore;Integrated Security=true;");
        public MainForm()
        {
            InitializeComponent();
            btndashboard.PerformClick();
            loadDailySales();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Log out?", "Pets House", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login log = new Login();
                this.Hide();
                log.Show();
            }
          
        }
        private Form activeform = null;
        public void openChildForm(Form child)
        {
            if(activeform!=null)
              activeform.Close();
            activeform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            title.Text = child.Text;
            panelchildform.Controls.Add(child);
            panelchildform.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            UserForm user = new UserForm();
            
            openChildForm(user);
        }



        private void btnproduct_Click_1(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            openChildForm(prod);
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            CustomersForm cs = new CustomersForm();
            openChildForm(cs);
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            CashForm cf = new CashForm(this);
            openChildForm(cf);
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            DashBoardForm df = new DashBoardForm(this);
            openChildForm(df);
        }
        public void loadDailySales()
        {
            string dailydate = DateTime.Now.ToString("yyyyMMdd");
            
           try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select ISNULL(SUM(Total),0) as total from tbCash where TransactionNumber like'"+dailydate+"%'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                if (data.Read())
                {

                    var daily = data.GetDecimal(0).ToString();
                    lbldailysale.Text = double.Parse(daily).ToString("#,##0.00");
                }
                data.Close();
                con.Close();
                //  lbldailysale.Text = double.Parse(cmd.ExecuteScalar().ToString()).ToString("#,##0.00");

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Timers.Timer time = new System.Timers.Timer();
            time.Interval = 1000;
            time.Elapsed += TimerElapsed;
            time.Start();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            progress.Invoke((MethodInvoker) delegate {
                progress.Text = DateTime.Now.ToString("HH:mm:ss");
                progress.Value = Convert.ToInt32(DateTime.Now.Second);
            });

        }

        private void panelchildform_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
