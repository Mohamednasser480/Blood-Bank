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
    public partial class hospitaltbl : Form

    {
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=BLOODSYSTEM;Integrated Security=SSPI");
        public hospitaltbl()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (!(textBox1.Text == "" || textBox2.Text == ""))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into  Hospital values( '" + textBox1.Text + "','" + textBox2.Text + "' )";
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
            SqlCommand cmd1 = new SqlCommand("Select Hosptial_ID  from Hospital where Hosptial_ID='" + textBox1.Text + "'", con);
            SqlDataReader dr2 = cmd1.ExecuteReader();
            int count1 = 0;
            while (dr2.Read())
            {
                count1 += 1;
            }
            dr2.Close();
            if (count1 == 1)
            {
                SqlCommand cm = con.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "delete from Blood_Hospital where Hosptial_ID='" + textBox1.Text + "'";
                cm.ExecuteNonQuery();



                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Hospital where Hosptial_ID='" + textBox1.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("Select* from Hospital", con);
            cmd4.CommandType = CommandType.Text;

            SqlDataReader reader = cmd4.ExecuteReader();
            DataTable blood = new DataTable();
            blood.Columns.Add("Hosptial_ID");
            blood.Columns.Add("Hosptial_name");





            DataRow row;
            while (reader.Read())
            {
                row = blood.NewRow();
                row["Hosptial_ID"] = reader["Hosptial_ID"];
                row["Hosptial_Name"] = reader["Hosptial_Name"];



                blood.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = blood;
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBox2.Text != "")
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Hospital set Hosptial_Name='" + textBox2.Text + "' where Hosptial_ID='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void hospitaltbl_Load(object sender, EventArgs e)
        {

        }
    }
}
