using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using eShiftApp.Models;
using eShiftApp.Utils;

namespace eShiftApp.Controllers
{
    public class AdminController
    {
        // Admin login with password hash check
        public Admin Login(string username, string password)
        {
            string query = "SELECT * FROM Admin WHERE username = @Username";
            SqlParameter[] parameters = {
                new SqlParameter("@Username", username)
            };

            DataTable dt = DBHelper.ExecuteSelect(query, parameters);

            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                string storedHash = row["password"].ToString();

                Console.WriteLine("Admin Hashed password :"+storedHash);
                Console.WriteLine("Admin password :" + password);

                if (PasswordHasher.Verify(password, storedHash))
                {
                    return new Admin
                    {
                        AdminId = (int)row["admin_id"],
                        Username = row["username"].ToString(),
                        Password = storedHash,
                        Email = row["email"].ToString()
                    };
                }
            }

            return null; // Login failed
        }

        // Add new admin
        public int AddAdmin(Admin admin)
        {
            string hashedPassword = PasswordHasher.Hash(admin.Password);

            string query = "INSERT INTO Admin (username, password, email) " +
                           "VALUES (@Username, @Password, @Email)";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", admin.Username),
                new SqlParameter("@Password", hashedPassword),
                new SqlParameter("@Email", admin.Email)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Get all admins (useful for listing or report generation)
        public List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();
            string query = "SELECT * FROM Admin";

            DataTable dt = DBHelper.ExecuteSelect(query);

            foreach (DataRow row in dt.Rows)
            {
                admins.Add(new Admin
                {
                    AdminId = (int)row["admin_id"],
                    Username = row["username"].ToString(),
                    Password = row["password"].ToString(),
                    Email = row["email"].ToString()
                });
            }

            return admins;
        }

        // Update admin email or password
        public int UpdateAdmin(Admin admin)
        {
            string query = "UPDATE Admin SET email = @Email WHERE admin_id = @AdminId";

            SqlParameter[] parameters = {
                new SqlParameter("@Email", admin.Email),
                new SqlParameter("@AdminId", admin.AdminId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Update admin username or password
        public int UpdateAdminUserNameOrPass(Admin admin)
        {
            string query = "UPDATE Admin SET username = @Username WHERE admin_id = @AdminId";

            SqlParameter[] parameters = {
                new SqlParameter("@Username", admin.Username),
                new SqlParameter("@AdminId", admin.AdminId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }
    }
}
