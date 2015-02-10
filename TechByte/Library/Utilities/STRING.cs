using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Library.Utilities
{
    class STRING
    {
        /// <summary>
        /// Trims a character mask from right, space on default
        /// </summary>
        /// <param name="str">The string to be trimmed</param>
        /// <param name="chmask">The character to be masked for</param>
        /// <returns>The trimmed string</returns>
        public static String rightTrim(String str, Char chmask=' ')
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
    }
}
