using Guitar32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ModelTest and is intended
    ///to contain all ModelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ModelTest
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


        internal virtual Model CreateModel() {
            // TODO: Instantiate an appropriate concrete class.
            Model target = null;
            return target;
        }

        /// <summary>
        ///A test for getId
        ///</summary>
        [TestMethod()]
        public void getIdTest() {
            Model target = CreateModel(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getId();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getResponse
        ///</summary>
        [TestMethod()]
        public void getResponseTest() {
            Model target = CreateModel(); // TODO: Initialize to an appropriate value
            SystemResponse expected = null; // TODO: Initialize to an appropriate value
            SystemResponse actual;
            actual = target.getResponse();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setId
        ///</summary>
        [TestMethod()]
        public void setIdTest() {
            Model target = CreateModel(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            target.setId(id);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setResponse
        ///</summary>
        [TestMethod()]
        public void setResponseTest() {
            Model target = CreateModel(); // TODO: Initialize to an appropriate value
            SystemResponse response = null; // TODO: Initialize to an appropriate value
            target.setResponse(response);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
