using TechByte.Architecture.Beans.Profiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Guitar32.Validations;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for AddressDetailsTest and is intended
    ///to contain all AddressDetailsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AddressDetailsTest
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
        ///A test for AddressDetails Constructor
        ///</summary>
        [TestMethod()]
        public void AddressDetailsConstructorTest() {
            AddressDetails target = new AddressDetails();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getCity
        ///</summary>
        [TestMethod()]
        public void getCityTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getCity();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getCountry
        ///</summary>
        [TestMethod()]
        public void getCountryTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getCountry();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getRegion
        ///</summary>
        [TestMethod()]
        public void getRegionTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getRegion();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getStreet
        ///</summary>
        [TestMethod()]
        public void getStreetTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getStreet();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setCity
        ///</summary>
        [TestMethod()]
        public void setCityTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            MultiWordAlpha city = null; // TODO: Initialize to an appropriate value
            target.setCity(city);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setCountry
        ///</summary>
        [TestMethod()]
        public void setCountryTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            MultiWordAlpha country = null; // TODO: Initialize to an appropriate value
            target.setCountry(country);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setRegion
        ///</summary>
        [TestMethod()]
        public void setRegionTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            MultiWordAlpha region = null; // TODO: Initialize to an appropriate value
            target.setRegion(region);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setStreet
        ///</summary>
        [TestMethod()]
        public void setStreetTest() {
            AddressDetails target = new AddressDetails(); // TODO: Initialize to an appropriate value
            MultiWord street = null; // TODO: Initialize to an appropriate value
            target.setStreet(street);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
