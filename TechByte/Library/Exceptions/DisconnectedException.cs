using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Guitar32.Exceptions
{
    public sealed class DisconnectedException : Exception
    {
        public DisconnectedException()
            : base("You are trying to execute through a disconnected database connection") { }
    }
}
