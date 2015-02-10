using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Accounts
{
    public abstract class AbstractRegisteredUser : SystemUser
    {
        abstract public bool Login(String username, String password);
    }
}
