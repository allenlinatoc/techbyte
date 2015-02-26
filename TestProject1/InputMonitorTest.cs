using Guitar32.Validations.Monitors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for InputMonitorTest and is intended
    ///to contain all InputMonitorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class InputMonitorTest
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
        ///A test for InputMonitor Constructor
        ///</summary>
        [TestMethod()]
        public void InputMonitorConstructorTest() {
            TextBox control = null; // TODO: Initialize to an appropriate value
            bool required = false; // TODO: Initialize to an appropriate value
            bool realtimeValidation = false; // TODO: Initialize to an appropriate value
            InputMonitor target = new InputMonitor(control, required, realtimeValidation);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DisableRealtimeValidation
        ///</summary>
        [TestMethod()]
        public void DisableRealtimeValidationTest() {
            TextBox control = null; // TODO: Initialize to an appropriate value
            bool required = false; // TODO: Initialize to an appropriate value
            bool realtimeValidation = false; // TODO: Initialize to an appropriate value
            InputMonitor target = new InputMonitor(control, required, realtimeValidation); // TODO: Initialize to an appropriate value
            target.DisableRealtimeValidation();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for EnableRealtimeValidation
        ///</summary>
        [TestMethod()]
        public void EnableRealtimeValidationTest() {
            TextBox control = null; // TODO: Initialize to an appropriate value
            bool required = false; // TODO: Initialize to an appropriate value
            bool realtimeValidation = false; // TODO: Initialize to an appropriate value
            InputMonitor target = new InputMonitor(control, required, realtimeValidation); // TODO: Initialize to an appropriate value
            target.EnableRealtimeValidation();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetControl
        ///</summary>
        [TestMethod()]
        public void GetControlTest() {
            TextBox control = null; // TODO: Initialize to an appropriate value
            bool required = false; // TODO: Initialize to an appropriate value
            bool realtimeValidation = false; // TODO: Initialize to an appropriate value
            InputMonitor target = new InputMonitor(control, required, realtimeValidation); // TODO: Initialize to an appropriate value
            Control expected = null; // TODO: Initialize to an appropriate value
            Control actual;
            actual = target.GetControl();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ResetTimer
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void ResetTimerTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            InputMonitor_Accessor target = new InputMonitor_Accessor(param0); // TODO: Initialize to an appropriate value
            target.ResetTimer();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetValidator
        ///</summary>
        [TestMethod()]
        public void SetValidatorTest() {
            TextBox control = null; // TODO: Initialize to an appropriate value
            bool required = false; // TODO: Initialize to an appropriate value
            bool realtimeValidation = false; // TODO: Initialize to an appropriate value
            InputMonitor target = new InputMonitor(control, required, realtimeValidation); // TODO: Initialize to an appropriate value
            string expression = string.Empty; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.SetValidator(expression, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Validate
        ///</summary>
        [TestMethod()]
        public void ValidateTest() {
            TextBox control = null; // TODO: Initialize to an appropriate value
            bool required = false; // TODO: Initialize to an appropriate value
            bool realtimeValidation = false; // TODO: Initialize to an appropriate value
            InputMonitor target = new InputMonitor(control, required, realtimeValidation); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Validate();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for control_GotFocus
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void control_GotFocusTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            InputMonitor_Accessor target = new InputMonitor_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.control_GotFocus(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for control_LostFocus
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void control_LostFocusTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            InputMonitor_Accessor target = new InputMonitor_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.control_LostFocus(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for control_TextChanged
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void control_TextChangedTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            InputMonitor_Accessor target = new InputMonitor_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.control_TextChanged(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for timer_Tick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TechByte.exe")]
        public void timer_TickTest() {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            InputMonitor_Accessor target = new InputMonitor_Accessor(param0); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.timer_Tick(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
