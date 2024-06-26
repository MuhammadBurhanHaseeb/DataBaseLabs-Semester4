using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02HomeTask_A_
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Student values (@RegistrationNumber , @Name, @Department , @Session , @Address)", con);
                cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Department", textBox3.Text);
                cmd.Parameters.AddWithValue("@Session", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select * from Student", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Record ?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Student  where RegistrationNumber =@RegistrationNumber", con);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", dataGridView1.Rows[e.RowIndex].Cells[2].Value); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Delete");
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "EDIT")
            {
                if (MessageBox.Show("Are You Sure You Want To Edit This Record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["RegistrationNumber"].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Department"].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Session"].Value.ToString();
                    textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course frm = new Course();
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Student SET  Name = @Name, Department = @Department , Session = @Session , Address = @Address where RegistrationNumber = @RegistrationNumber ", con);
            cmd.Parameters.AddWithValue("@RegistrationNumber", textBox1.Text);
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Department", textBox3.Text);
            cmd.Parameters.AddWithValue("@Session", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Address", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Update");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
