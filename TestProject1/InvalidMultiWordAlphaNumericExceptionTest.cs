using Guitar32.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for InvalidMultiWordAlphaNumericExceptionTest and is intended
    ///to contain all InvalidMultiWordAlphaNumericExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InvalidMultiWordAlphaNumericExceptionTest
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
        ///A test for InvalidMultiWordAlphaNumericException Constructor
        ///</summary>
        [TestMethod()]
        public void InvalidMultiWordAlphaNumericExceptionConstructorTest() {
            InvalidMultiWordAlphaNumericException target = new InvalidMultiWordAlphaNumericException();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
