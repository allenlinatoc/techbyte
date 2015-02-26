using Guitar32.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for IMonitorableTest and is intended
    ///to contain all IMonitorableTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IMonitorableTest
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


        internal virtual IMonitorable CreateIMonitorable() {
            // TODO: Instantiate an appropriate concrete class.
            IMonitorable target = null;
            return target;
        }

        /// <summary>
        ///A test for InitializeMonitors
        ///</summary>
        [TestMethod()]
        public void InitializeMonitorsTest() {
            IMonitorable target = CreateIMonitorable(); // TODO: Initialize to an appropriate value
            target.InitializeMonitors();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
