using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Architecture.Common
{
    interface IRegisteredUser
    {
        void Login(String username, String password);
    }
}
