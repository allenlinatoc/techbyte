using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Guitar32.Validations.Monitors;

namespace Guitar32.Controllers
{
    public class FormController : Form
    {
        private InputMonitorCollection inputMonitorCollection;
        private bool detectCloseOperations = false;
        
        /// <summary>
        /// Instantiate this FormController
        /// </summary>
        /// <param name="detectCloseOperations">(Optional) If close operations should be detected (e.g. unsaved user inputs detection, etc.)</param>
        public FormController(bool detectCloseOperations = false) : base() {
            this.inputMonitorCollection = new InputMonitorCollection();
            this.detectCloseOperations = detectCloseOperations;
            this.FormClosing += new FormClosingEventHandler(FormController_FormClosing);
        }


        void FormController_FormClosing(object sender, FormClosingEventArgs e) {
            if (this.detectCloseOperations) {
                if (this.HasUnsavedChanges()) {
                    DialogResult dResult = MessageBox.Show("You have unsaved changes. Are you sure you want to close this form?", "Confirm form closing", MessageBoxButtons.YesNo);
                    if (dResult != DialogResult.Yes) {
                        e.Cancel = true;
                    }
                }
            }
        }


        /// <summary>
        /// Add an input monitor in one this form's input fields
        /// </summary>
        /// <param name="inputMonitor">The InputMonitor object to be added</param>
        public FormController AddInputMonitor(InputMonitor inputMonitor) {
            this.inputMonitorCollection.Add(inputMonitor);
            return this;
        }


        /// <summary>
        /// Disable the whole form
        /// </summary>
        public void Disable() {
            this.Enabled = false;
        }


        /// <summary>
        /// Disable detection of onClose operations
        /// </summary>
        public void DisableCloseDetections() {
            if (this.detectCloseOperations) {
                this.detectCloseOperations = false;
            }
        }


        /// <summary>
        /// Enable the whole form
        /// </summary>
        public void Enable() {
            this.Enabled = true;
        }


        /// <summary>
        /// Enable detection of onClose operations
        /// </summary>
        public void EnableCloseDetections() {
            if (!this.detectCloseOperations) {
                this.detectCloseOperations = true;
            }
        }


        /// <summary>
        /// Get all input monitors in this form
        /// </summary>
        /// <returns></returns>
        public InputMonitorCollection GetInputMonitors() {
            return this.inputMonitorCollection;
        }

        /// <summary>
        /// Check if this form has fields with potential pending unsaved changes
        /// </summary>
        /// <param name="controls">Do not supply this parameter!!!</param>
        /// <returns>If this form has fields with potential pending unsaved changes</returns>
        public bool HasUnsavedChanges(Control.ControlCollection controls = null) {
            if (controls == null) {
                controls = this.Controls;
            }
            foreach (Control control in controls) {
                System.Type controlType = control.GetType();
                if (controlType.Equals(typeof(TextBox))) {
                    TextBox textBox = (TextBox)control;
                    if (textBox.Text.Length > 0) {
                        return true;
                    }
                }
                if (control.Controls.Count > 0) {
                    return this.HasUnsavedChanges(control.Controls);
                }
            }

            return false;
        }


        /// <summary>
        /// Check if this form is ready for submission
        /// </summary>
        /// <returns>If this form is ready for submission</returns>
        public bool IsSubmittable() {
            return this.GetInputMonitors().IsSubmittable();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="controls">Do not supply this parameter!!!</param>
        public void ResetFields(Control.ControlCollection controls = null) {
            if (controls == null) {
                controls = this.Controls;
            }
            foreach (Control control in controls) {
                if (control.GetType().Equals(typeof(TextBox))) {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                else if (control.GetType().Equals(typeof(ComboBox))) {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.SelectedIndex = 0;
                }

                if (control.HasChildren) {
                    ResetFields(control.Controls);
                }
            }
        }

    }
}
