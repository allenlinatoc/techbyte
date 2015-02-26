using TechByte.Architecture.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechByte.Architecture.Enums;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for IFormModalTest and is intended
    ///to contain all IFormModalTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IFormModalTest
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


        internal virtual IFormModal CreateIFormModal() {
            // TODO: Instantiate an appropriate concrete class.
            IFormModal target = null;
            return target;
        }

        /// <summary>
        ///A test for initFormModal
        ///</summary>
        [TestMethod()]
        public void initFormModalTest() {
            IFormModal target = CreateIFormModal(); // TODO: Initialize to an appropriate value
            target.initFormModal();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setMode
        ///</summary>
        [TestMethod()]
        public void setModeTest() {
            IFormModal target = CreateIFormModal(); // TODO: Initialize to an appropriate value
            FormModalTypes type = new FormModalTypes(); // TODO: Initialize to an appropriate value
            target.setMode(type);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
