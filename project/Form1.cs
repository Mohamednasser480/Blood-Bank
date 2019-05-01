using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_in f = new log_in();
            f.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reg_donor_Click(object sender, EventArgs e)
        {
            this.Hide();
           regdonor f = new regdonor();
            f.Show();
        }

        private void regi_reci_Click(object sender, EventArgs e)
        {
            this.Hide();
            regrecipient f = new regrecipient();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
