﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32.Common
{
    interface IStringDatatype
    {
        int getMaxLength();
        int getMinLength();
        bool isWithinRange();
    }
}