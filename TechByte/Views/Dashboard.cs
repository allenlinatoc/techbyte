using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Configs;
using TechByte.Views.DashboardSub;

namespace TechByte.Views
{
    public partial class Dashboard : Form
    {

        public Dashboard() {
            InitializeComponent();
        }


        public void UpdateUI() {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is MdiClient) {
                    ctrl.BackColor = AppConfig.UI.DashboardBackColor;
                    break;
                }
            }
        }


        private void Dashboard_Load(object sender, EventArgs e) {
            AppConfig.Initialize();
            UpdateUI();
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result =
                MessageBox.Show("Are you sure you want to exit this session?", "Confirm exit", MessageBoxButtons.YesNo);
            if (result != System.Windows.Forms.DialogResult.Yes) {
                e.Cancel = true;
            }
        }


        private void systemConfigurationToolStripMenuItem_Click(object sender, EventArgs e) {
            Views.DashboardSub.Admin.SystemConfiguration
                systemConfiguration = new DashboardSub.Admin.SystemConfiguration();
            systemConfiguration.MdiParent = this;
            systemConfiguration.Show();
        }


        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Admin.UserManagement frmUserManagement = 
                new TechByte.Views.DashboardSub.Admin.UserManagement();
            frmUserManagement.MdiParent = this;
            frmUserManagement.Show();
        }

        private void businessPartnersToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Admin.BusinessPartners frmBusinessPartners
                = new DashboardSub.Admin.BusinessPartners();
            frmBusinessPartners.MdiParent = this;
            frmBusinessPartners.Show();
        }

        private void employeeMasterDataToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.HR.Employees frmEmployees
                = new DashboardSub.HR.Employees();
            frmEmployees.MdiParent = this;
            frmEmployees.Show();
        }
    }
}
