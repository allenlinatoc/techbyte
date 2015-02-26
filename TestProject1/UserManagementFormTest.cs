using TechByte.Views.DashboardSub.Modals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechByte.Architecture.Enums;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for UserManagementFormTest and is intended
    ///to contain all UserManagementFormTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserManagementFormTest
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
        ///A test for UserManagementForm Constructor
        ///</summary>
        [TestMethod()]
        public void UserManagementFormConstructorTest() {
            UserManagementForm target = new UserManagementForm();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DisposeTest() {
            UserManagementForm_Accessor target = new UserManagementForm_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void InitializeComponentTest() {
            UserManagementForm_Accessor target = new UserManagementForm_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeMonitors
        ///</summary>
        [TestMethod()]
        public void InitializeMonitorsTest() {
            UserManagementForm target = new UserManagementForm(); // TODO: Initialize to an appropriate value
            target.InitializeMonitors();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCancel_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnCancel_ClickTest() {
            UserManagementForm_Accessor target = new UserManagementForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCancel_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnSubmit_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnSubmit_ClickTest() {
            UserManagementForm_Accessor target = new UserManagementForm_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnSubmit_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for initFormModal
        ///</summary>
        [TestMethod()]
        public void initFormModalTest() {
            UserManagementForm target = new UserManagementForm(); // TODO: Initialize to an appropriate value
            target.initFormModal();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setMode
        ///</summary>
        [TestMethod()]
        public void setModeTest() {
            UserManagementForm target = new UserManagementForm(); // TODO: Initialize to an appropriate value
            FormModalTypes type = new FormModalTypes(); // TODO: Initialize to an appropriate value
            target.setMode(type);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
