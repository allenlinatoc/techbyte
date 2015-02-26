using TechByte.Architecture.Beans.Accounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Guitar32.Validations;
using TechByte.Architecture.Validations;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for SystemUserTest and is intended
    ///to contain all SystemUserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SystemUserTest
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
        ///A test for SystemUser Constructor
        ///</summary>
        [TestMethod()]
        public void SystemUserConstructorTest() {
            SystemUser target = new SystemUser();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getPassword
        ///</summary>
        [TestMethod()]
        public void getPasswordTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getPassword();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getPower
        ///</summary>
        [TestMethod()]
        public void getPowerTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getPower();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getProfile
        ///</summary>
        [TestMethod()]
        public void getProfileTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            Userprofile expected = null; // TODO: Initialize to an appropriate value
            Userprofile actual;
            actual = target.getProfile();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getStatus
        ///</summary>
        [TestMethod()]
        public void getStatusTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getStatus();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getUsername
        ///</summary>
        [TestMethod()]
        public void getUsernameTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getUsername();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setPassword
        ///</summary>
        [TestMethod()]
        public void setPasswordTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            Password password = null; // TODO: Initialize to an appropriate value
            target.setPassword(password);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setPower
        ///</summary>
        [TestMethod()]
        public void setPowerTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            UserPower userPower = null; // TODO: Initialize to an appropriate value
            target.setPower(userPower);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setProfile
        ///</summary>
        [TestMethod()]
        public void setProfileTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            Userprofile profile = null; // TODO: Initialize to an appropriate value
            target.setProfile(profile);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setStatus
        ///</summary>
        [TestMethod()]
        public void setStatusTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            AccountStatus status = null; // TODO: Initialize to an appropriate value
            target.setStatus(status);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setUsername
        ///</summary>
        [TestMethod()]
        public void setUsernameTest() {
            SystemUser target = new SystemUser(); // TODO: Initialize to an appropriate value
            SingleWordAlphaNumeric username = null; // TODO: Initialize to an appropriate value
            target.setUsername(username);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
