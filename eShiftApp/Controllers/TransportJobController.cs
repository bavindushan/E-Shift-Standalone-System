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
        private TransportUnitController _unitController = new TransportUnitController();

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

        // Get Last Inserted Job ID
        public int GetLastInsertedJobId()
        {
            string query = "SELECT TOP 1 job_id FROM TransportJob ORDER BY job_id DESC";

            DataTable dt = DBHelper.ExecuteSelect(query);
            if (dt.Rows.Count == 1)
            {
                return Convert.ToInt32(dt.Rows[0]["job_id"]);
            }

            return -1;
        }

        // Admin: Get all jobs
        public List<TransportJob> GetAllJobs()
        {
            string query = "SELECT * FROM TransportJob";
            DataTable dt = DBHelper.ExecuteSelect(query);
            return ParseJobList(dt);
        }

        //Get all pendign jobs
        public List<TransportJob> GetPendingJobs()
        {
            string query = "SELECT * FROM TransportJob WHERE status = 'Pending'";
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

        // Mark job as Completed after the Job done and free the tranceport unit
        //public int MarkJobAsCompleted(int jobId)
        //{
        //    // Step 1: Get the assigned unit_id for this job
        //    string selectQuery = "SELECT unit_id FROM TransportJob WHERE job_id = @JobId";
        //    SqlParameter[] selectParams = {
        //        new SqlParameter("@JobId", jobId)
        //    };

        //    object unitIdObj = DBHelper.ExecuteScalar(selectQuery, selectParams);

        //    if (unitIdObj == null || unitIdObj == DBNull.Value)
        //    {
        //        // No unit assigned or job not found
        //        return 0;
        //    }

        //    int unitId = Convert.ToInt32(unitIdObj);

        //    //  Update job status to Completed
        //    string updateJobQuery = "UPDATE TransportJob SET status = 'Completed' WHERE job_id = @JobId";
        //    int jobUpdateResult = DBHelper.ExecuteQuery(updateJobQuery, selectParams);

        //    //  Set is_booked = false for the transport unit
        //    string updateUnitQuery = "UPDATE TransportUnit SET is_booked = 0 WHERE unit_id = @UnitId";
        //    SqlParameter[] unitParams = {
        //        new SqlParameter("@UnitId", unitId)
        //    };
        //    int unitUpdateResult = DBHelper.ExecuteQuery(updateUnitQuery, unitParams);

        //    // Return combined result (optional)
        //    return jobUpdateResult + unitUpdateResult;
        //}

        // Count of jobs by status (Pending / Approved / Declined)
        public int GetJobCountByStatus(int customerId, string status)
        {
            string query = "SELECT COUNT(*) FROM TransportJob WHERE customer_id = @CustomerId AND status = @Status";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId),
                new SqlParameter("@Status", status)
            };

            object result = DBHelper.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        // Count all jobs by customer
        public int GetTotalJobCount(int customerId)
        {
            string query = "SELECT COUNT(*) FROM TransportJob WHERE customer_id = @CustomerId";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

            object result = DBHelper.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        //  Count jobs with status = Completed (if used in DB)
        public int GetCompletedJobCount(int customerId)
        {
            string query = "SELECT COUNT(*) FROM TransportJob WHERE customer_id = @CustomerId AND status = 'Completed'";

            SqlParameter[] parameters = {
                new SqlParameter("@CustomerId", customerId)
            };

            object result = DBHelper.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result);
        }

        // Get job by job ID
        public DataTable GetJobById(int jobId)
        {

            Console.WriteLine("Job ID in controller stage" + jobId);
            string query = "SELECT * FROM TransportJob WHERE job_id = @JobId";

            SqlParameter[] parameters = {
                new SqlParameter("@JobId", jobId)
            };

            return DBHelper.ExecuteSelect(query, parameters);
        }

        public bool MarkJobAsCompleted(int jobId)
        {
            //  Get the transport unit ID related to the job
            string getUnitQuery = "SELECT unit_id FROM TransportJob WHERE job_id = @JobId";

            SqlParameter[] getParams = {
                new SqlParameter("@JobId", jobId)
            };

            DataTable result = DBHelper.ExecuteSelect(getUnitQuery, getParams);

            if (result.Rows.Count == 0)
                throw new Exception("Job not found.");

            int unitId = Convert.ToInt32(result.Rows[0]["unit_id"]);

            //  Mark job as Completed
            string updateJobQuery = "UPDATE TransportJob SET status = 'Completed' WHERE job_id = @JobId";

            SqlParameter[] updateParams = {
                new SqlParameter("@JobId", jobId)
            };

            int affectedRows = DBHelper.ExecuteQuery(updateJobQuery, updateParams);

            if (affectedRows > 0)
            {
                // Free the related transport unit
                _unitController.UpdateBookingStatus(unitId, false);
                return true; 
            }

            return false;
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
