using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SimpleBudgeting
{
    class SQLConnectionClass
    {
        public void ConnectionUsed()
        {
            string connectionString;
            SqlConnection connection;
            connectionString = @"Data Source=TEST-MACHINE-RI;Initial Catalog=simpleBudgetDB;";
            connection = new SqlConnection(connectionString);
            connection.Open();

        }
    }
}
