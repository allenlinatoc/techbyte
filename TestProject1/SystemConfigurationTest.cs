using TechByte.Views.DashboardSub.Admin;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for SystemConfigurationTest and is intended
    ///to contain all SystemConfigurationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SystemConfigurationTest
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
        ///A test for SystemConfiguration Constructor
        ///</summary>
        [TestMethod()]
        public void SystemConfigurationConstructorTest() {
            SystemConfiguration target = new SystemConfiguration();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DisposeTest() {
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
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
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SystemConfiguration_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void SystemConfiguration_LoadTest() {
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.SystemConfiguration_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCancel_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnCancel_ClickTest() {
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCancel_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnChangeBackcolor_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnChangeBackcolor_ClickTest() {
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnChangeBackcolor_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnSave_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnSave_ClickTest() {
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnSave_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for comboLockdown_SelectedIndexChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void comboLockdown_SelectedIndexChangedTest() {
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.comboLockdown_SelectedIndexChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for textBox1_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void textBox1_TextChangedTest() {
            SystemConfiguration_Accessor target = new SystemConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.textBox1_TextChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
