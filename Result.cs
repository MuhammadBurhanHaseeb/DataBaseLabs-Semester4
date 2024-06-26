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

namespace Lab02HomeTask_A_
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into Result values (@Student_Id , @Student_Name , @Course_Name , @Marks , @Grade , @Section ,@Semester ,@Session )", con);
                cmd.Parameters.AddWithValue("@Student_Id", textBox1.Text);
                cmd.Parameters.AddWithValue("@Student_Name", textBox2.Text);
                cmd.Parameters.AddWithValue("@Course_Name", textBox3.Text);
                cmd.Parameters.AddWithValue("@Marks", int.Parse(textBox4.Text));
                cmd.Parameters.AddWithValue("@Grade", textBox5.Text);
                cmd.Parameters.AddWithValue("@Section", textBox6.Text);
                cmd.Parameters.AddWithValue("@Semester", int.Parse(textBox7.Text));
                cmd.Parameters.AddWithValue("@Session", int.Parse(textBox8.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
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
                SqlCommand cmd = new SqlCommand("Select * from Result", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show("Are You Sure You Want To Delete This Record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Result  where Student_Id =@Student_Id", con);
                    cmd.Parameters.AddWithValue("@Student_Id", dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Delete");
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "EDIT")
            {
                if (MessageBox.Show("Are You Sure You Want To Edit This Record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Id"].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Student_Name"].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Course_Name"].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Marks"].Value.ToString();
                    textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Grade"].Value.ToString();
                    textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Section"].Value.ToString();
                    textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
                    textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells["Session"].Value.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE  Result SET Student_Name = @Student_Name , Course_Name = @Course_Name , Marks = @Marks , Grade = @Grade , Section = @Section , Semester = @Semester , Session = @Session where Student_Id =@Student_Id ", con);
            cmd.Parameters.AddWithValue("@Student_Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@Student_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Course_Name", textBox3.Text);
            cmd.Parameters.AddWithValue("@Marks", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Grade", textBox5.Text);
            cmd.Parameters.AddWithValue("@Section", textBox6.Text);
            cmd.Parameters.AddWithValue("@Semester", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@Session", int.Parse(textBox8.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Update");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
