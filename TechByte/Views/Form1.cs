using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guitar32.Common;
using Guitar32.Cryptography;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations.Monitors;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using TechByte.Architecture.Beans.Accounts;


namespace TechByte.Views
{
    public partial class Form1 : Guitar32.Controllers.FormController, IMonitorable
    {
        delegate void SetStatusCallback(object sender, DoWorkEventArgs e);
        System.Data.ConnectionState connectionState = ConnectionState.Closed;

        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
            timerFade.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * DON'T PUT ANY STARTUP LOADS HERE
             * Refer to Form1_Ready() event
             */
            this.InitializeMonitors();
            if (!TechByte.Configs.DatabaseCredentialsFile.Exists()) {
                TechByte.Views.DashboardSub.DatabaseConfiguration frmDatabaseConfiguration = new DashboardSub.DatabaseConfiguration();
                frmDatabaseConfiguration.ShowDialog(this);
            }
        }

        /// <summary>
        /// Event called when the form is ready
        /// </summary>
        /// <param name="isDbConnected">Boolean value if app is connected to database after the form has been ready</param>
        private void Form1_Ready(Boolean isDbConnected) {
            if (isDbConnected) {
                // Call stuff here if system is DB connected
                DialogResult result = System.Windows.Forms.DialogResult.Yes;
                while (!result.Equals(DialogResult.No)) {
                    if (TechByte.Configs.AppConfig.Initialize()) {
                        result = DialogResult.Yes;
                        break;
                    }
                    result = MessageBox.Show("Failed to fetch system configuration. Do you want to retry?", "Failed to fetch configuration", MessageBoxButtons.YesNo);
                }
                if (result.Equals(DialogResult.No)) {
                    Application.Exit();
                }
            }
        }


        // <Begin::Functions>

        public void InitializeMonitors()
        {
            InputMonitor mUsername = new InputMonitor(txtUsername, true);
            mUsername.SetValidator(Guitar32.Validations.SingleWordAlphaNumeric.expression, "Only alphanumeric and no spaces");
            mUsername.EnableRealtimeValidation();
            this.AddInputMonitor(mUsername);

            InputMonitor mPassword = new InputMonitor(txtPassword, true);
            mPassword.SetValidator(Guitar32.Validations.Password.expression, "Only alphanumeric and special characters ~!@#$%^*+= are allowed");
            mPassword.EnableRealtimeValidation();
            this.AddInputMonitor(mPassword);
        }

        // <End::Functions>


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (!this.GetInputMonitors().IsSubmittable()) {
                return;
            }

            TechByte.Controllers.SystemLogin ctrlSystemLogin = new TechByte.Controllers.SystemLogin();
            ctrlSystemLogin.Login(username, password);
            Guitar32.SystemResponse response = ctrlSystemLogin.getResponse();
            if (response.GetCode() == "00") {
                // Success login
                this.Hide();
                txtUsername.Clear();
                txtPassword.Clear();
                // {{ BLOCK for Session
                SystemUser user = (SystemUser)response.GetData();
                Guitar32.Utilities.Session.Set("CURRENT_USER", user);
                // }}
                FormManager.frmDashboard = new Dashboard();
                FormManager.frmDashboard.ShowDialog(this);
                this.Show();
                txtUsername.Focus();
            }
            else {
                // Login failure
                MessageBox.Show(response.GetMessage());
                txtPassword.Clear();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo);
            if (dialogResult.Equals(DialogResult.Yes)) {
                Application.Exit();
            }
        }


        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) {
                this.Opacity += 0.05;
            }
            else {
                this.Enabled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) 
        {
            BackgroundWorker backWorker = (BackgroundWorker)sender;
            if (TechByte.Configs.DatabaseCredentialsFile.Load()) {
                DatabaseCredentials credentials = TechByte.Configs.DatabaseCredentialsFile.databaseCredentials;
                DatabaseConnection dbConn = new DatabaseConnection(credentials);
                if (this.InvokeRequired) {
                    SetStatusCallback callback = new SetStatusCallback(backgroundWorker1_DoWork);
                    this.Invoke(callback, new object[] {sender, e});
                }
                else {
                    backWorker.ReportProgress(1); // connecting
                    if (dbConn.Connect()) {
                        TechByte.Configs.DatabaseInstance.databaseConnection = dbConn;
                        backWorker.ReportProgress(100); // success
                    }
                    else {
                        backWorker.ReportProgress(2); // unable to connect
                    }
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage) {
                case 1: {
                    linkRetryDB.Hide();
                    lblStatus.ForeColor = lblStatus.Parent.ForeColor;
                    lblStatus.Text = "Connecting";
                    break;
                    }
                case 2: {
                    linkRetryDB.Show();
                    lblStatus.ForeColor = Color.Yellow;
                    lblStatus.Text = "Unable to connect";
                    this.Form1_Ready(false);
                    break;
                    }
                case 100: {
                    linkRetryDB.Hide();
                    lblStatus.ForeColor = Color.SkyBlue;
                    lblStatus.Text = "Connection success. Ready.";
                    this.Form1_Ready(true);
                    break;
                    }
            }
        }

        private void Form1_EnabledChanged(object sender, EventArgs e) {
            backgroundWorker1.RunWorkerAsync();
        }

        private void linkRetryDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            backgroundWorker1.RunWorkerAsync();
        }



    }
}
