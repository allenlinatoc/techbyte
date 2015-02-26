using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechByte.Architecture.Enums;

namespace TechByte.Architecture.Common
{
    /// <summary>
    /// Interface for implementing modal form modes (Create, Update, etc.)
    /// </summary>
    interface IFormModal
    {
        void setMode(FormModalTypes type);
        void initFormModal();
    }
}
