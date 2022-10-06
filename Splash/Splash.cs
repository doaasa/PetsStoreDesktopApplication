using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 5;
            guna2ProgressBar1.Value = startpoint;
            if(guna2ProgressBar1.Value==100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();

            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        internal class Custom_Controlls
        {
            internal class UserControl1
            {
                public Color BackColor { get; internal set; }
                public Color BorderColor { get; internal set; }
                public Color BorderFocusColor { get; internal set; }
                public int BorderSize { get; internal set; }
                public bool UnderlinedStyle { get; internal set; }
                public string Texts { get; internal set; }
                public int TabIndex { get; internal set; }
                public Size Size { get; internal set; }
                public bool PasswordChar { get; internal set; }
                public Font Font { get; internal set; }
                public Color ForeColor { get; internal set; }
                public Point Location { get; internal set; }
                public Padding Margin { get; internal set; }
                public bool Multiline { get; internal set; }
                public string Name { get; internal set; }
                public Padding Padding { get; internal set; }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
