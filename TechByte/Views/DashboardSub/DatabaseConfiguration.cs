using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

using Guitar32.Common;
using Guitar32.Controllers;
using Guitar32.Validations.Monitors;
using Guitar32.Database;


namespace TechByte.Views.DashboardSub
{

    public partial class DatabaseConfiguration : FormController, IMonitorable
    {
        private bool allowClose = false;


        public DatabaseConfiguration() {
            InitializeComponent();
        }

        private void txtPort_KeyDown(object sender, KeyEventArgs e) {
            Char keyChar = Convert.ToChar(e.KeyValue);
            if (!Char.IsDigit(keyChar) && !Char.IsControl(keyChar) && !(e.KeyCode == Keys.Shift)) {
                e.SuppressKeyPress = true;
            }
        }

        private void DatabaseConfiguration_Load(object sender, EventArgs e) {
            if (!TechByte.Configs.DatabaseCredentialsFile.Exists()) {
                btnOk.Enabled = false;
            }
            this.InitializeMonitors();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void DatabaseConfiguration_FormClosing(object sender, FormClosingEventArgs e) {
            if (!this.allowClose) {
                if (!TechByte.Configs.DatabaseCredentialsFile.Exists()) {
                    DialogResult dialogResult = MessageBox.Show(this,
                        "You are required to configure first your database connection first." + Environment.NewLine + "Are you sure you want to exit?",
                        "Confirm exit",
                        MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        this.allowClose = true;
                    }

                    if (this.allowClose) {
                        Application.Exit();
                    }
                }
                else {
                    DialogResult dialogResult = MessageBox.Show(this,
                        "Are you sure you want to exit database configuration?",
                        "Confirm exit",
                        MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) {
                        this.allowClose = true;
                    }
                    if (this.allowClose) {
                        this.Close();
                    }
                }
                e.Cancel = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e) {
            bool isPreconfig = !TechByte.Configs.DatabaseCredentialsFile.Exists();
            DatabaseCredentials credentials = new DatabaseCredentials();
            credentials
                .setServer(txtServer.Text)
                .setPort(uint.Parse(txtPort.Text))
                .setUsername(txtUsername.Text)
                .setPassword(txtPassword.Text);
            if (TechByte.Configs.DatabaseCredentialsFile.CreateNew(credentials)) {
                this.allowClose = true;
                if (isPreconfig) {
                    MessageBox.Show("Credentials have been successfully saved! Application will now restart");
                    Application.Restart();
                }
                else {
                    MessageBox.Show("Credentials have been successfully saved!");
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Something went wrong, please try again");
            }
        }

        private void btnTest_Click(object sender, EventArgs e) {
            if (!this.GetInputMonitors().IsSubmittable()) {
                return;
            }
            if (txtPort.Text.Trim().Length == 0) {
                txtPort.Text = "3306";
            }

            MySqlConnectionStringBuilder connStr = new MySqlConnectionStringBuilder();
            connStr.Server = txtServer.Text;
            connStr.Port = (uint)int.Parse(txtPort.Text);
            connStr.UserID = txtUsername.Text;
            connStr.Password = txtPassword.Text;
            MySqlConnection conn = new MySqlConnection(connStr.GetConnectionString(true));
            bool connSuccess = true;
            try {
                conn.Open();
            }
            catch (MySqlException ex) {
                connSuccess = false;
                MessageBox.Show(String.Format("Connection failed: {0} {1}", ex.ErrorCode, ex.Message));
            }
            if (connSuccess) {
                MessageBox.Show("Connection succeed!");
            }
            btnOk.Enabled = connSuccess;
        }

        public void InitializeMonitors() {
            InputMonitor mServer = new InputMonitor(txtServer, true);
            InputMonitor mUsername = new InputMonitor(txtUsername, true);
            mUsername.SetValidator(Guitar32.Validations.SingleWordAlphaNumeric.expression, Guitar32.Validations.SingleWordAlphaNumeric.message);
            InputMonitor mPassword = new InputMonitor(txtPassword, true);

            this.AddInputMonitor(mServer);
            this.AddInputMonitor(mUsername);
            this.AddInputMonitor(mPassword);
        }

        private void fieldKeyPress(object sender, KeyPressEventArgs e) {
            if (btnOk.Enabled) {
                btnOk.Enabled = false;
            }
        }
    }
}
