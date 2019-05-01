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

namespace project
{
    public partial class donoraccount : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public donoraccount()
        {
            
            InitializeComponent();
          

       
        }

        private void donoraccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                if (textBox2.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update Donor set UserName='" + textBox2.Text + "' where Mail='" + textBox6.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                if (textBox3.Text != "")
                {
                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "update Donor set Password='" + textBox3.Text + "' where Mail='" + textBox6.Text + "' ";
                    cmd1.ExecuteNonQuery();
                }
                if (textBox4.Text != "")
                {
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "update Donor set Age='" + textBox4.Text + "' where Mail='" + textBox6.Text + "'";
                    cmd2.ExecuteNonQuery();
                }
                if (textBox5.Text != "")
                {
                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "update Donor set Gender='" + textBox5.Text + "' where Mail='" + textBox6.Text + "'  ";
                    cmd3.ExecuteNonQuery();
                }

                if (textBox7.Text != "")
                {
                    SqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "update Donor set PhoneNumber='" + textBox7.Text + "' where Mail='" + textBox6.Text + "' ";
                    cmd5.ExecuteNonQuery();
                }
                if (textBox8.Text != "")
                {
                    SqlCommand cmd6 = con.CreateCommand();
                    cmd6.CommandType = CommandType.Text;
                    cmd6.CommandText = "update Donor set Donor_Diseasesr='" + textBox8.Text + "'  where Mail='" + textBox6.Text + "'";
                    cmd6.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("updated successfully");
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            log_in f = new log_in();
            f.Show();
        }
    }
}
