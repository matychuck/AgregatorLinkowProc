using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Helpers
{
    public static class Crypto
    {
        public static string HashPassword(string value)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(value))
                );
        }

        public static bool VerifyHashedPassword(string databasePassword, string modelPassword)
        {
            if (HashPassword(modelPassword) == databasePassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
