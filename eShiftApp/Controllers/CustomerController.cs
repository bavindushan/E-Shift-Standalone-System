using eShiftApp.Models;
using eShiftApp.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace eShiftApp.Controllers
{
    public class CustomerController
    {
        // Get all customers
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            string query = "SELECT * FROM Customer";

            DataTable dt = DBHelper.ExecuteSelect(query);
            foreach (DataRow row in dt.Rows)
            {
                customers.Add(new Customer
                {
                    CustomerId = (int)row["customer_id"],
                    Name = row["name"].ToString(),
                    Email = row["email"].ToString(),
                    Phone = row["phone"].ToString(),
                    Address = row["address"].ToString(),
                    Password = row["password"].ToString()
                });
            }

            return customers;
        }

        // Add a new customer with hashed password
        public int AddCustomer(Customer customer)
        {
            // Hash the password before storing
            string hashedPassword = PasswordHasher.Hash(customer.Password);

            string query = $"INSERT INTO Customer (name, email, phone, address, password) " +
                           $"VALUES (@Name, @Email, @Phone, @Address, @Password)";

            SqlParameter[] parameters = {
                new SqlParameter("@Name", customer.Name),
                new SqlParameter("@Email", customer.Email),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@Address", customer.Address),
                new SqlParameter("@Password", hashedPassword),
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Login validation with hashed password verification
        public Customer Login(string email, string password)
        {
            string query = "SELECT * FROM Customer WHERE email = @Email";
            SqlParameter[] parameters = {
                new SqlParameter("@Email", email)
            };

            DataTable dt = DBHelper.ExecuteSelect(query, parameters);

            if (dt.Rows.Count == 1)
            {
                var row = dt.Rows[0];
                string storedHash = row["password"].ToString();

                if (PasswordHasher.Verify(password, storedHash))
                {
                    return new Customer
                    {
                        CustomerId = (int)row["customer_id"],
                        Name = row["name"].ToString(),
                        Email = row["email"].ToString(),
                        Phone = row["phone"].ToString(),
                        Address = row["address"].ToString(),
                        Password = storedHash
                    };
                }
            }

            return null; // invalid login
        }

        // Update profile (does not change password here)
        public int UpdateCustomer(Customer customer)
        {
            string query = "UPDATE Customer SET name = @Name, phone = @Phone, address = @Address " +
                           "WHERE customer_id = @CustomerId";

            SqlParameter[] parameters = {
                new SqlParameter("@Name", customer.Name),
                new SqlParameter("@Phone", customer.Phone),
                new SqlParameter("@Address", customer.Address),
                new SqlParameter("@CustomerId", customer.CustomerId),
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }
    }
}
