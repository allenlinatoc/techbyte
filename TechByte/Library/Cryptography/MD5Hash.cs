using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Guitar32.Cryptography
{
    public class MD5Hash
    {

        /// <summary>
        /// Compute the MD5 hash of a string
        /// </summary>
        /// <param name="input">The input string</param>
        /// <returns>The computed MD5 hash string</returns>
        public static string Compute(String input) {
            MD5 md5 = MD5.Create();
            byte[] buffer = md5.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < buffer.Length; i++) {
                stringBuilder.Append(buffer[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }



        /// <summary>
        /// Verify if an input string matches an MD5 hash
        /// </summary>
        /// <param name="input">The input string to be tested</param>
        /// <param name="md5hash">The MD5 hash to be matched with</param>
        /// <returns>If input matches the MD5 hash or not</returns>
        public static bool Verify(String input, String md5hash) {
            String hash = Compute(input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return (comparer.Compare(hash, md5hash) == 0);
        }

    }
}
