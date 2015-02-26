using TechByte.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for Form1Test and is intended
    ///to contain all Form1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Form1Test
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
        ///A test for Form1 Constructor
        ///</summary>
        [TestMethod()]
        public void Form1ConstructorTest() {
            Form1 target = new Form1();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void DisposeTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Form1_EnabledChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void Form1_EnabledChangedTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Form1_EnabledChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Form1_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void Form1_LoadTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.Form1_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Form1_Ready
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void Form1_ReadyTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            bool isDbConnected = false; // TODO: Initialize to an appropriate value
            target.Form1_Ready(isDbConnected);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void InitializeComponentTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeMonitors
        ///</summary>
        [TestMethod()]
        public void InitializeMonitorsTest() {
            Form1 target = new Form1(); // TODO: Initialize to an appropriate value
            target.InitializeMonitors();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for backgroundWorker1_DoWork
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void backgroundWorker1_DoWorkTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            DoWorkEventArgs e = null; // TODO: Initialize to an appropriate value
            target.backgroundWorker1_DoWork(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for backgroundWorker1_ProgressChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void backgroundWorker1_ProgressChangedTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ProgressChangedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.backgroundWorker1_ProgressChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for backgroundWorker1_RunWorkerCompleted
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void backgroundWorker1_RunWorkerCompletedTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RunWorkerCompletedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.backgroundWorker1_RunWorkerCompleted(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnCancel_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnCancel_ClickTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnCancel_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for btnLogin_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void btnLogin_ClickTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnLogin_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for linkRetryDB_LinkClicked
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void linkRetryDB_LinkClickedTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            LinkLabelLinkClickedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.linkRetryDB_LinkClicked(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for timerFade_Tick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void timerFade_TickTest() {
            Form1_Accessor target = new Form1_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.timerFade_Tick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
