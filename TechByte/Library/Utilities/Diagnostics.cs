using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guitar32.Utilities
{

    /// <summary>
    /// Class for logging diagnostics and debugging log entries into Windows Event log
    /// </summary>
    public class Diagnostics
    {
        private string appname;

        /// <summary>
        /// Instantiate an instance of Windows event-based diagnostics
        /// </summary>
        public Diagnostics(String appname = null) {
            this.appname = (appname==null ? Application.ProductName : appname);
        }


        /// <summary>
        /// Write a log entry
        /// </summary>
        /// <param name="message">Log message to be written</param>
        /// <param name="type">(Optional) Log type</param>
        /// <param name="eventId">(Optional) Log event ID</param>
        public void LogEntry(string message, EventLogEntryType type = EventLogEntryType.Error, int eventId = 0) {
            EventLog.WriteEntry(this.appname, message, type, eventId);
        }

    }
}
