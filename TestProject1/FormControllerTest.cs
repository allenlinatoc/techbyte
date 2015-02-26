using Guitar32.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Guitar32.Validations.Monitors;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for FormControllerTest and is intended
    ///to contain all FormControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FormControllerTest
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
        ///A test for FormController Constructor
        ///</summary>
        [TestMethod()]
        public void FormControllerConstructorTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AddInputMonitor
        ///</summary>
        [TestMethod()]
        public void AddInputMonitorTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            InputMonitor inputMonitor = null; // TODO: Initialize to an appropriate value
            FormController expected = null; // TODO: Initialize to an appropriate value
            FormController actual;
            actual = target.AddInputMonitor(inputMonitor);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Disable
        ///</summary>
        [TestMethod()]
        public void DisableTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            target.Disable();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DisableCloseDetections
        ///</summary>
        [TestMethod()]
        public void DisableCloseDetectionsTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            target.DisableCloseDetections();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Enable
        ///</summary>
        [TestMethod()]
        public void EnableTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            target.Enable();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for EnableCloseDetections
        ///</summary>
        [TestMethod()]
        public void EnableCloseDetectionsTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            target.EnableCloseDetections();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for FormController_FormClosing
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void FormController_FormClosingTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            FormController_Accessor target = new FormController_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            FormClosingEventArgs e = null; // TODO: Initialize to an appropriate value
            target.FormController_FormClosing(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetInputMonitors
        ///</summary>
        [TestMethod()]
        public void GetInputMonitorsTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            InputMonitorCollection expected = null; // TODO: Initialize to an appropriate value
            InputMonitorCollection actual;
            actual = target.GetInputMonitors();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HasUnsavedChanges
        ///</summary>
        [TestMethod()]
        public void HasUnsavedChangesTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            Control.ControlCollection controls = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.HasUnsavedChanges(controls);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsSubmittable
        ///</summary>
        [TestMethod()]
        public void IsSubmittableTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsSubmittable();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResetFields
        ///</summary>
        [TestMethod()]
        public void ResetFieldsTest() {
            bool detectCloseOperations = false; // TODO: Initialize to an appropriate value
            FormController target = new FormController(detectCloseOperations); // TODO: Initialize to an appropriate value
            Control.ControlCollection controls = null; // TODO: Initialize to an appropriate value
            target.ResetFields(controls);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
