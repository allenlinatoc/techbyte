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
using TechByte.Architecture.Beans.Goods;



namespace TechByte.Views.DashboardSub.Purchasing
{
    public partial class GoodsReturnMgmt : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public GoodsReturnMgmt() {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.GoodsReturnForm modal = new Modals.GoodsReturnForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void LoadData() {
            dgGoodsReturns.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblgreturns");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                GoodsReturn greturn = new GoodsReturn(Integer.Parse(row["id"]));
                dgGoodsReturns.Rows.Add(new object[] {
                    greturn.getId().ToString(),
                    greturn.getUser().getUsername(),
                    greturn.getVendor().getName(),
                    greturn.getGoodsReceipt().getId().ToString(),
                    greturn.getDescription()
                });
            }
        }

        private void dgGoodsReturns_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgGoodsReturns.Rows.Count > 0 && dgGoodsReturns.SelectedRows.Count > 0) {
                Modals.GoodsReturnForm modal = new Modals.GoodsReturnForm();
                modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgGoodsReturns));
                modal.ShowDialog();
            }
        }

        private void btnView_Click(object sender, EventArgs e) {
            if (dgGoodsReturns.Rows.Count > 0 && dgGoodsReturns.SelectedRows.Count > 0) {
                Modals.GoodsReturnForm modal = new Modals.GoodsReturnForm();
                modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgGoodsReturns));
                modal.ShowDialog();
            }
        }

        private void dgGoodsReturns_SelectionChanged(object sender, EventArgs e) {
            btnView.Visible = dgGoodsReturns.Rows.Count > 0 && dgGoodsReturns.SelectedRows.Count > 0;
        }

        private void GoodsReturnMgmt_Load(object sender, EventArgs e) {
            LoadData();
        }


    }
}
