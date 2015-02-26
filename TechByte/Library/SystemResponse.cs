using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guitar32
{
    /// <summary>
    /// A response object from a Model or Module
    /// </summary>
    public class SystemResponse
    {
        private string code;
        private string message;
        private object data;


        /// <summary>
        /// Instantiate a response object
        /// </summary>
        /// <param name="code">The response code</param>
        /// <param name="message">The response message</param>
        public SystemResponse(string code, string message) {
            this.code = code;
            this.message = message;
        }

        /// <summary>
        /// Instantiate a response object
        /// </summary>
        /// <param name="code">The response code</param>
        /// <param name="message">The response message</param>
        /// <param name="data">The response data</param>
        public SystemResponse(string code, string message, object data) {
            this.code = code;
            this.message = message;
            this.data = data;
        }

        /// <summary>
        /// Get the code of this response
        /// </summary>
        /// <returns>The response code</returns>
        public string GetCode() {
            return this.code;
        }

        /// <summary>
        /// Get the message of this response
        /// </summary>
        /// <returns>The response message</returns>
        public string GetMessage() {
            return this.message;
        }

        /// <summary>
        /// Get the data in this response
        /// </summary>
        /// <returns>The data in this response</returns>
        public object GetData() {
            return this.data;
        }


        // <Begin::Common system response>
        public static SystemResponse Success = new SystemResponse("00", "Success!");
        public static SystemResponse Busy = new SystemResponse("99", "System is busy!");
        // <End::Common system response>



    }
}
