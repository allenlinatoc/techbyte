using TechByte.Views.DashboardSub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for UserManagementTest and is intended
    ///to contain all UserManagementTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UserManagementTest
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
        ///A test for UserManagement Constructor
        ///</summary>
        [TestMethod()]
        public void UserManagementConstructorTest() {
            UserManagement target = new UserManagement();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DisposeTest() {
            UserManagement_Accessor target = new UserManagement_Accessor(); // TODO: Initialize to an appropriate value
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
            UserManagement_Accessor target = new UserManagement_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for UserManagement_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void UserManagement_LoadTest() {
            UserManagement_Accessor target = new UserManagement_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.UserManagement_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnNew_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnNew_ClickTest() {
            UserManagement_Accessor target = new UserManagement_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnNew_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for dataGridView1_CellContentClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void dataGridView1_CellContentClickTest() {
            UserManagement_Accessor target = new UserManagement_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dataGridView1_CellContentClick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for dataGridView1_CellMouseClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void dataGridView1_CellMouseClickTest() {
            UserManagement_Accessor target = new UserManagement_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DataGridViewCellMouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.dataGridView1_CellMouseClick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
