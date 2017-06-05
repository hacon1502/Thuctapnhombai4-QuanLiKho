using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DatabaseAccess2
    {
        public SqlConnection conn = null;
        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(globalParameter.connectionString);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }


    }
}
