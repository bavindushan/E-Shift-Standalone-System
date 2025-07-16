using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using eShiftApp.Models;
using eShiftApp.Utils;

namespace eShiftApp.Controllers
{
    public class TransportJobController
    {
        // Add a new job by a customer
        public int AddJob(TransportJob job)
        {
            string query = "INSERT INTO TransportJob (customer_id, pickup_location, delivery_location, status, request_date) " +
                           "VALUES (@CustomerId, @PickupLocation, @DeliveryLocation, @Status, @RequestDate)";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", job.CustomerId),
                new SqlParameter("@PickupLocation", job.PickupLocation),
                new SqlParameter("@DeliveryLocation", job.DeliveryLocation),
                new SqlParameter("@Status", "Pending"),
                new SqlParameter("@RequestDate", job.RequestDate)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Get jobs by customer ID
        public List<TransportJob> GetJobsByCustomerId(int customerId)
        {
            string query = "SELECT * FROM TransportJob WHERE customer_id = @CustomerId";
            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

            DataTable dt = DBHelper.ExecuteSelect(query, parameters);
            return ParseJobList(dt);
        }

        // Admin: Get all jobs
        public List<TransportJob> GetAllJobs()
        {
            string query = "SELECT * FROM TransportJob";
            DataTable dt = DBHelper.ExecuteSelect(query);
            return ParseJobList(dt);
        }

        // Admin: Update job status (Approve/Decline)
        public int UpdateJobStatus(int jobId, string status, DateTime? approvalDate)
        {
            string query = "UPDATE TransportJob SET status = @Status, approval_date = @ApprovalDate WHERE job_id = @JobId";

            SqlParameter[] parameters = {
                new SqlParameter("@Status", status),
                new SqlParameter("@ApprovalDate", approvalDate.HasValue ? (object)approvalDate.Value : DBNull.Value),
                new SqlParameter("@JobId", jobId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Admin: Assign transport unit to a job
        public int AssignUnitToJob(int jobId, int unitId)
        {
            string query = "UPDATE TransportJob SET unit_id = @UnitId WHERE job_id = @JobId";

            SqlParameter[] parameters = {
                new SqlParameter("@UnitId", unitId),
                new SqlParameter("@JobId", jobId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Helper: Convert DataTable to List<TransportJob> // use this method as ORM
        private List<TransportJob> ParseJobList(DataTable dt)
        {
            List<TransportJob> jobs = new List<TransportJob>();

            foreach (DataRow row in dt.Rows)
            {
                jobs.Add(new TransportJob
                {
                    JobId = (int)row["job_id"],
                    CustomerId = (int)row["customer_id"],
                    PickupLocation = row["pickup_location"].ToString(),
                    DeliveryLocation = row["delivery_location"].ToString(),
                    Status = row["status"].ToString(),
                    RequestDate = Convert.ToDateTime(row["request_date"]),
                    ApprovalDate = row["approval_date"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["approval_date"]),
                    UnitId = row["unit_id"] != DBNull.Value ? Convert.ToInt32(row["unit_id"]) : 0
                });
            }

            return jobs;
        }
    }
}
