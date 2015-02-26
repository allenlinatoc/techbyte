using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32.Exceptions
{
    public class BeanDataNotFoundException : Exception
    {

        public BeanDataNotFoundException() 
            : base("Data being requested from a Bean class was not found.")
        { }

    }
}
