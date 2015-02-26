using Guitar32.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for QueryResultTest and is intended
    ///to contain all QueryResultTest Unit Tests
    ///</summary>
    [TestClass()]
    public class QueryResultTest
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
        ///A test for QueryResult Constructor
        ///</summary>
        [TestMethod()]
        public void QueryResultConstructorTest() {
            Dictionary<string, object> data = null; // TODO: Initialize to an appropriate value
            QueryResult target = new QueryResult(data);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for QueryResult Constructor
        ///</summary>
        [TestMethod()]
        public void QueryResultConstructorTest1() {
            Dictionary<string, object>[] data = null; // TODO: Initialize to an appropriate value
            QueryResult target = new QueryResult(data);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetSingle
        ///</summary>
        [TestMethod()]
        public void GetSingleTest() {
            Dictionary<string, object>[] data = null; // TODO: Initialize to an appropriate value
            QueryResult target = new QueryResult(data); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            Dictionary<string, object> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, object> actual;
            actual = target.GetSingle(index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        [TestMethod()]
        public void IsEmptyTest() {
            Dictionary<string, object>[] data = null; // TODO: Initialize to an appropriate value
            QueryResult target = new QueryResult(data); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RowCount
        ///</summary>
        [TestMethod()]
        public void RowCountTest() {
            Dictionary<string, object>[] data = null; // TODO: Initialize to an appropriate value
            QueryResult target = new QueryResult(data); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.RowCount();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
