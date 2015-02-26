using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32.Exceptions
{
    class OutOfRangeValueException : Exception
    {
        public OutOfRangeValueException() : base("Numeric value is not within the valid value range")
        { }
    }
}
