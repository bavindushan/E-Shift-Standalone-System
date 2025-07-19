using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eShiftApp.Utils
{
    public static class PhoneAndEmailValidator
    {
        // Email pattern
        private static readonly string EmailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        // Phone pattern: 10–15 digits with optional +
        private static readonly string PhonePattern = @"^\+?\d{10,15}$";

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(email, EmailPattern);
        }

        public static bool IsValidPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            return Regex.IsMatch(phone, PhonePattern);
        }
    }
}
