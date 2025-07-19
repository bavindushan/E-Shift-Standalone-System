using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using eShiftApp.Models;
using eShiftApp.Utils;

namespace eShiftApp.Controllers
{
    public class TransportUnitController
    {
        // Add new transport unit
        public int AddTransportUnit(TransportUnit unit)
        {
            string query = "INSERT INTO TransportUnit (lorry_number, driver_name, assistant_name, container_capacity, is_booked) " +
                           "VALUES (@LorryNumber, @DriverName, @AssistantName, @ContainerCapacity, 0)"; // is_booked default to false

            SqlParameter[] parameters = {
                new SqlParameter("@LorryNumber", unit.LorryNumber),
                new SqlParameter("@DriverName", unit.DriverName),
                new SqlParameter("@AssistantName", unit.AssistantName),
                new SqlParameter("@ContainerCapacity", unit.ContainerCapacity)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Update by unit_id
        public int UpdateTransportUnit(TransportUnit unit)
        {
            string query = @"
                UPDATE TransportUnit 
                SET 
                    lorry_number = @LorryNumber, 
                    driver_name = @DriverName, 
                    assistant_name = @AssistantName, 
                    container_capacity = @ContainerCapacity
                WHERE unit_id = @UnitId";

                    SqlParameter[] parameters = {
                new SqlParameter("@LorryNumber", unit.LorryNumber),
                new SqlParameter("@DriverName", unit.DriverName),
                new SqlParameter("@AssistantName", unit.AssistantName),
                new SqlParameter("@ContainerCapacity", unit.ContainerCapacity),
                new SqlParameter("@UnitId", unit.UnitId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        public int DeleteTransportUnit(int unitId)
        {
            string query = "DELETE FROM TransportUnit WHERE unit_id = @UnitId";

            SqlParameter[] parameters = {
                new SqlParameter("@UnitId", unitId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }


        // Get all transport units
        public List<TransportUnit> GetAllUnits()
        {
            string query = "SELECT * FROM TransportUnit";
            DataTable dt = DBHelper.ExecuteSelect(query);
            return ParseTransportUnitList(dt);
        }

        // Get available (not booked) transport units
        public List<TransportUnit> GetAvailableUnits()
        {
            string query = "SELECT * FROM TransportUnit WHERE is_booked = 0";
            DataTable dt = DBHelper.ExecuteSelect(query);
            return ParseTransportUnitList(dt);
        }

        // Update booking status (true = booked, false = available)
        public int UpdateBookingStatus(int unitId, bool isBooked)
        {
            string query = "UPDATE TransportUnit SET is_booked = @IsBooked WHERE unit_id = @UnitId";
            SqlParameter[] parameters = {
                new SqlParameter("@IsBooked", isBooked),
                new SqlParameter("@UnitId", unitId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        public bool IsTransportUnitFree(int unitId)
        {
            string query = "SELECT COUNT(*) FROM Job WHERE unit_id = @UnitId AND job_status NOT IN ('Completed', 'Cancelled')";

            SqlParameter[] parameters = {
                new SqlParameter("@UnitId", unitId)
            };

            object result = DBHelper.ExecuteScalar(query, parameters);
            int count = result != null ? Convert.ToInt32(result) : 0;

            return count == 0; // Free if no active jobs
        }


        //  Convert DataTable to List<TransportUnit>
        private List<TransportUnit> ParseTransportUnitList(DataTable dt)
        {
            List<TransportUnit> units = new List<TransportUnit>();

            foreach (DataRow row in dt.Rows)
            {
                units.Add(new TransportUnit
                {
                    UnitId = (int)row["unit_id"],
                    LorryNumber = row["lorry_number"].ToString(),
                    DriverName = row["driver_name"].ToString(),
                    AssistantName = row["assistant_name"].ToString(),
                    ContainerCapacity = Convert.ToSingle(row["container_capacity"]),
                    IsBooked = Convert.ToBoolean(row["is_booked"])
                });
            }

            return units;
        }
    }
}
