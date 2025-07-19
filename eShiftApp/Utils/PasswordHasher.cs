using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BCrypt.Net;

namespace eShiftApp.Utils
{
    public static class PasswordHasher
    {
        // Hash the password
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Verify input against hashed password
        public static bool Verify(string inputPassword, string storedHash)
        {
            //Console.WriteLine("Input :"+ inputPassword +""+"Store :"+ storedHash);
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedHash);
        }
    }
}
