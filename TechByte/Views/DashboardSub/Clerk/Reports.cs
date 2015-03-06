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

namespace TechByte.Views.DashboardSub.Clerk
{
    public partial class Reports : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private ComboBind cbCategory;


        public Reports() {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e) {
            cbCategory = new ComboBind(ref comboCategory);
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblgoodscategories");
            QueryResult result = dbConn.Query(query);
            cbCategory.AddItem("-- All --", "-1");
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbCategory.AddItem(row["name"].ToString(), Integer.Parse(row["id"]));
            }
            cbCategory.TrySelect(0);
        }

        public void LoadData(int categoryId = -1) {
            dgGoods.Rows.Clear();
            if (comboCategory.Items.Count >= 2) {
                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("view_s_fullgoods");
                if (categoryId >= 0) {
                    query.Where("goodscategory_id", categoryId);
                }
                QueryResult result = dbConn.Query(query);
                for (int i = 0; i < result.RowCount(); i++) {
                    QueryResultRow row = result.GetSingle(i);
                    int stock = TechByte.Architecture.Beans.Warehouse.WarehouseEntryItemList.CountStocks(Integer.Parse(row["good_id"]));
                    dgGoods.Rows.Add(new object[] {
                        row["good_id"].ToString(),
                        row["good_name"].ToString(),
                        row["company_name"].ToString(),
                        stock.ToString()
                    });
                    if (stock < 10) {
                        dgGoods.Rows[dgGoods.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                        dgGoods.Rows[dgGoods.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
                DataGridViews.SelectIndex(0, ref dgGoods);
            }
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            LoadData(int.Parse(cbCategory.GetValue().ToString()));
        }
    }
}
