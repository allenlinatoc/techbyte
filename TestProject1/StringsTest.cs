using Guitar32.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for StringsTest and is intended
    ///to contain all StringsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StringsTest
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
        ///A test for Strings Constructor
        ///</summary>
        [TestMethod()]
        public void StringsConstructorTest() {
            Strings target = new Strings();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for FormatInt
        ///</summary>
        [TestMethod()]
        public void FormatIntTest() {
            int number = 0; // TODO: Initialize to an appropriate value
            int digitCount = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Strings.FormatInt(number, digitCount);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsSurrounded
        ///</summary>
        [TestMethod()]
        public void IsSurroundedTest() {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            char fence = '\0'; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Strings.IsSurrounded(str, fence);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LowercaseFirst
        ///</summary>
        [TestMethod()]
        public void LowercaseFirstTest() {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Strings.LowercaseFirst(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reverse
        ///</summary>
        [TestMethod()]
        public void ReverseTest() {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Strings.Reverse(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RightTrim
        ///</summary>
        [TestMethod()]
        public void RightTrimTest() {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            char chmask = '\0'; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Strings.RightTrim(str, chmask);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Surround
        ///</summary>
        [TestMethod()]
        public void SurroundTest() {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            char fence = '\0'; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Strings.Surround(str, fence);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Unsurround
        ///</summary>
        [TestMethod()]
        public void UnsurroundTest() {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            char fence = '\0'; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Strings.Unsurround(str, fence);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for UppercaseFirst
        ///</summary>
        [TestMethod()]
        public void UppercaseFirstTest() {
            string str = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = Strings.UppercaseFirst(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
