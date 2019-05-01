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
    public partial class donortbl : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public donortbl()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
           
            try
            {
                con.Open();
                if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox7.Text == ""))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into Donor values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
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
            SqlCommand cmd1 = new SqlCommand("Select Donor_ID  from Donor where Donor_ID='" + textBox1.Text + "'", con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            int count1 = 0;
            while (dr1.Read())
            {
                count1 ++;
            }
            dr1.Close();
            if (count1 == 1)
            {

                SqlCommand cm = con.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "delete from Donor_Blood where Donor_ID='" + textBox1.Text + "'";
                cm.ExecuteNonQuery();
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Donor where Donor_ID='" + textBox1.Text + "'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select* from Donor", con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable donor = new DataTable();
            donor.Columns.Add("Donor_ID");
            donor.Columns.Add("UserName");
            donor.Columns.Add("Password");
            donor.Columns.Add("Age");
            donor.Columns.Add("Gender");
            donor.Columns.Add("Mail");
            donor.Columns.Add("PhoneNumber");
            donor.Columns.Add("Donor_Diseases");


            DataRow row;
            while (reader.Read())
            {
                row = donor.NewRow();
                row["Donor_ID"] = reader["Donor_ID"];
                row["UserName"] = reader["UserName"];
                row["Password"] = reader["Password"];
                row["Age"] = reader["Age"];
                row["Gender"] = reader["Gender"];
                row["Mail"] = reader["Mail"];
                row["PhoneNumber"] = reader["PhoneNumber"];
                row["Donor_Diseases"] = reader["Donor_Diseases"];


                donor.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = donor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            if(textBox2.Text!="")
            {
                SqlCommand cmd= con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Donor set UserName='"+textBox2.Text+"' where Donor_ID='"+textBox1.Text+"'";
                cmd.ExecuteNonQuery();
            }
            if (textBox3.Text != "")
            {
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "update Donor set Password='" + textBox3.Text + "' where Donor_ID='" + textBox1.Text + "' ";
                cmd1.ExecuteNonQuery();
            }
            if (textBox4.Text != "")
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "update Donor set Age='" + textBox4.Text + "' where Donor_ID='" + textBox1.Text + "'  where Donor_ID='" + textBox1.Text + "'";
                cmd2.ExecuteNonQuery();
            }
            if (textBox5.Text != "")
            {
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "update Donor set Gender='" + textBox5.Text + "' where Donor_ID='" + textBox1.Text + "'  ";
                cmd3.ExecuteNonQuery();
            }
            if (textBox6.Text != "")
            {
                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.CommandText = "  update Donor set Mail='" + textBox6 .Text+ "' where Donor_ID='" + textBox1.Text + "' ";
                cmd4.ExecuteNonQuery();
            }
            if (textBox7.Text != "")
            {
                SqlCommand cmd5 = con.CreateCommand();
                cmd5.CommandType = CommandType.Text;
                cmd5.CommandText = "update Donor set PhoneNumber='" + textBox7.Text + "' where Donor_ID='" + textBox1.Text + "' ";
                cmd5.ExecuteNonQuery();
            }
            if (textBox8.Text != "")
            {
                SqlCommand cmd6 = con.CreateCommand();
                cmd6.CommandType = CommandType.Text;
                cmd6.CommandText = "update Donor set Donor_Diseasesr='" + textBox8 .Text+ "'  where Donor_ID='" + textBox1.Text + "'";
                cmd6.ExecuteNonQuery();
            }
            con.Close();

            
        }

        private void donortbl_Load(object sender, EventArgs e)
        {

        }
    }
}
