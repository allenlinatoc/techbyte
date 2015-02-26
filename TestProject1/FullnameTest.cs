using TechByte.Architecture.Beans.Profiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Guitar32.Validations;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for FullnameTest and is intended
    ///to contain all FullnameTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FullnameTest
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
        ///A test for Fullname Constructor
        ///</summary>
        [TestMethod()]
        public void FullnameConstructorTest() {
            Fullname target = new Fullname();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getFirstName
        ///</summary>
        [TestMethod()]
        public void getFirstNameTest() {
            Fullname target = new Fullname(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getFirstName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getLastName
        ///</summary>
        [TestMethod()]
        public void getLastNameTest() {
            Fullname target = new Fullname(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getLastName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getMiddleName
        ///</summary>
        [TestMethod()]
        public void getMiddleNameTest() {
            Fullname target = new Fullname(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getMiddleName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setFirstName
        ///</summary>
        [TestMethod()]
        public void setFirstNameTest() {
            Fullname target = new Fullname(); // TODO: Initialize to an appropriate value
            MultiWordAlpha firstName = null; // TODO: Initialize to an appropriate value
            target.setFirstName(firstName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setLastName
        ///</summary>
        [TestMethod()]
        public void setLastNameTest() {
            Fullname target = new Fullname(); // TODO: Initialize to an appropriate value
            MultiWordAlpha lastName = null; // TODO: Initialize to an appropriate value
            target.setLastName(lastName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setMiddleName
        ///</summary>
        [TestMethod()]
        public void setMiddleNameTest() {
            Fullname target = new Fullname(); // TODO: Initialize to an appropriate value
            MultiWordAlpha middleName = null; // TODO: Initialize to an appropriate value
            target.setMiddleName(middleName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
