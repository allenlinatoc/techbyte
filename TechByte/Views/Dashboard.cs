using Guitar32.Database;
using Guitar32.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Configs;
using TechByte.Views.DashboardSub;

namespace TechByte.Views
{
    public partial class Dashboard : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        

        public Dashboard() {
            InitializeComponent();
            this.Text = "TECH|Byte Dashboard";
        }


        public void UpdateUI() {
            foreach (Control ctrl in this.Controls) {
                if (ctrl is MdiClient) {
                    ctrl.BackColor = AppConfig.UI.DashboardBackColor;
                    break;
                }
            }
            // Analyze active modules and disable inactive
            string[] activeModules = AppConfig.Modules;
            string[] allModules = AppConfig.AllModules;

            foreach (string module in activeModules) {
                Console.WriteLine(module);
            }

            SystemUser user = (SystemUser)Guitar32.Utilities.Session.Get("CURRENT_USER");
            if (!user.getPower().Equals("ADMIN")) {
                administrationToolStripMenuItem.Enabled = activeModules.Contains(Privileges.GetKey("Admin"));
                humanResourceToolStripMenuItem.Enabled = activeModules.Contains(Privileges.GetKey("Human Resource"));
                purchasingToolStripMenuItem.Enabled = activeModules.Contains(Privileges.GetKey("Accounting"));
                salesToolStripMenuItem.Enabled = activeModules.Contains(Privileges.GetKey("Sales"));
                clerkToolStripMenuItem.Enabled = activeModules.Contains(Privileges.GetKey("Clerk"));
                Console.WriteLine(Privileges.GetKey("Human Resource"));
                // Hide inallowed modules
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblpowers")
                    .Where("upper(name)", Strings.Surround(user.getPower()), true);
                QueryResultRow row = dbConn.QuerySingle(query);
                string[] givenModules = row["modules"].ToString().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                List<string> hiddenModules = new List<string>();
                foreach (string amod in allModules) {
                    if (!givenModules.Contains(amod)) {
                        hiddenModules.Add(amod);
                    }
                }
                string[] tmparr = hiddenModules.ToArray();
                administrationToolStripMenuItem.Visible = !tmparr.Contains(Privileges.GetKey("Admin"));
                humanResourceToolStripMenuItem.Visible = !tmparr.Contains(Privileges.GetKey("Human Resource"));
                purchasingToolStripMenuItem.Visible = !tmparr.Contains(Privileges.GetKey("Accounting"));
                salesToolStripMenuItem.Visible = !tmparr.Contains(Privileges.GetKey("Sales"));
                clerkToolStripMenuItem.Visible = !tmparr.Contains(Privileges.GetKey("Clerk"));
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
                // Logout session
                if (Guitar32.Utilities.Session.IsSet("CURRENT_USER")) {
                    Guitar32.Utilities.Session.Unset("CURRENT_USER");
                }
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

        // ADMIN: business partners
        private void businessPartnersToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Admin.BusinessPartners frmBusinessPartners
                = new DashboardSub.Admin.BusinessPartners();
            frmBusinessPartners.MdiParent = this;
            frmBusinessPartners.Show();
        }

        // HR: employee master data
        private void employeeMasterDataToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.HR.Employees frmEmployees
                = new DashboardSub.HR.Employees();
            frmEmployees.MdiParent = this;
            frmEmployees.Show();
        }

        // CLERK: Management of goods
        private void goodsManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            Views.DashboardSub.Clerk.Goods frmGoods =
                new DashboardSub.Clerk.Goods();
            frmGoods.MdiParent = this;
            frmGoods.Show();
        }

        // CLERK: Management of goods categories
        private void goodsCategoryManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Clerk.GoodsCategories frmGoodsCategories
                = new DashboardSub.Clerk.GoodsCategories();
            frmGoodsCategories.MdiParent = this;
            frmGoodsCategories.Show();
        }

        // CLERK: View warehouse reports
        private void warehouseReportsToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Clerk.Reports frmReports
                = new DashboardSub.Clerk.Reports();
            frmReports.MdiParent = this;
            frmReports.Show();
        }

        // CLERK: Management of Goods Receipt
        private void goodsReceiptToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Clerk.GoodsReceipts frmGoodsReceipts
                = new DashboardSub.Clerk.GoodsReceipts();
            frmGoodsReceipts.MdiParent = this;
            frmGoodsReceipts.Show();
        }

        // CLERK: Management of Delivery/Logistics
        private void deliveryManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Clerk.DeliveryLogistics frmDeliveries
                = new DashboardSub.Clerk.DeliveryLogistics();
            frmDeliveries.MdiParent = this;
            frmDeliveries.Show();
        }

        // PURCHASING: Management of purchasing entries
        private void itemPurchasingManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Purchasing.Purchasings frmPurchasings
                = new DashboardSub.Purchasing.Purchasings();
            frmPurchasings.MdiParent = this;
            frmPurchasings.Show();
        }

        // PURCHASING: Purchasing invoice management
        private void invoiceManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Purchasing.APInvoices frmAPInvoices
                = new DashboardSub.Purchasing.APInvoices();
            frmAPInvoices.MdiParent = this;
            frmAPInvoices.Show();
        }

        // PURCHASING: Goods return
        private void goodsReturnToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Purchasing.GoodsReturnMgmt frmGoodsReturnMgmt
                = new DashboardSub.Purchasing.GoodsReturnMgmt();
            frmGoodsReturnMgmt.MdiParent = this;
            frmGoodsReturnMgmt.StartPosition = FormStartPosition.CenterScreen;
            frmGoodsReturnMgmt.Show();
        }

        // SALES: Promo management
        private void promoManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Sales.PromoManagement frmPromoManagement
                = new DashboardSub.Sales.PromoManagement();
            frmPromoManagement.MdiParent = this;
            frmPromoManagement.StartPosition = FormStartPosition.CenterScreen;
            frmPromoManagement.Show();
        }

        // SALES: Sales management
        private void itemSalesManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Sales.SalesManagement frmSalesManagement
                = new DashboardSub.Sales.SalesManagement();
            frmSalesManagement.MdiParent = this;
            frmSalesManagement.StartPosition = FormStartPosition.CenterScreen;
            frmSalesManagement.Show();
        }

        // SALES: AR Invoice report
        private void aRInvoiceManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            TechByte.Views.DashboardSub.Sales.ARInvoices frmARInvoices
                = new DashboardSub.Sales.ARInvoices();
            frmARInvoices.MdiParent = this;
            frmARInvoices.StartPosition = FormStartPosition.CenterScreen;
            frmARInvoices.Show();
        }


    }
}
