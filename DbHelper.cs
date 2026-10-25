using System;
using System.Data;
using System.Data.SqlClient;

namespace UniEventApp
{
    public class DbHelper
    {
        // Connection string configured for your working LocalDB instance
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=UniEventDB;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=3;ConnectRetryInterval=10;";

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        // Helper to run SELECT queries with optional parameters (Fulfils NFR03)
        public DataTable ReadData(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        // Helper to run INSERT, UPDATE, DELETE queries with optional parameters (Fulfils NFR03)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}