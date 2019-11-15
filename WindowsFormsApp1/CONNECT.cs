using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class CONNECT
    {
        private SqlConnection connection = new SqlConnection("Data Source=KIRITOPC;Initial Catalog=Hotel;Integrated Security=True"); 

        public SqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
