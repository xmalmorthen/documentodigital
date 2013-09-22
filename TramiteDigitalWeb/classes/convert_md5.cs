using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace scanndoc.classes
{
    static class convert_md5
    {
        public static string generate(string input)
        {
            try
            {
                // Create a new instance of the MD5CryptoServiceProvider object.
                MD5 md5Hasher = MD5.Create();

                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static bool verifyMd5Hash(string input, string hash)
        {
            try
            {
                // Hash the input.
                string hashOfInput = convert_md5.generate(input);

                // Create a StringComparer an comare the hashes.
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                if (0 == comparer.Compare(hashOfInput, hash))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
