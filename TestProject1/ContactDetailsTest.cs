using TechByte.Architecture.Beans.Profiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Guitar32.Validations;
using TechByte.Architecture.Validations;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ContactDetailsTest and is intended
    ///to contain all ContactDetailsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContactDetailsTest
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
        ///A test for ContactDetails Constructor
        ///</summary>
        [TestMethod()]
        public void ContactDetailsConstructorTest() {
            ContactDetails target = new ContactDetails();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getEmail
        ///</summary>
        [TestMethod()]
        public void getEmailTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getEmail();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getFax
        ///</summary>
        [TestMethod()]
        public void getFaxTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getFax();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getLandline
        ///</summary>
        [TestMethod()]
        public void getLandlineTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getLandline();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getMobile
        ///</summary>
        [TestMethod()]
        public void getMobileTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getMobile();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setEmail
        ///</summary>
        [TestMethod()]
        public void setEmailTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            Email email = null; // TODO: Initialize to an appropriate value
            target.setEmail(email);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setFax
        ///</summary>
        [TestMethod()]
        public void setFaxTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            string fax = string.Empty; // TODO: Initialize to an appropriate value
            target.setFax(fax);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setLandline
        ///</summary>
        [TestMethod()]
        public void setLandlineTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            string landline = string.Empty; // TODO: Initialize to an appropriate value
            target.setLandline(landline);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setMobile
        ///</summary>
        [TestMethod()]
        public void setMobileTest() {
            ContactDetails target = new ContactDetails(); // TODO: Initialize to an appropriate value
            MobileNumber mobile = null; // TODO: Initialize to an appropriate value
            target.setMobile(mobile);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
