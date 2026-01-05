using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace ServiceCenter.core.util
{
    internal class PasswordHelper
    {
        public static string Hash(string plain) => BCrypt.Net.BCrypt.HashPassword(plain);
        public static bool Verify(string plain, string hashed) => BCrypt.Net.BCrypt.Verify(plain, hashed);
    }
}
