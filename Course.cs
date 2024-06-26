using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02HomeTask_A_
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Course values (@Course_Id , @Course_Name ,@Student_Name , @Teacher_Name ,@Semester )", con);
                cmd.Parameters.AddWithValue("@Course_Id", textBox1.Text);
                cmd.Parameters.AddWithValue("@Course_Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Student_Name", textBox3.Text);
                cmd.Parameters.AddWithValue("@Teacher_Name", textBox4.Text);
                cmd.Parameters.AddWithValue("@Semester", textBox5.Text);
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
                SqlCommand cmd = new SqlCommand("Select * from Course", con);
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
                if (MessageBox.Show("Are You Sure You Want To Delete This Record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Course  where Course_Id =@Course_Id", con);
                    cmd.Parameters.AddWithValue("@Course_Id", dataGridView1.Rows[e.RowIndex].Cells[2].Value); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Delete");
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "EDIT")
            {
                if (MessageBox.Show("Are You Sure You Want To Edit This Record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Course_Id"].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Course_Name"].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Name"].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Teacher_Name"].Value.ToString();
                    textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Result frm = new Result();
            frm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE  Course SET   Course_Name = @Course_Name , Student_Name = @Student_Name , Teacher_Name = @Teacher_Name , Semester = @Semester where Course_Id = @Course_Id ", con);
            cmd.Parameters.AddWithValue("@Course_Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Course_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Student_Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@Teacher_Name", textBox4.Text);
            cmd.Parameters.AddWithValue("@Semester", textBox5.Text);
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
