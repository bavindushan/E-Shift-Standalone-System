using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace eShiftApp.Utils
{
    public static class DBHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["eShiftConnection"].ConnectionString;

        // Open connection
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Execute SELECT query and return DataTable (no parameters)
        public static DataTable ExecuteSelect(string query)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Execute SELECT query and return DataTable (with parameters)
        public static DataTable ExecuteSelect(string query, SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Execute INSERT/UPDATE/DELETE (no parameters)
        public static int ExecuteQuery(string query)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                return cmd.ExecuteNonQuery();
            }
        }

        // Execute INSERT/UPDATE/DELETE (with parameters)
        public static int ExecuteQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        // Optional: Execute scalar query (e.g., SELECT COUNT(*))
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }
    }
}
