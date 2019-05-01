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
    public partial class regrecipient : Form
    {
        public regrecipient()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
            con.Open();
            SqlCommand c = new SqlCommand("Select Recipient_ID from Recipient", con);
            c.CommandType = CommandType.Text;
            SqlDataReader reader = c.ExecuteReader();
            DataTable rec = new DataTable();
            rec.Columns.Add("Recipient_ID");
          
            DataRow row;
            while (reader.Read())
            {
                rec.Rows.Clear();
                row = rec.NewRow();
                row["Recipient_ID"] = reader["Recipient_ID"];
               

                rec.Rows.Add(row);
                dataGridView1.DataSource = rec;
            }
            reader.Close();
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
           
            try
            {

                if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == ""))
                {
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");

                    con.Open();
                    

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Recipient values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Added successfully");
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("some data  are required");
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void regrecipient_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
