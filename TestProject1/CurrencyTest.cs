using Guitar32.Validations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for CurrencyTest and is intended
    ///to contain all CurrencyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CurrencyTest
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
        ///A test for Currency Constructor
        ///</summary>
        [TestMethod()]
        public void CurrencyConstructorTest() {
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            Currency target = new Currency(value, throwException);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getMaxValue
        ///</summary>
        [TestMethod()]
        public void getMaxValueTest() {
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            Currency target = new Currency(value, throwException); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = target.getMaxValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getMinValue
        ///</summary>
        [TestMethod()]
        public void getMinValueTest() {
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            Currency target = new Currency(value, throwException); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = target.getMinValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getValue
        ///</summary>
        [TestMethod()]
        public void getValueTest() {
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            Currency target = new Currency(value, throwException); // TODO: Initialize to an appropriate value
            float expected = 0F; // TODO: Initialize to an appropriate value
            float actual;
            actual = target.getValue();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for isValid
        ///</summary>
        [TestMethod()]
        public void isValidTest() {
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            Currency target = new Currency(value, throwException); // TODO: Initialize to an appropriate value
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
            string value = string.Empty; // TODO: Initialize to an appropriate value
            bool throwException = false; // TODO: Initialize to an appropriate value
            Currency target = new Currency(value, throwException); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isWithinRange();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
