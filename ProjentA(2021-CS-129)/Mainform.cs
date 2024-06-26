using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjentA_2021_CS_139_
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try { 
            var con = dataconnection.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from student Where Name = @Name", con);
            cmd.Parameters.AddWithValue("@Name", txtsearch.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
            catch
            {
                MessageBox.Show("Student Not Found");
            }
        }

        private void btncreatestudent_Click(object sender, EventArgs e)
        {
            Createstudent var1 = new Createstudent();
            var1.ShowDialog();
        }
    }
}
