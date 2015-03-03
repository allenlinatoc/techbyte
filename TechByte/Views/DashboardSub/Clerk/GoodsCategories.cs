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

namespace TechByte.Views.DashboardSub.Clerk
{
    public partial class GoodsCategories : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;



        public GoodsCategories() {
            InitializeComponent();
        }

        private void GoodsCategories_Load(object sender, EventArgs e) {
            LoadData();
        }

        public void LoadData() {
            dgGoodsCategories.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("view_goodscategories");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                dgGoodsCategories.Rows.Add(new object[] {
                    row["goodscategory_id"].ToString(),
                    row["goodscategory_name"].ToString(),
                    row["goodscategory_description"].ToString()
                });
            }
            DataGridViews.SelectIndex(0, ref dgGoodsCategories);
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.GoodsCategoriesForm modal = new Modals.GoodsCategoriesForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            Modals.GoodsCategoriesForm modal = new Modals.GoodsCategoriesForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgGoodsCategories));
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void dgGoodsCategories_SelectionChanged(object sender, EventArgs e) {
            btnEdit.Visible = dgGoodsCategories.SelectedRows.Count > 0;
        }

        private void dgGoodsCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Modals.GoodsCategoriesForm modal = new Modals.GoodsCategoriesForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgGoodsCategories));
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

    }
}
