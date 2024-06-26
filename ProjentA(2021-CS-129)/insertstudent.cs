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
    public partial class insertstudent : Form
    {
        public insertstudent()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {




            try
            {


                int Gender = 0;
                int id = 0;
                var con = dataconnection.getInstance().getConnection();
                SqlCommand cmd13 = new SqlCommand("Select Id From Student Where RegistrationNo = @regno", con);
                cmd13.Parameters.AddWithValue("@regno", txtregistrationno.Text);
                if (cmd13.ExecuteScalar() != null)
                {
                    MessageBox.Show("This Student is Already Registered");
                }
                if (cmd13.ExecuteScalar() == null)
                {
                    SqlCommand cmd1 = new SqlCommand("Select Id from Lookup where Value =@Id", con);
                    cmd1.Parameters.AddWithValue("@Id", txtgender.Text);
                    SqlDataReader reader1;
                    reader1 = cmd1.ExecuteReader();
                    if (reader1.Read())
                    {
                        Gender = int.Parse(reader1["Id"].ToString());
                    }
                    reader1.Close();
                    var con1 = dataconnection.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("Select MAX(Id) From Person", con1);
                    id = (int)cmd.ExecuteScalar();
                    if (id != 0)
                    {
                        id = id + 1;
                    }
                    if (id == 0)
                    {
                        id = 1000;
                    }
                    var con2 = dataconnection.getInstance().getConnection();
                    SqlCommand cmd3 = new SqlCommand(" SET IDENTITY_INSERT Person ON ; Insert into   Person (Id,FirstName,LastName,Contact,Email,DateOfBirth,Gender) values (@Id, @FirstName,@LastName,@Contact,@Email,@DateOfBirth,@Gender) SET IDENTITY_INSERT Person OFF;", con2);
                    cmd3.Parameters.AddWithValue("@Id", id);
                    cmd3.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                    cmd3.Parameters.AddWithValue("@LastName", txtlastname.Text);
                    cmd3.Parameters.AddWithValue("@Contact", txtcontact.Text);
                    cmd3.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd3.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(txtdateofbirth.Text));
                    cmd3.Parameters.AddWithValue("@Gender", Gender);
                    cmd3.ExecuteNonQuery();
                    txtfirstname.Clear();
                    txtlastname.Clear();
                    txtemail.Clear();
                    txtcontact.Clear();
                    txtemail.Clear();
                    txtdateofbirth.Clear();
                    var con3 = dataconnection.getInstance().getConnection();
                    SqlCommand cmd4 = new SqlCommand("Insert into   Student(Id,RegistrationNo) values (@IdT,@RegistrationNo);", con3);
                    cmd4.Parameters.AddWithValue("@IdT", id);
                    cmd4.Parameters.AddWithValue("@RegistrationNo", txtregistrationno.Text);
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered");
                    id = 0;
                    Gender = 0;
                    txtregistrationno.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Please Enter the Correct information");
            }
            

        }
    }
}
