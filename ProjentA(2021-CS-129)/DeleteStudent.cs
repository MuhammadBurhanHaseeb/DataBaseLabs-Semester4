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

namespace ProjentA_2021_CS_139_
{
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int  id = 0;
                var con = dataconnection.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select Id from Student Where RegistrationNo = @registrationno1", con);
                cmd1.Parameters.AddWithValue("@registrationno1", txtregistrationno.Text);
                if(cmd1.ExecuteScalar() != null)
                {
                    id = (int)cmd1.ExecuteScalar();
                    var con1 = dataconnection.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE  from Person Where Id = @Id", con1);
                    cmd.Parameters.AddWithValue("@Id", id);
                    MessageBox.Show("Successfully Deleted");
                }
                if (cmd1.ExecuteScalar() == null)
                {
                    MessageBox.Show("Registration number is incorrect");
                }
            }
            catch
            {
               
            }

        }
    }
}
