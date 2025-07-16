using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using eShiftApp.Models;
using eShiftApp.Utils;

namespace eShiftApp.Controllers
{
    public class LoadController
    {
        // Add load to a job
        public int AddLoad(Load load)
        {
            string query = "INSERT INTO Load (job_id, product_id, weight, volume) " +
                           "VALUES (@JobId, @ProductId, @Weight, @Volume)";

            SqlParameter[] parameters = {
                new SqlParameter("@JobId", load.JobId),
                new SqlParameter("@ProductId", load.ProductId),
                new SqlParameter("@Weight", load.Weight),
                new SqlParameter("@Volume", load.Volume)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Get all loads for a specific job
        public List<Load> GetLoadsByJobId(int jobId)
        {
            string query = "SELECT * FROM Load WHERE job_id = @JobId";
            SqlParameter[] parameters = {
                new SqlParameter("@JobId", jobId)
            };

            DataTable dt = DBHelper.ExecuteSelect(query, parameters);
            List<Load> loads = new List<Load>();

            foreach (DataRow row in dt.Rows)
            {
                loads.Add(new Load
                {
                    LoadId = (int)row["load_id"],
                    JobId = (int)row["job_id"],
                    ProductId = (int)row["product_id"],
                    Weight = Convert.ToSingle(row["weight"]),
                    Volume = Convert.ToSingle(row["volume"])
                });
            }

            return loads;
        }

        // Optional: Delete a load
        public int DeleteLoad(int loadId)
        {
            string query = "DELETE FROM Load WHERE load_id = @LoadId";
            SqlParameter[] parameters = {
                new SqlParameter("@LoadId", loadId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Optional: Update load details
        public int UpdateLoad(Load load)
        {
            string query = "UPDATE Load SET product_id = @ProductId, weight = @Weight, volume = @Volume " +
                           "WHERE load_id = @LoadId";

            SqlParameter[] parameters = {
                new SqlParameter("@ProductId", load.ProductId),
                new SqlParameter("@Weight", load.Weight),
                new SqlParameter("@Volume", load.Volume),
                new SqlParameter("@LoadId", load.LoadId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }
    }
}
