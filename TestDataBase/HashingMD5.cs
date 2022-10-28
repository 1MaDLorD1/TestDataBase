using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TestDataBase
{
    class HashingMD5
    {
        public static string HashPassword(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] bytes = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(bytes);

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in hash)
                stringBuilder.Append(item.ToString("X2"));

            return stringBuilder.ToString();
        }
    }
}
