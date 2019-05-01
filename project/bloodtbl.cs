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
    public partial class bloodtbl : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public bloodtbl()
        {
          
            InitializeComponent();
        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (!(textBox1.Text == "" || textBox2.Text == "" ))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into  Blood values( '" + textBox1.Text + "','" + textBox2.Text + "' )";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Added successfully");

                }
                else
                {
                    MessageBox.Show("some data  are required");
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "delete from Blood_hospital where Blood_ID='" + textBox1.Text + "'";
            cm.ExecuteNonQuery();

          


            SqlCommand cmd1 = new SqlCommand("Select Blood_ID  from Blood where Blood_ID='" + textBox1.Text + "'", con);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            int count1 = 0;
            while (dr2.Read())
            {
                count1 += 1;
            }
            dr2.Close();
            if (count1 == 1)
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Blood where Blood_ID='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();

                MessageBox.Show("deleted successfully");

            }
            else
            {
                MessageBox.Show("data is already not found");
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin f = new admin();
            f.Show();
        }

        private void bloodtbl_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select* from Blood", con);
            cmd3.CommandType = CommandType.Text;

            SqlDataReader reader = cmd3.ExecuteReader();
            DataTable blood = new DataTable();
            blood.Columns.Add("Blood_ID");
            blood.Columns.Add("Type");





            DataRow row;
            while (reader.Read())
            {
                row = blood.NewRow();
                row["BLOOD_ID"] = reader["BLOOD_ID"];
                row["Type"] = reader["type"];



                blood.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = blood;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox2.Text != "")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Blood set Type='" + textBox2.Text + "' where Blood_ID='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

      
    }
}
