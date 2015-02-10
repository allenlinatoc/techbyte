using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Models.Architecture.Accounts
{
    public abstract class AbstractNewUser
    {
        abstract public bool Register(SystemUser systemUser);
    }
}