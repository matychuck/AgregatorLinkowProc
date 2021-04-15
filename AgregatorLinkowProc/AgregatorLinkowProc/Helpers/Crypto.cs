using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregatorLinkowProc.Helpers
{
    public static class Crypto
    {
        //Haszowanie podanego hasła
        public static string HashPassword(string value)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(value))
                );
        }

        //Sprawdzenie zgodności podanych haseł
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
