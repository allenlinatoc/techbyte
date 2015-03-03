using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Configs;
using TechByte.Values;
using TechByte.Architecture.Validations;

namespace TechByte.Views.DashboardSub.Admin
{
    public partial class SystemConfiguration : Form
    {
        private DatabaseConnection dbConn = DatabaseInstance.databaseConnection;
        private Boolean 
            isTaxChanged = false,
            isLockdownChanged = false,
            isUI_BackColorChanged = false
        ;


        public SystemConfiguration() {
            InitializeComponent();
        }

        private void SystemConfiguration_Load(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;

            String windowTitle = this.Text;
            this.Enabled = false;
            this.Text = "Loading System Configuration";

            // Load configuration
            AppConfig.Reinitialize();
            // Modules
            checkAdmin.Checked = AppConfig.Modules.Contains("ADMIN");
            checkHR.Checked = AppConfig.Modules.Contains("HUMANRESOURCE");
            checkPurchasing.Checked = AppConfig.Modules.Contains("ACCOUNTING");
            checkSales.Checked = AppConfig.Modules.Contains("SALES");
            checkClerk.Checked = AppConfig.Modules.Contains("CLERK");
            // System lock-down status
            comboLockdown.SelectedIndex = AppConfig.IsSystemLockdown ? 1 : 0;
            // Tax-rate
            txtTaxrate.Text = AppConfig.TaxRate.ToString();
            // UI
            btnChangeBackcolor.BackColor = AppConfig.UI.DashboardBackColor;

            this.Text = windowTitle;
            this.Enabled = true;
        }

        private void btnChangeBackcolor_Click(object sender, EventArgs e) {
            DialogResult result = colorDialog1.ShowDialog(this);
            if (result.Equals(DialogResult.OK)) {
                ((Button)sender).BackColor = colorDialog1.Color;
                this.isUI_BackColorChanged = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to exit configuration?", "Confirm exit", MessageBoxButtons.YesNoCancel);
            if (result.Equals(DialogResult.Yes)) {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            // Check each modules un/checked
            QueryBuilder query = new QueryBuilder();
            Dictionary<string, string> checkStatuses = new Dictionary<string, string>();
            checkStatuses.Add("ADMIN", checkAdmin.Checked ? "ACTIVE" : "INACTIVE");
            checkStatuses.Add("HUMANRESOURCE", checkHR.Checked ? "ACTIVE" : "INACTIVE");
            checkStatuses.Add("ACCOUNTING", checkPurchasing.Checked ? "ACTIVE" : "INACTIVE");
            checkStatuses.Add("SALES", checkSales.Checked ? "ACTIVE" : "INACTIVE");
            checkStatuses.Add("CLERK", checkClerk.Checked ? "ACTIVE" : "INACTIVE");
            foreach (KeyValuePair<string, string> kv in checkStatuses) {
                query.Update("tblmodules")
                    .Set("status", Strings.Surround(kv.Value))
                    .Where("upper(`key`) = " + Strings.Surround(kv.Key.ToUpper()));
                if (!dbConn.Execute(query)) {
                    return;
                }
            }

            // Update Tax rate on-change
            if (this.isTaxChanged) {
                Numeric valTax = new Numeric("");
                try {
                    valTax = new Numeric(txtTaxrate.Text.Trim(), true);
                }
                catch (Exception ex) {
                    MessageBox.Show("Invalid value in tax");
                    return;
                }
                query.Update("tblconfiguration")
                    .Set("value", valTax.getValue().ToString())
                    .Where("upper(`key`) = " + Strings.Surround("GR_TAX"));
                if (!dbConn.Execute(query)) {
                    return;
                }
            }
            
            // Update System lock down status
            if (this.isLockdownChanged) {
                query.Update("tblconfiguration")
                    .Set("`value`", Strings.Surround(comboLockdown.SelectedItem.ToString().ToUpper()))
                    .Where("`key` = \"SYS_LOCKDOWN\"");
                Console.WriteLine(query.getQueryString());
                if (!dbConn.Execute(query)) {
                    return;
                }
            }
            
            // Update UI settings
            if (this.isUI_BackColorChanged) {
                String UI_BackColor = btnChangeBackcolor.BackColor.ToArgb().ToString();
                query.Update("tblconfiguration")
                    .Set("`value`", Strings.Surround(UI_BackColor))
                    .Where("upper(`key`) = \"UI_BACKCOLOR\"");
                if (!dbConn.Execute(query)) {
                    return;
                }
            }
            
            AppConfig.Reinitialize();
            MessageBox.Show("Changes have been successfully saved!");
            
                foreach (Control ctrl in this.MdiParent.Controls) {
                    if (ctrl is MdiClient) {
                        ctrl.BackColor = AppConfig.UI.DashboardBackColor;
                        break;
                    }
                }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            this.isTaxChanged = true;
        }

        private void comboLockdown_SelectedIndexChanged(object sender, EventArgs e) {
            this.isLockdownChanged = true;
        }
    }
}
