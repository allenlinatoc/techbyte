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
        void Fetch(); // method for FormModalTypes.Update when fetching data from database
        void SetFormModalKey(object key); // when you want to set Update key
        void SetFormModalType(FormModalTypes type); // when you want to set the FormModalType
        void InitFormModal(); // when initializing FormModal
    }
}
