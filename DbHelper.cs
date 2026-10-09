using System;
using System.Data;
using System.Data.SqlClient;

namespace UniEventApp
{
    public class DbHelper
    {
        // Connection string configured for your working LocalDB instance
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=UniEventDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // Helper to run SELECT queries (returns a table of data)
        public DataTable ReadData(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Helper to run INSERT, UPDATE, DELETE queries
        public int ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}