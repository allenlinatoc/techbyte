using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TechByte.Library
{
    public class Session
    {
        private static Dictionary<String, object> values;


        /// <summary>
        /// Initialize this session
        /// </summary>
        public static void Initialize() {
            values = new Dictionary<string, object>();
        }


        /// <summary>
        /// Get a value from session. Returns <code>null</code> if session does not exist.
        /// </summary>
        /// <param name="sessionKey">The session key to look up</param>
        /// <returns>The corresponding session value for the specified key, otherwise, null</returns>
        public static object Get(String sessionKey) {
            if (values == null) {
                throw new SessionUninitializedException();
            }
            if (!values.ContainsKey(sessionKey)) {
                return null;
            }
            return values[sessionKey];
        }


        /// <summary>
        /// Remove a session
        /// </summary>
        /// <param name="sessionKey">The key of the session to be removed</param>
        public static void Remove(String sessionKey) {
            if (values == null) {
                throw new SessionUninitializedException();
            }
            if (values.ContainsKey(sessionKey)) {
                values.Remove(sessionKey);
            }
        }


        /// <summary>
        /// Set a session
        /// </summary>
        /// <param name="sessionKey">The session key</param>
        /// <param name="sessionValue">The corresponding session value</param>
        public static void Set(String sessionKey, object sessionValue) {
            if (values == null) {
                throw new SessionUninitializedException();
            }
            if (values.ContainsKey(sessionKey)) {
                values[sessionKey] = sessionValue;
            }
            else {
                values.Add(sessionKey, sessionValue);
            }
        }

    }


    /// <summary>
    /// Exception thrown when session is used without being initialized
    /// </summary>
    public class SessionUninitializedException : Exception
    {
        public SessionUninitializedException() 
            : base("Session should be initialized first") { }
    }
}
