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
        string connectionString;
        SqlConnection connection;
        public void OpenConnection()
        {
            
            connectionString = @"Data Source=TEST-MACHINE-RI;Initial Catalog=simpleBudgetDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void ExecuteQueries(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, connection);
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader DataReader(string Query_)
        {
            SqlCommand cmd = new SqlCommand(Query_, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, connectionString);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }
    }
}
