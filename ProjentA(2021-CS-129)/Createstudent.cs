using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjentA_2021_CS_139_
{
    public partial class Createstudent : Form
    {
        public Createstudent()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenternewstudent_Click(object sender, EventArgs e)
        {
            insertstudent var1 = new insertstudent();
            var1.ShowDialog();
        }

        private void btndeletestudent_Click(object sender, EventArgs e)
        {
            DeleteStudent var1 = new DeleteStudent();
            var1.ShowDialog();
        }

        private void btnupdatestudent_Click(object sender, EventArgs e)
        {
            updatestudent var1 = new updatestudent();
            var1.ShowDialog();
        }
    }
}
