using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Guitar32.Validations.Monitors
{
    public class InputMonitorCollection : List<InputMonitor>
    {

        /// <summary>
        /// Initialize an instance of InputMonitorCollection
        /// </summary>
        public InputMonitorCollection() : base() { }


        /// <summary>
        /// Check if every InputMonitor in this collection is ready for user-defined submission
        /// </summary>
        /// <returns>If this input monitor collection is submittable or not</returns>
        public bool IsSubmittable() {
            foreach (InputMonitor monitor in this) {
                if (!monitor.Validate()) {
                    return false;
                }
            }
            return true;
        }
    }
}
