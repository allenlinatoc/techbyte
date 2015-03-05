using Guitar32.Data;
using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Utilities.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Business;



namespace TechByte.Views.DashboardSub.Purchasing
{
    public partial class APInvoices : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public APInvoices() {
            InitializeComponent();
        }

        private void APInvoices_Load(object sender, EventArgs e) {
            LoadData();
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadData() {
            dgAPInvoices.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            Dictionary<object, object> conditions = new Dictionary<object, object>();
            conditions.Add("upper(invoice_type)", Strings.Surround("PAYABLE"));
            conditions.Add("purchasing_invoice_id", "invoice_id");
            query.Select()
                .From("view_invoices, view_purchasings")
                .Where(conditions, true);
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                SystemUser user = new SystemUser(Integer.Parse(row["invoice_user_id"]));
                Company vendor = new Company(Integer.Parse(row["invoice_vendor_id"]));

                dgAPInvoices.Rows.Add(new object[] {
                    row["invoice_id"].ToString(),
                    user.getUsername(),
                    vendor.getName(),
                    row["invoice_delivery_id"].ToString(),
                    row["purchasing_id"].ToString(),
                    row["invoice_greceipt_id"].ToString(),
                    row["invoice_grosstotal"].ToString(),
                    row["invoice_actualtotal"].ToString(),
                    row["invoice_amountpaid"].ToString(),
                    row["invoice_change"].ToString()
                });
            }

            DataGridViews.SelectIndex(0, ref dgAPInvoices);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dgAPInvoices.SelectedRows.Count > 0) {
                Modals.PurchasingForm modal = new Modals.PurchasingForm();
                modal.SetFormModalKey(DataGridViews.GetSelectedValue("Purchase ID", ref dgAPInvoices));
                modal.ShowDialog();
            }
        }

        private void dgAPInvoices_SelectionChanged(object sender, EventArgs e) {
            btnEdit.Visible = dgAPInvoices.SelectedRows.Count > 0;
        }

        private void dgAPInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgAPInvoices.SelectedRows.Count > 0) {
                Modals.PurchasingForm modal = new Modals.PurchasingForm();
                modal.SetFormModalKey(DataGridViews.GetSelectedValue("Purchase ID", ref dgAPInvoices));
                modal.ShowDialog();
            }
        }



    }
}
