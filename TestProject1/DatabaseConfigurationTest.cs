using TechByte.Views.DashboardSub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DatabaseConfigurationTest and is intended
    ///to contain all DatabaseConfigurationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DatabaseConfigurationTest
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
        ///A test for DatabaseConfiguration Constructor
        ///</summary>
        [TestMethod()]
        public void DatabaseConfigurationConstructorTest() {
            DatabaseConfiguration target = new DatabaseConfiguration();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DatabaseConfiguration_FormClosing
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DatabaseConfiguration_FormClosingTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            FormClosingEventArgs e = null; // TODO: Initialize to an appropriate value
            target.DatabaseConfiguration_FormClosing(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DatabaseConfiguration_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DatabaseConfiguration_LoadTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.DatabaseConfiguration_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DisposeTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
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
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeMonitors
        ///</summary>
        [TestMethod()]
        public void InitializeMonitorsTest() {
            DatabaseConfiguration target = new DatabaseConfiguration(); // TODO: Initialize to an appropriate value
            target.InitializeMonitors();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCancel_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnCancel_ClickTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCancel_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnOk_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnOk_ClickTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnOk_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnTest_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnTest_ClickTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnTest_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for fieldKeyPress
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void fieldKeyPressTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            KeyPressEventArgs e = null; // TODO: Initialize to an appropriate value
            target.fieldKeyPress(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for txtPort_KeyDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void txtPort_KeyDownTest() {
            DatabaseConfiguration_Accessor target = new DatabaseConfiguration_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            KeyEventArgs e = null; // TODO: Initialize to an appropriate value
            target.txtPort_KeyDown(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
