using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte
{
    /// <summary>
    /// Manages all forms in the system
    /// </summary>
    class FormManager
    {
        public static Dashboard frmDashboard;


        public static void Initialize()
        {
            frmDashboard = new Dashboard();
        }


    }
}
