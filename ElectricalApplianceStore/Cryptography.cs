using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalApplianceStore
{
    public class Cryptography
    {
        public static string HashPassword(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(str));

            StringBuilder sb = new StringBuilder();
            foreach (byte item in hash)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
