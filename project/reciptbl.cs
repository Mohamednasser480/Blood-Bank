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
    public partial class reciptbl : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public reciptbl()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == ""))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into  Recipient values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text  + "' )";
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
            SqlCommand cmd1 = new SqlCommand("Select Recipient_ID  from Recipient where Recipient_ID='" + textBox1.Text + "'", con);
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
                cmd.CommandText = "delete from Recipient where Recipient_ID='" + textBox1.Text + "'";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select* from Recipient", con);
            cmd1.CommandType = CommandType.Text;

            SqlDataReader reader = cmd1.ExecuteReader();
            DataTable recipient = new DataTable();
            recipient.Columns.Add("Recipient_ID");
            recipient.Columns.Add("Name");
            recipient.Columns.Add("Age");
            recipient.Columns.Add("Gender");
            recipient.Columns.Add("PhoneNumber");
            recipient.Columns.Add("Mail"); 
            recipient.Columns.Add("Password");




            DataRow row;
            while (reader.Read())
            {
                row = recipient.NewRow();
                row["Recipient_ID"] = reader["Recipient_ID"];
                row["Name"] = reader["Name"];

                row["Age"] = reader["Age"];
                row["Gender"] = reader["Gender"];

                row["PhoneNumber"] = reader["PhoneNumber"];
                row["Mail"] = reader["Mail"];
                row["Password"] = reader["Password"];



                recipient.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = recipient;
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox2.Text != "")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Recipient set Name='" + textBox2.Text + "' where Recipient_ID='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            if (textBox3.Text != "")
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "updateRecipient set Age='" + textBox3.Text + "' where Recipient_ID='" + textBox1.Text + "' ";
                cmd1.ExecuteNonQuery();
            }
            if (textBox4.Text != "")
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update Recipient set Gender='" + textBox4.Text + "' where Recipient_ID='" + textBox1.Text + "'  where Donor_ID='" + textBox1.Text + "'";
                cmd2.ExecuteNonQuery();
            }
            if (textBox5.Text != "")
            {
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update Recipient set PhoneNumber='" + textBox5 .Text+ "' where Recipient_ID='" + textBox1.Text + "'  ";
                cmd3.ExecuteNonQuery();
            }
            if (textBox6.Text != "")
            {
                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "  update Recipient set Mail='" + textBox6.Text + "' where Recipient_ID='" + textBox1.Text + "' ";
                cmd4.ExecuteNonQuery();
            }
            if (textBox7.Text != "")
            {
                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "  update Recipient  set Password='" + textBox7.Text + "' where Recipient_ID='" + textBox1.Text + "' ";
                cmd5.ExecuteNonQuery();
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
