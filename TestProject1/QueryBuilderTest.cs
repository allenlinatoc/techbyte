using Guitar32.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for QueryBuilderTest and is intended
    ///to contain all QueryBuilderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class QueryBuilderTest
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
        ///A test for QueryBuilder Constructor
        ///</summary>
        [TestMethod()]
        public void QueryBuilderConstructorTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for From
        ///</summary>
        [TestMethod()]
        public void FromTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            QueryBuilder queryInstance = null; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.From(queryInstance);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for From
        ///</summary>
        [TestMethod()]
        public void FromTest1() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string table = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.From(table);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InsertInto
        ///</summary>
        [TestMethod()]
        public void InsertIntoTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string tablename = string.Empty; // TODO: Initialize to an appropriate value
            string[] columns = null; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.InsertInto(tablename, columns);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Select
        ///</summary>
        [TestMethod()]
        public void SelectTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string column = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Select(column);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Select
        ///</summary>
        [TestMethod()]
        public void SelectTest1() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string[] columns = null; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Select(columns);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Set
        ///</summary>
        [TestMethod()]
        public void SetTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string key = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Set(key, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Set
        ///</summary>
        [TestMethod()]
        public void SetTest1() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            Dictionary<string, string> setPairs = null; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Set(setPairs);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Update
        ///</summary>
        [TestMethod()]
        public void UpdateTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string tablename = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Update(tablename);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Values
        ///</summary>
        [TestMethod()]
        public void ValuesTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            object[] values = null; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Values(values);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Where
        ///</summary>
        [TestMethod()]
        public void WhereTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            Dictionary<object, object> conditions = null; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Where(conditions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Where
        ///</summary>
        [TestMethod()]
        public void WhereTest1() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string conditions = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder expected = null; // TODO: Initialize to an appropriate value
            QueryBuilder actual;
            actual = target.Where(conditions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getQueryString
        ///</summary>
        [TestMethod()]
        public void getQueryStringTest() {
            string queryString = string.Empty; // TODO: Initialize to an appropriate value
            QueryBuilder target = new QueryBuilder(queryString); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getQueryString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for padQuery
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void padQueryTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            QueryBuilder_Accessor target = new QueryBuilder_Accessor(param0); // TODO: Initialize to an appropriate value
            bool isNewLine = false; // TODO: Initialize to an appropriate value
            target.padQuery(isNewLine);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
