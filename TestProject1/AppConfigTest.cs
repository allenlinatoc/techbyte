using TechByte.Configs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for AppConfigTest and is intended
    ///to contain all AppConfigTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AppConfigTest
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
        ///A test for AppConfig Constructor
        ///</summary>
        [TestMethod()]
        public void AppConfigConstructorTest() {
            AppConfig target = new AppConfig();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest() {
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = AppConfig.Initialize();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reinitialize
        ///</summary>
        [TestMethod()]
        public void ReinitializeTest() {
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = AppConfig.Reinitialize();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reset
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void ResetTest() {
            AppConfig_Accessor.Reset();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
