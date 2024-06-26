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
    public partial class updatestudent : Form
    {
         public int id = 0;
        public updatestudent()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                var con = dataconnection.getInstance().getConnection();
                SqlCommand cmd1 = new SqlCommand("Select Id from Student Where RegistrationNo = @registrationno1", con);
                cmd1.Parameters.AddWithValue("@registrationno1", txtoldregistrationno.Text);
                if (cmd1.ExecuteScalar() != null)
                {
                    id = (int)cmd1.ExecuteScalar();
                    txtnewregistrationno.Text = txtoldregistrationno.Text;
                    SqlCommand cmd2 = new SqlCommand("Select FirstName from Person Where Id = @Id", con);
                    cmd2.Parameters.AddWithValue("@Id", id);
                    txtfirstname.Text = (string)cmd2.ExecuteScalar();
                    SqlCommand cmd3 = new SqlCommand("Select LastName from Person Where Id = @Id1", con);
                    cmd3.Parameters.AddWithValue("@Id1", id);
                    if(cmd3.ExecuteScalar()!= null)
                    {
                    txtlastname.Text = (string)cmd3.ExecuteScalar();
                    }
                    SqlCommand cmd4 = new SqlCommand("Select Contact from Person Where Id = @Id2", con);
                    cmd4.Parameters.AddWithValue("@Id2", id);
                    if (cmd4.ExecuteScalar() != null)
                    {
                        txtcontact.Text = (string)cmd4.ExecuteScalar();
                    }
                    SqlCommand cmd5 = new SqlCommand("Select Email from Person Where Id = @Id3", con);
                    cmd5.Parameters.AddWithValue("@Id3", id);
                    if (cmd4.ExecuteScalar() != null)
                    {
                        txtemail.Text = (string)cmd5.ExecuteScalar();
                    }
                    SqlCommand cmd6 = new SqlCommand("Select DateOfBirth from Person Where Id = @Id4", con);
                    cmd6.Parameters.AddWithValue("@Id4", id);
                    if (cmd6.ExecuteScalar() != null)
                    {
                        DateTime dateTimeValue = (DateTime)cmd6.ExecuteScalar();
                        txtdateofbirth.Text = dateTimeValue.ToString();
                    }
                    SqlCommand cmd7 = new SqlCommand("Select Gender from Person Where Id = @Id5", con);
                    cmd7.Parameters.AddWithValue("@Id5", id);
                    if (cmd6.ExecuteScalar() != null)
                    {
                        SqlCommand cmd8 = new SqlCommand("Select Value from Lookup Where Id = @Id6", con);
                        cmd8.Parameters.AddWithValue("@Id6", (int)cmd7.ExecuteScalar());
                        txtgender.Text = (string)cmd8.ExecuteScalar();
                    }

                    
                 

                }
                if (cmd1.ExecuteScalar() == null)
                {
                    MessageBox.Show("Please Enter the correct Registration Number");
                }
            }
            catch
            {

            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            int Gender = 0;
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Please Enter the Correct Registration No");
                }
                else
                {
                    var con = dataconnection.getInstance().getConnection();
                    SqlCommand cmd10 = new SqlCommand("Select Id from Lookup where Value =@Id", con);
                    cmd10.Parameters.AddWithValue("@Id", txtgender.Text);
                    SqlDataReader reader1;
                    reader1 = cmd10.ExecuteReader();
                    if (reader1.Read())
                    {
                        Gender = int.Parse(reader1["Id"].ToString());
                    }
                    reader1.Close();
                    SqlCommand cmd9 = new SqlCommand("Update Person SET FirstName = @FirstName,LastName = @LastName,Contact = @Contact,Email = @Email,DateOfBirth = @DateOfBirth,Gender = @Gender Where Id = @Id5", con);
                    cmd9.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd9.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd9.Parameters.AddWithValue("@Contact", txtcontact.Text);
                    cmd9.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd9.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(txtdateofbirth.Text));
                    cmd9.Parameters.AddWithValue("@Gender", Gender);
                    cmd9.Parameters.AddWithValue("@Id5", id);
                    cmd9.ExecuteNonQuery();
                    txtfirstname.Clear();
                    txtlastname.Clear();
                    txtemail.Clear();
                    txtcontact.Clear();
                    txtemail.Clear();
                    txtdateofbirth.Clear();
                    SqlCommand cmd11 = new SqlCommand("Update Student Set RegistrationNo = @RegistrationNo Where Id = @Id6", con);
                    cmd11.Parameters.AddWithValue("@RegistrationNo", txtnewregistrationno.Text);
                    cmd11.Parameters.AddWithValue("@Id6", id);
                    cmd11.ExecuteNonQuery();
                    txtnewregistrationno.Clear();
                    txtoldregistrationno.Clear();
                    MessageBox.Show("Data Updated  Successfully");
                    id = 0;
                }
            }
            catch
            {
                MessageBox.Show("Please Enter the Correct Informtion");
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
