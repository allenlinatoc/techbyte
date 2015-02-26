using TechByte.Architecture.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for UserPowerTest and is intended
    ///to contain all UserPowerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserPowerTest
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
        ///A test for UserPower Constructor
        ///</summary>
        [TestMethod()]
        public void UserPowerConstructorTest() {
            string powerName = string.Empty; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerName, throwException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for UserPower Constructor
        ///</summary>
        [TestMethod()]
        public void UserPowerConstructorTest1() {
            int powerId = 0; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerId, throwException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for LookupId
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void LookupIdTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            UserPower_Accessor target = new UserPower_Accessor(param0); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.LookupId();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LookupName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void LookupNameTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            UserPower_Accessor target = new UserPower_Accessor(param0); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.LookupName();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getMaxLength
        ///</summary>
        [TestMethod()]
        public void getMaxLengthTest() {
            int powerId = 0; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerId, throwException); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getMaxLength();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getMinLength
        ///</summary>
        [TestMethod()]
        public void getMinLengthTest() {
            int powerId = 0; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerId, throwException); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getMinLength();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getPowerId
        ///</summary>
        [TestMethod()]
        public void getPowerIdTest() {
            int powerId = 0; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerId, throwException); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.getPowerId();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getValue
        ///</summary>
        [TestMethod()]
        public void getValueTest() {
            int powerId = 0; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerId, throwException); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isValid
        ///</summary>
        [TestMethod()]
        public void isValidTest() {
            int powerId = 0; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerId, throwException); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isValid();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isWithinRange
        ///</summary>
        [TestMethod()]
        public void isWithinRangeTest() {
            int powerId = 0; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            UserPower target = new UserPower(powerId, throwException); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isWithinRange();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
