using TechByte.Architecture.Beans.Accounts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechByte.Architecture.Beans.Profiles;
using Guitar32.Validations;
using TechByte.Architecture.Validations;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for UserprofileTest and is intended
    ///to contain all UserprofileTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserprofileTest
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
        ///A test for Userprofile Constructor
        ///</summary>
        [TestMethod()]
        public void UserprofileConstructorTest() {
            Userprofile target = new Userprofile();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getAddressDetails
        ///</summary>
        [TestMethod()]
        public void getAddressDetailsTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            AddressDetails expected = null; // TODO: Initialize to an appropriate value
            AddressDetails actual;
            actual = target.getAddressDetails();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getBirthDate
        ///</summary>
        [TestMethod()]
        public void getBirthDateTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getBirthDate();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getBirthPlace
        ///</summary>
        [TestMethod()]
        public void getBirthPlaceTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getBirthPlace();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getContactDetails
        ///</summary>
        [TestMethod()]
        public void getContactDetailsTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            ContactDetails expected = null; // TODO: Initialize to an appropriate value
            ContactDetails actual;
            actual = target.getContactDetails();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getFullname
        ///</summary>
        [TestMethod()]
        public void getFullnameTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            Fullname expected = null; // TODO: Initialize to an appropriate value
            Fullname actual;
            actual = target.getFullname();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getGender
        ///</summary>
        [TestMethod()]
        public void getGenderTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getGender();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getNationality
        ///</summary>
        [TestMethod()]
        public void getNationalityTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getNationality();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getPAGIBIG
        ///</summary>
        [TestMethod()]
        public void getPAGIBIGTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getPAGIBIG();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getSSS
        ///</summary>
        [TestMethod()]
        public void getSSSTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getSSS();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getTIN
        ///</summary>
        [TestMethod()]
        public void getTINTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.getTIN();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setAddressDetails
        ///</summary>
        [TestMethod()]
        public void setAddressDetailsTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            AddressDetails addressDetails = null; // TODO: Initialize to an appropriate value
            target.setAddressDetails(addressDetails);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setBirthDate
        ///</summary>
        [TestMethod()]
        public void setBirthDateTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            DateTime birthDate = null; // TODO: Initialize to an appropriate value
            target.setBirthDate(birthDate);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setBirthPlace
        ///</summary>
        [TestMethod()]
        public void setBirthPlaceTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            MultiWord birthPlace = null; // TODO: Initialize to an appropriate value
            target.setBirthPlace(birthPlace);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setContactDetails
        ///</summary>
        [TestMethod()]
        public void setContactDetailsTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            ContactDetails contactDetails = null; // TODO: Initialize to an appropriate value
            target.setContactDetails(contactDetails);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setFullname
        ///</summary>
        [TestMethod()]
        public void setFullnameTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            Fullname fullname = null; // TODO: Initialize to an appropriate value
            target.setFullname(fullname);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setGender
        ///</summary>
        [TestMethod()]
        public void setGenderTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            Gender gender = null; // TODO: Initialize to an appropriate value
            target.setGender(gender);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setNationality
        ///</summary>
        [TestMethod()]
        public void setNationalityTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            MultiWordAlpha nationality = null; // TODO: Initialize to an appropriate value
            target.setNationality(nationality);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setPAGIBIG
        ///</summary>
        [TestMethod()]
        public void setPAGIBIGTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string PAGIBIG = string.Empty; // TODO: Initialize to an appropriate value
            target.setPAGIBIG(PAGIBIG);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setSSS
        ///</summary>
        [TestMethod()]
        public void setSSSTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            string SSS = string.Empty; // TODO: Initialize to an appropriate value
            target.setSSS(SSS);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setTIN
        ///</summary>
        [TestMethod()]
        public void setTINTest() {
            Userprofile target = new Userprofile(); // TODO: Initialize to an appropriate value
            TIN TIN = null; // TODO: Initialize to an appropriate value
            target.setTIN(TIN);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
