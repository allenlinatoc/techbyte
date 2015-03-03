using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Configs
{
    public class Privileges
    {
        const int PRIVILEGE_KEY = 0;
        const int PRIVILEGE_NAME = 1;

        static private string[][] privileges = new string[][] {
            new string[] { "ADMIN", "Admin" },
            new string[] { "MANAGER", "Manager" },
            new string[] { "HUMANRESOURCE", "Human Resource" },
            new string[] { "ACCOUNTING", "Accounting" },
            new string[] { "SALES", "Sales" },
            new string[] { "CLERK", "Clerk" }
        };


        /// <summary>
        /// Get the key of a privilege, otherwise, NULL if name doesn't exist
        /// </summary>
        /// <param name="privilegeName">The name of the privilege being requested</param>
        /// <returns>The name of the requested privilege</returns>
        static public string GetKey(String privilegeName) {
            for (int i = 0; i < privileges.Length; i++) {
                string[] row = privileges[i];
                if (row[PRIVILEGE_NAME].ToLower() == privilegeName.ToLower()) {
                    return row[PRIVILEGE_KEY];
                }
            }
            return null;
        }

        /// <summary>
        /// Get the name of a privilege, otherwise, NULL if key doesn't exist
        /// </summary>
        /// <param name="privilegeKey">The key of the privilege being requested</param>
        /// <returns>The name of the requested privilege</returns>
        static public string GetName(String privilegeKey) {
            for (int i=0; i<privileges.Length; i++) {
                string[] row = privileges[i];
                if (row[PRIVILEGE_KEY] == privilegeKey.ToUpper()) {
                    return row[PRIVILEGE_NAME];
                }
            }
            return null;
        }
        
    }
}
