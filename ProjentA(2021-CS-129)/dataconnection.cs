using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjentA_2021_CS_139_
{
    class dataconnection
    {
        String ConnectionStr = @"Data Source=(local);Initial Catalog=ProjectA      ;Integrated Security=True";
        SqlConnection con;
        private static dataconnection _instance;
        public static dataconnection getInstance()
        {
            if (_instance == null)
                _instance = new dataconnection();
            return _instance;
        }
        private dataconnection()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
