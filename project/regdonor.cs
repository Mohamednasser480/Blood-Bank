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
    public partial class regdonor : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public regdonor()
        {
           
            InitializeComponent();
            fill(); 
            




        }
        void fill()
        {
            SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
            con.Open();
            SqlCommand c = new SqlCommand("Select Donor_ID,Blood_ID,Hosptial_ID from Donor,Blood,Hospital", con);
            c.CommandType = CommandType.Text;
            SqlDataReader reader = c.ExecuteReader();
            DataTable donor = new DataTable();
            donor.Columns.Add("Donor_ID");
            donor.Columns.Add("Blood_ID");
            donor.Columns.Add("Hosptial_ID");
            DataRow row;
            while (reader.Read())
            {
                donor.Rows.Clear();
                row = donor.NewRow();
                row["Donor_ID"] = reader["Donor_ID"];
                row["Blood_ID"] = reader["Blood_ID"];
                row["Hosptial_ID"] = reader["Hosptial_ID"];

                donor.Rows.Add(row);
                dataGridView1.DataSource = donor;
            }
            reader.Close();
            con.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == ""))
                {
                    SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
                    con.Open();

                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert  into Donor values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                    cmd.ExecuteNonQuery();

                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "insert into Blood values( '" + textBox9.Text + "','" + textBox10.Text + "')";
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = con.CreateCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "insert into Hospital values( '" + textBox11.Text + "','" + textBox12.Text + "')";
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "insert into Blood_Hospital values( '" + textBox9.Text + "','" + textBox11.Text + "')";
                    cmd5.ExecuteNonQuery();

                    SqlCommand cmd6 = con.CreateCommand();
                    cmd6.CommandType = CommandType.Text;
                    cmd6.CommandText = "insert into Donor_Blood values('" + textBox1.Text + "','" + textBox1.Text + "','" + textBox9.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "')";
                    cmd6.ExecuteNonQuery();
                    con.Close();
                    fill();
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
                MessageBox.Show("Error");
            }
   
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regdonor_Load(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
