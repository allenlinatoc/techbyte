using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Guitar32.Validations.Monitors
{
    public class InputMonitor
    {
        private TextBox control;
        private ToolTip toolTip;
        private string 
            expression,
            message;
        private bool
            requiredField, realtimeValidation;
        private ToolTip toolTipRequired;
        private Color oldBackColor;
        private Timer timer;


        /// <summary>
        /// Initialize an instance of InputMonitor
        /// </summary>
        /// <param name="control">The target input field to be monitored</param>
        /// <param name="required">(Optional) If the input field being monitored is required to have value</param>
        /// <param name="realtimeValidation">(Optional) If the validation prompt to user should be realtime</param>
        public InputMonitor(TextBox control, bool required=false, bool realtimeValidation=true) {
            this.control = control;
            this.requiredField = required;
            this.oldBackColor = control.BackColor;

            // If required field
            if (this.requiredField) {
                ToolTip tt = new ToolTip();
                tt.IsBalloon = false;
                tt.ToolTipIcon = ToolTipIcon.Warning;
                tt.ToolTipTitle = "Required field";
                tt.UseAnimation = true;
                tt.UseFading = true;
                this.toolTipRequired = tt;
                this.control.GotFocus += new EventHandler(control_GotFocus);    // On GotFocus
                this.control.LostFocus += new EventHandler(control_LostFocus);  // On LostFocus
            }
            this.control.TextChanged += new EventHandler(control_TextChanged);  // On TextChanged
            this.realtimeValidation = realtimeValidation;
            // Initialize Timer
            this.timer = new Timer();
            this.timer.Interval = 500;
            this.timer.Tick += new EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e) {
            TextBox ctrl = (TextBox)this.control;

            if (this.realtimeValidation) {
                if (this.requiredField && ctrl.Text.Trim().Length == 0) {
                    if (this.toolTip != null) {
                        this.toolTip.Hide(ctrl);
                    }
                    this.toolTipRequired.Show("This field is required", ctrl, new System.Drawing.Point(ctrl.Width, -5));
                }
                else {
                    if (this.toolTipRequired != null) {
                        this.toolTipRequired.Hide(ctrl);
                    }
                }

                if (this.toolTip != null && (this.requiredField ? ctrl.Text.Trim().Length > 0 : true)) {
                    if (!Regex.IsMatch(this.control.Text, this.expression)) {
                        this.toolTip.Show(this.message, ctrl, new System.Drawing.Point(ctrl.Width, -5));
                    }
                    else {
                        this.toolTip.Hide(ctrl);
                    }
                }
            }
            this.timer.Stop();
        }

        private void control_TextChanged(object sender, EventArgs e) {
            this.ResetTimer();
            TextBox ctrl = (TextBox)sender;

            // Check for freak spaces
            if (ctrl.Text.Length > 0 && ctrl.Text.Trim().Length == 0) {
                ctrl.Text = "";
            }
            this.timer.Start(); 
        }

        private void control_LostFocus(object sender, EventArgs e) {
            TextBox ctrl = (TextBox)sender;
            ctrl.BackColor = this.oldBackColor;
            if (this.requiredField) {
                this.toolTipRequired.Hide(ctrl);
            }
            if (this.toolTip != null) {
                this.toolTip.Hide(ctrl);
            }
        }
        private void control_GotFocus(object sender, EventArgs e) {
            TextBox ctrl = (TextBox)sender;
            ctrl.BackColor = System.Drawing.Color.LightGreen;
            if (this.requiredField && ctrl.Text.Trim().Length==0) {
                if (this.toolTip != null) {
                    this.toolTip.Hide(ctrl);
                }
                this.toolTipRequired.Show("This field is required", ctrl, ctrl.Width, -5);
            }
        }


        /// <summary>
        /// Enable real-time validation
        /// </summary>
        public void EnableRealtimeValidation() {
            this.realtimeValidation = true;
        }


        /// <summary>
        /// Disable real-time validation
        /// </summary>
        public void DisableRealtimeValidation() {
            this.realtimeValidation = false;
        }


        /// <summary>
        /// Reset timer
        /// </summary>
        private void ResetTimer() {
            int interval = this.timer.Interval;
            this.timer.Dispose();
            this.timer = new Timer();
            this.timer.Interval = interval;
            this.timer.Tick += new EventHandler(timer_Tick);
        }


        /// <summary>
        /// Set the RegEx validator and the corresponding validation message
        /// </summary>
        /// <param name="expression">The Regular Expression string to be associated</param>
        /// <param name="message">The corresponding validation message</param>
        public void SetValidator(String expression, String message) {
            ToolTip tt = new ToolTip();
            tt.ToolTipIcon = ToolTipIcon.Error;
            tt.ToolTipTitle = "Check your input";
            tt.UseAnimation = true;
            tt.UseFading = true;
            this.toolTip = tt;
            this.expression = expression;
            this.message = message;
        }


        /// <summary>
        /// Validate the control's value if it matched the validator
        /// </summary>
        /// <returns>If control's current value complies with the validation</returns>
        public bool Validate() {
            if (this.requiredField && this.control.Text.Trim().Length == 0) {
                this.control.Focus();
                return false;
            }
            else if (this.control.Text.Length > 0 && this.expression != null && !Regex.IsMatch(this.control.Text, this.expression)) {
                    this.control.Focus();
                    this.toolTip.Show(this.message, this.control, new Point(this.control.Width, -5));
                    return false;
            }
            else {
                return true;
            }
        }



        // <Begin::Getters and Setters>

        /// <summary>
        /// Get the associated control being monitored
        /// </summary>
        /// <returns>The associated control being monitored</returns>
        public Control GetControl() {
            return this.control;
        }

        // <End::Getters and Setters>



    }
}
