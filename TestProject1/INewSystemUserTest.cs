using TechByte.Architecture.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for INewSystemUserTest and is intended
    ///to contain all INewSystemUserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class INewSystemUserTest
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


        internal virtual INewSystemUser CreateINewSystemUser() {
            // TODO: Instantiate an appropriate concrete class.
            INewSystemUser target = null;
            return target;
        }

        /// <summary>
        ///A test for Register
        ///</summary>
        [TestMethod()]
        public void RegisterTest() {
            INewSystemUser target = CreateINewSystemUser(); // TODO: Initialize to an appropriate value
            string position = string.Empty; // TODO: Initialize to an appropriate value
            string username = string.Empty; // TODO: Initialize to an appropriate value
            string password1 = string.Empty; // TODO: Initialize to an appropriate value
            string password2 = string.Empty; // TODO: Initialize to an appropriate value
            string firstName = string.Empty; // TODO: Initialize to an appropriate value
            string middleName = string.Empty; // TODO: Initialize to an appropriate value
            string lastName = string.Empty; // TODO: Initialize to an appropriate value
            string gender = string.Empty; // TODO: Initialize to an appropriate value
            string birthdate = string.Empty; // TODO: Initialize to an appropriate value
            string birthplace = string.Empty; // TODO: Initialize to an appropriate value
            string nationality = string.Empty; // TODO: Initialize to an appropriate value
            string TIN = string.Empty; // TODO: Initialize to an appropriate value
            string SSS = string.Empty; // TODO: Initialize to an appropriate value
            string PAGIBIG = string.Empty; // TODO: Initialize to an appropriate value
            string email = string.Empty; // TODO: Initialize to an appropriate value
            string mobile = string.Empty; // TODO: Initialize to an appropriate value
            string landline = string.Empty; // TODO: Initialize to an appropriate value
            string fax = string.Empty; // TODO: Initialize to an appropriate value
            string street = string.Empty; // TODO: Initialize to an appropriate value
            string city = string.Empty; // TODO: Initialize to an appropriate value
            string region = string.Empty; // TODO: Initialize to an appropriate value
            string country = string.Empty; // TODO: Initialize to an appropriate value
            target.Register(position, username, password1, password2, firstName, middleName, lastName, gender, birthdate, birthplace, nationality, TIN, SSS, PAGIBIG, email, mobile, landline, fax, street, city, region, country);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
