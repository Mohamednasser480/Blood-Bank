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
    public partial class recipientaccount : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public recipientaccount()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             con.Open();
            SqlCommand cmd = new SqlCommand("Select* from Blood where Type='"+textBox1.Text+"' ", con);
            cmd.CommandType = CommandType.Text;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable blood = new DataTable();
            blood.Columns.Add("Blood ID");
            blood.Columns.Add("Type");
   


            DataRow row;
            while (reader.Read())
            {
                row = blood.NewRow();
                row["Blood ID"]  = reader[0];
                row["Type"] = reader[1];
                
                blood.Rows.Add(row);
            }
         

            reader.Close();
           
            


          
            dataGridView2.DataSource = blood;
            

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.RefreshEdit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                if (textBox2.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update   Recipient set Name='" + textBox2.Text + "' where Mail='" + textBox7.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                if (textBox3.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update   Recipient set Age='" + textBox3.Text + "' where Mail='" + textBox7.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                if (textBox4.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update   Recipient set Gender='" + textBox4.Text + "' where Mail='" + textBox7.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                if (textBox5.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update   Recipient set PhoneNumber='" + textBox5.Text + "' where Mail='" + textBox7.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                if (textBox6.Text != "")
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update   Recipient set Password='" + textBox6.Text + "' where Mail='" + textBox7.Text + "'";
                    cmd.ExecuteNonQuery();
                }   

                con.Close();
                MessageBox.Show("updated successfully");
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cm = new SqlCommand("Select Donor_ID,Recived_Date,Expiry_Date from Donor_Blood where Blood_ID='" + textBox8.Text + "' ", con);
            cm.CommandType = CommandType.Text;

            SqlDataReader reader1 = cm.ExecuteReader();
            DataTable blood_donor = new DataTable();
            blood_donor.Columns.Add("Donor_ID");
            blood_donor.Columns.Add("Recived_Date");
            blood_donor.Columns.Add("Expiry_Date");


            DataRow row1;
            while (reader1.Read())
            {
                row1 = blood_donor.NewRow();
                row1["Donor_ID"] = reader1["Donor_ID"];
                row1["Recived_Date"] = reader1["Recived_Date"];
                row1["Expiry_Date"] = reader1["Expiry_Date"];

                blood_donor.Rows.Add(row1);
            }


            reader1.Close();
            dataGridView1.DataSource = blood_donor;


            con.Close();
            con.Open();
            SqlCommand cm1 = new SqlCommand("Select Hosptial_ID from Hospital where Blood_ID='" + textBox8.Text + "' ", con);
            cm1.CommandType = CommandType.Text;

            SqlDataReader reader0 = cm.ExecuteReader();
            DataTable blood_donor0 = new DataTable();
            blood_donor.Columns.Add("Hosptial_ID");
           


            DataRow r;
            while (reader1.Read())
            {
                r = blood_donor.NewRow();
                r["Hosptial_ID"] = reader0["Hosptial_ID"];
               

                blood_donor0.Rows.Add(r);
            }


            reader1.Close();
            dataGridView4.DataSource = blood_donor0;


            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand c = new SqlCommand("Select UserName,Age,Gender,PhoneNumber,Donor_Diseases from Donor where Donor_ID='" + textBox9.Text + "' ", con);
            c.CommandType = CommandType.Text;

            SqlDataReader reader2 = c.ExecuteReader();
            DataTable blood_donor1 = new DataTable();
            blood_donor1.Columns.Add("UserName");
            blood_donor1.Columns.Add("Age");
            blood_donor1.Columns.Add("Gender");
            blood_donor1.Columns.Add("PhoneNumber");
            blood_donor1.Columns.Add("Donor_Diseases");


            DataRow row2;
            while (reader2.Read())
            {
                row2 = blood_donor1.NewRow();
                row2["UserName"] = reader2["UserName"];
                row2["Age"] = reader2["Age"];
                row2["Gender"] = reader2["Gender"];
                row2["PhoneNumber"] = reader2["PhoneNumber"];
                row2["Donor_Diseases"] = reader2["Donor_Diseases"];

                blood_donor1.Rows.Add(row2);
            }


            reader2.Close();
            dataGridView3.DataSource = blood_donor1;


            con.Close();
            con.Open();
            SqlCommand c1 = new SqlCommand("Select UserName,Age,Gender,PhoneNumber,Donor_Diseases from Donor where Donor_ID='" + textBox9.Text + "' ", con);
            c1.CommandType = CommandType.Text;

            SqlDataReader re = c.ExecuteReader();
            DataTable b= new DataTable();
            b.Columns.Add("UserName");
            b.Columns.Add("Age");
            b.Columns.Add("Gender");
            b.Columns.Add("PhoneNumber");
            b.Columns.Add("Donor_Diseases");


            DataRow ro;
            while (re.Read())
            {
                ro = b.NewRow();
                ro["UserName"] = re["UserName"];
                ro["Age"] = re["Age"];
                ro["Gender"] = re["Gender"];
                ro["PhoneNumber"] = re["PhoneNumber"];
                ro["Donor_Diseases"] = re["Donor_Diseases"];

                b.Rows.Add(ro);
            }


            re.Close();
            dataGridView5.DataSource = b;


            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into  Blood_Recipient values( '" + textBox8.Text + "','" + textBox8.Text + "',    ,'" + textBox8.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added successfully");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
    }

