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
    public partial class log_in : Form
    {
    
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public log_in()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            try  {
              
                    if ((textBox1.Text == "admin") && (textBox2.Text == "admin"))
                    {
                        this.Hide();
                        admin f = new admin();
                        f.Show();
                    }

              if ((textBox1.Text != "admin") )
              {
                    con.Open();
                    
                SqlCommand cmd1 = new SqlCommand("Select Name,Password  from Recipient where Name='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                int count1 = 0;



                
                    while (dr1.Read())
                    {
                        count1 ++;

               
                        
                    }
                if (count1 == 1)
                {
                    recipientaccount f = new recipientaccount();
                    this.Hide();
                    f.Show();
                }
              

                con.Close();
            }

              if ((textBox1.Text != "admin"))
              
              {

                  con.Open();

                  SqlCommand cmd = new SqlCommand("Select   Mail ,Password from Donor where Mail='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                  SqlDataReader dr = cmd.ExecuteReader();
                  int count = 0;
                  while (dr.Read())
                  {
                      count += 1;

                  }
                  if (count == 1)
                  {
                      donoraccount f = new donoraccount();
                      this.Hide();
                      f.Show();
                  }
              }
               

            con.Close();
            }
            catch{
                    MessageBox.Show("Error");
                }
        
         
         
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
