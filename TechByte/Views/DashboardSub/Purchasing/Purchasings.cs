using Guitar32.Data;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Utilities.UI;
using Guitar32.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Business;


namespace TechByte.Views.DashboardSub.Purchasing
{
    public partial class Purchasings : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public Purchasings() {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.PurchasingForm modal = new Modals.PurchasingForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        public void LoadData() {
            dgPurchasings.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("view_invoices, view_purchasings")
                .Where("purchasing_invoice_id", "invoice_id");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                Company company = new Company(Integer.Parse(row["invoice_vendor_id"]));
                SystemUser user = new SystemUser(Integer.Parse(row["invoice_user_id"]));
                dgPurchasings.Rows.Add(new object[] {
                    company.getName(),
                    row["invoice_delivery_id"].ToString(),
                    user.getUsername(),
                    row["invoice_amountpaid"].ToString()
                });
            }
            DataGridViews.SelectIndex(0, ref dgPurchasings);
        }
    }
}
