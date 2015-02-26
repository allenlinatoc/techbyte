using TechByte.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for DashboardTest and is intended
    ///to contain all DashboardTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DashboardTest
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
        ///A test for Dashboard Constructor
        ///</summary>
        [TestMethod()]
        public void DashboardConstructorTest() {
            Dashboard target = new Dashboard();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dashboard_FormClosing
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void Dashboard_FormClosingTest() {
            Dashboard_Accessor target = new Dashboard_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            FormClosingEventArgs e = null; // TODO: Initialize to an appropriate value
            target.Dashboard_FormClosing(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dashboard_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void Dashboard_LoadTest() {
            Dashboard_Accessor target = new Dashboard_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Dashboard_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DisposeTest() {
            Dashboard_Accessor target = new Dashboard_Accessor(); // TODO: Initialize to an appropriate value
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
            Dashboard_Accessor target = new Dashboard_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for logoutToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void logoutToolStripMenuItem_ClickTest() {
            Dashboard_Accessor target = new Dashboard_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.logoutToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for systemConfigurationToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void systemConfigurationToolStripMenuItem_ClickTest() {
            Dashboard_Accessor target = new Dashboard_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.systemConfigurationToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for userManagementToolStripMenuItem_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void userManagementToolStripMenuItem_ClickTest() {
            Dashboard_Accessor target = new Dashboard_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.userManagementToolStripMenuItem_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
