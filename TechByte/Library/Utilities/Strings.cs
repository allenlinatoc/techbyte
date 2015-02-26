using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32.Utilities
{
    class Strings
    {

        /// <summary>
        /// Format an integer value with padded number of zeroes, depending on digit count
        /// </summary>
        /// <param name="number">The integer value to be formatted</param>
        /// <param name="digitCount">The number of digits count</param>
        /// <returns>The formatted integer value in string</returns>
        public static String FormatInt(int number, int digitCount) {
            string result = "";
            int rem = digitCount - number.ToString().Length;
            for (int i = 0; i < rem; i++) {
                result += "0";
            }
            return result + number.ToString();
        }



        /// <summary>
        /// Get the first-letter-only lowercase format of a string
        /// </summary>
        /// <param name="str">The string</param>
        /// <returns>The first-letter-only lowercase</returns>
        public static String LowercaseFirst(string str) {
            return Char.ToUpper(str[0]) + str.Substring(1, str.Length - 1).ToLower();
        }



        /// <summary>
        /// Check if a string is surrounded by certain character
        /// </summary>
        /// <param name="str">The string to be tested</param>
        /// <param name="fence">(Optional) The fence to be determined</param>
        /// <returns>If this string is surrounded by a fence or not</returns>
        public static bool IsSurrounded(String str, Char fence = '"') {
            return str.Length > 2 ? (str[0]==fence && str[str.Length-1]==fence) : false;
        }



        /// <summary>
        /// Reverse a string
        /// </summary>
        /// <param name="str">The string to be reversed</param>
        /// <returns>The reversed string</returns>
        public static String Reverse(String str) {
            StringBuilder builder = new StringBuilder();
            for (int i = str.Length; i > 0; i--) {
                builder.Append(str[i-1]);
            }
            return builder.ToString();
        }



        /// <summary>
        /// Trims a character mask from right, space on default
        /// </summary>
        /// <param name="str">The string to be trimmed</param>
        /// <param name="chmask">The character to be masked for</param>
        /// <returns>The trimmed string</returns>
        public static String RightTrim(String str, Char chmask = ' ')
        {
            String ret = "";
            int endpoint = 0;
            for (int i=str.Length-1; i>=0; i--) {
                endpoint = i + 1;
                if (str[i] != chmask) {
                    break;
                }
            }
            ret = str.Substring(0, endpoint);
            return ret;
        }


        
        /// <summary>
        /// Surround a string with character fence
        /// </summary>
        /// <param name="str">The string to be surrounded</param>
        /// <param name="fence">The character fence</param>
        /// <returns>The surrounded string</returns>
        public static String Surround(String str, Char fence = '"') {
            String ret = str;
            if (!IsSurrounded(str, fence)) {
                ret = fence + ret + fence;
            }
            return ret;
        }



        /// <summary>
        /// Unsurround a string with character fence
        /// </summary>
        /// <param name="str">The string to be surrounded</param>
        /// <param name="fence">The character fence to be determined</param>
        /// <returns>The unsurrounded string</returns>
        public static String Unsurround(String str, Char fence = '"') {
            String ret = str;
            if (ret.Length > 2) {
                ret = ret.Substring(1, str.Length - 2);
            }
            return ret;
        }



        /// <summary>
        /// Get the first-letter-only uppercase form of a string
        /// </summary>
        /// <param name="str">The string</param>
        /// <returns>The first-letter-only formatted string</returns>
        public static String UppercaseFirst(String str) {
            return Char.ToUpper(str[0]) + str.Substring(1, str.Length - 1).ToLower();
        }


    }
}
