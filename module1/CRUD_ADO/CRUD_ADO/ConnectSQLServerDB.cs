using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ADO
{
    internal static class ConnectSQLServerDB
    {
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = null;
            string connectionString = "Data Source=DESKTOP-1F4TT5V\\SQLEXPRESS;Initial Catalog=ss01;User ID=sa;Password=123456789";
            conn = new SqlConnection(connectionString);
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

    }
}
