using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseAccess
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private string StrCon = null;
        private string error;
        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        public SqlConnection Connection
        {
            get { return conn; }
        }
        public SqlCommand CMD
        {
            get { return cmd; }
            set { cmd = value; }
        }
        public DatabaseAccess()
        {
            
            conn = new SqlConnection(globalParameter.connectionString);
        }

        public bool OpenConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }
    }
}
