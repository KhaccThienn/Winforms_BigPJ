using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BigPJV2.Data
{
    public class DatabaseContext
    {
        public static string ConnectionString { 
            get
            {
                return ConfigurationManager.ConnectionStrings["strcon"].ConnectionString;
            }
        }

        public static SqlConnection Connection
        {
            get
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                if (!conn.State.Equals(ConnectionState.Open))
                {
                    conn.Open();
                }

                return conn;
            }
        }
    }
}
