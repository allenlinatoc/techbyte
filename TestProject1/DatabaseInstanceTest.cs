using TechByte.Configs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Guitar32.Database;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DatabaseInstanceTest and is intended
    ///to contain all DatabaseInstanceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DatabaseInstanceTest
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
        ///A test for DatabaseInstance Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseInstanceConstructorTest() {
            DatabaseInstance target = new DatabaseInstance();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Get
        ///</summary>
        [TestMethod()]
        public void GetTest() {
            DatabaseInstance target = new DatabaseInstance(); // TODO: Initialize to an appropriate value
            DatabaseConnection expected = null; // TODO: Initialize to an appropriate value
            DatabaseConnection actual;
            actual = target.Get();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
