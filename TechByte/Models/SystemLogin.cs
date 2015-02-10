using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models
{
    /// <summary>
    /// Utility Model for System logins
    /// </summary>
    class SystemLogin : Architecture.Accounts.IRegisteredUser
    {
        private static String username = "admin";
        private static String password = "12345";

        public SystemLogin() {

        }

        public Boolean Login(String username, String password) {
            return username.Equals(SystemLogin.username) && password.Equals(SystemLogin.password);
        }
    }
}
