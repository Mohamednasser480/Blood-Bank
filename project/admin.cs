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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            donortbl f = new donortbl();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            reciptbl f = new reciptbl();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bloodtbl f = new bloodtbl ();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_in f = new log_in();
            f.Show();
        }

     

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            hospitaltbl f = new hospitaltbl();
            f.Show();
        }
    }
}
