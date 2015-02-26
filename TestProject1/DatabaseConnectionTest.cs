using Guitar32.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DatabaseConnectionTest and is intended
    ///to contain all DatabaseConnectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DatabaseConnectionTest
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
        ///A test for DatabaseConnection Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseConnectionConstructorTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Connect
        ///</summary>
        [TestMethod()]
        public void ConnectTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Connect();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            QueryBuilder query = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Execute(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Execute
        ///</summary>
        [TestMethod()]
        public void ExecuteTest1() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            string query = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Execute(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Exists
        ///</summary>
        [TestMethod()]
        public void ExistsTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            QueryBuilder query = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Exists(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Exists
        ///</summary>
        [TestMethod()]
        public void ExistsTest1() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            string query = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Exists(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetLastResult
        ///</summary>
        [TestMethod()]
        public void GetLastResultTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            string[][] expected = null; // TODO: Initialize to an appropriate value
            string[][] actual;
            actual = target.GetLastResult();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsConnected
        ///</summary>
        [TestMethod()]
        public void IsConnectedTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsConnected();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LogError
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void LogErrorTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            DatabaseConnection_Accessor target = new DatabaseConnection_Accessor(param0); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            int errorCode = 0; // TODO: Initialize to an appropriate value
            target.LogError(message, errorCode);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Query
        ///</summary>
        [TestMethod()]
        public void QueryTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            string query = string.Empty; // TODO: Initialize to an appropriate value
            QueryResult expected = null; // TODO: Initialize to an appropriate value
            QueryResult actual;
            actual = target.Query(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Query
        ///</summary>
        [TestMethod()]
        public void QueryTest1() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            QueryBuilder query = null; // TODO: Initialize to an appropriate value
            QueryResult expected = null; // TODO: Initialize to an appropriate value
            QueryResult actual;
            actual = target.Query(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QuerySingle
        ///</summary>
        [TestMethod()]
        public void QuerySingleTest() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            string query = string.Empty; // TODO: Initialize to an appropriate value
            Dictionary<string, object> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, object> actual;
            actual = target.QuerySingle(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for QuerySingle
        ///</summary>
        [TestMethod()]
        public void QuerySingleTest1() {
            DatabaseCredentials credentials = null; // TODO: Initialize to an appropriate value
            string characterSet = string.Empty; // TODO: Initialize to an appropriate value
            DBMSTypes type = new DBMSTypes(); // TODO: Initialize to an appropriate value
            DatabaseConnection target = new DatabaseConnection(credentials, characterSet, type); // TODO: Initialize to an appropriate value
            QueryBuilder query = null; // TODO: Initialize to an appropriate value
            Dictionary<string, object> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, object> actual;
            actual = target.QuerySingle(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
