using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Accounts
{
    interface IRegisteredUser
    {
        bool Login(String username, String password);
    }
}
