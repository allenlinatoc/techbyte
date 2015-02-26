using Guitar32.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DiagnosticsTest and is intended
    ///to contain all DiagnosticsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DiagnosticsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext {
            get {
                return testContextInstance;
            }
            set {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Diagnostics Constructor
        ///</summary>
        [TestMethod()]
        public void DiagnosticsConstructorTest() {
            string appname = string.Empty; // TODO: Initialize to an appropriate value
            Diagnostics target = new Diagnostics(appname);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for LogEntry
        ///</summary>
        [TestMethod()]
        public void LogEntryTest() {
            string appname = string.Empty; // TODO: Initialize to an appropriate value
            Diagnostics target = new Diagnostics(appname); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            EventLogEntryType type = new EventLogEntryType(); // TODO: Initialize to an appropriate value
            int eventId = 0; // TODO: Initialize to an appropriate value
            target.LogEntry(message, type, eventId);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
