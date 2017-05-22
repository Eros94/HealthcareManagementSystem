using System;
using System.Security.Cryptography;
using System.Text;

namespace HealthcareManagementSystem.Utilities
{
    internal class PasswordUtilities
    {
        public static string ComputeHash(string input, HashAlgorithm algorithm)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);
        }
    }
}