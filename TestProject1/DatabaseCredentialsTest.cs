using Guitar32.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DatabaseCredentialsTest and is intended
    ///to contain all DatabaseCredentialsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DatabaseCredentialsTest
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
        ///A test for DatabaseCredentials Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseCredentialsConstructorTest() {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            DatabaseCredentials target = new DatabaseCredentials(path);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DatabaseCredentials Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseCredentialsConstructorTest1() {
            DatabaseCredentials target = new DatabaseCredentials();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Deserialize
        ///</summary>
        [TestMethod()]
        public void DeserializeTest() {
            byte[] buffer = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials expected = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials actual;
            actual = DatabaseCredentials.Deserialize(buffer);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dump
        ///</summary>
        [TestMethod()]
        public void DumpTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string path = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Dump(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Serialize
        ///</summary>
        [TestMethod()]
        public void SerializeTest() {
            DatabaseCredentials creds = null; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = DatabaseCredentials.Serialize(creds);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for createFromFile
        ///</summary>
        [TestMethod()]
        public void createFromFileTest() {
            string path = string.Empty; // TODO: Initialize to an appropriate value
            DatabaseCredentials expected = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials actual;
            actual = DatabaseCredentials.createFromFile(path);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getDatabase
        ///</summary>
        [TestMethod()]
        public void getDatabaseTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getDatabase();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getPassword
        ///</summary>
        [TestMethod()]
        public void getPasswordTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getPassword();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getPort
        ///</summary>
        [TestMethod()]
        public void getPortTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            uint expected = 0; // TODO: Initialize to an appropriate value
            uint actual;
            actual = target.getPort();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getServer
        ///</summary>
        [TestMethod()]
        public void getServerTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getServer();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getUsername
        ///</summary>
        [TestMethod()]
        public void getUsernameTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getUsername();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setDatabase
        ///</summary>
        [TestMethod()]
        public void setDatabaseTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string database = string.Empty; // TODO: Initialize to an appropriate value
            DatabaseCredentials expected = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials actual;
            actual = target.setDatabase(database);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setPassword
        ///</summary>
        [TestMethod()]
        public void setPasswordTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string password = string.Empty; // TODO: Initialize to an appropriate value
            DatabaseCredentials expected = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials actual;
            actual = target.setPassword(password);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setPort
        ///</summary>
        [TestMethod()]
        public void setPortTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            uint port = 0; // TODO: Initialize to an appropriate value
            DatabaseCredentials expected = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials actual;
            actual = target.setPort(port);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setServer
        ///</summary>
        [TestMethod()]
        public void setServerTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string server = string.Empty; // TODO: Initialize to an appropriate value
            DatabaseCredentials expected = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials actual;
            actual = target.setServer(server);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setUsername
        ///</summary>
        [TestMethod()]
        public void setUsernameTest() {
            DatabaseCredentials target = new DatabaseCredentials(); // TODO: Initialize to an appropriate value
            string username = string.Empty; // TODO: Initialize to an appropriate value
            DatabaseCredentials expected = null; // TODO: Initialize to an appropriate value
            DatabaseCredentials actual;
            actual = target.setUsername(username);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
