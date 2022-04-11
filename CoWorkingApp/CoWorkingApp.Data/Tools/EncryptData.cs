using System.Text;
using System.Security.Cryptography;
using System;
namespace CoWorkingApp.Data.Tools
{
    public static class EncryptData
    {
        public static string EncryptText(string text)
        {
           using(var sha256 = SHA256.Create())
           {
               var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(text));
               var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
               return hash;
           }
        }
    }
}