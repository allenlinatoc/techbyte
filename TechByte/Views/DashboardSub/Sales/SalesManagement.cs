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
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Business;



namespace TechByte.Views.DashboardSub.Sales
{
    public partial class SalesManagement : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public SalesManagement() {
            InitializeComponent();
        }

        private void SalesManagement_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.SalesManagementForm modal = new Modals.SalesManagementForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void LoadData() {
            dgSales.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("view_sales, view_salesinvoice")
                .Where("salesinvoice_id", "sales_invoice_id");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                SystemUser user = new SystemUser(Integer.Parse(row["salesinvoice_user_id"]));
                dgSales.Rows.Add(new object[] {
                    row["sales_id"].ToString(),
                    user.getUsername(),
                    row["salesinvoice_greceipt_id"].ToString(),
                    row["salesinvoice_grosstotal"].ToString(),
                    row["salesinvoice_actualtotal"].ToString(),
                    row["salesinvoice_amountpaid"].ToString(),
                    row["salesinvoice_change"].ToString()
                });
            }
            DataGridViews.SelectIndex(0, ref dgSales);
        }

        private void btnView_Click(object sender, EventArgs e) {
            Modals.SalesManagementForm modal = new Modals.SalesManagementForm();
            int salesId = Integer.Parse(DataGridViews.GetSelectedValue("ID", ref dgSales));
            modal.SetFormModalKey(salesId);
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void dgSales_SelectionChanged(object sender, EventArgs e) {
            btnView.Visible = dgSales.Rows.Count > 0 && dgSales.SelectedRows.Count > 0;
        }

        private void dgSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            btnView_Click(btnView, null);
        }


    }
}
