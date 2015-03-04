﻿using Guitar32.Database;
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
    public partial class GoodsReceipts : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public GoodsReceipts() {
            InitializeComponent();
        }

        private void GoodsReceipts_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.GoodsReceiptsForm modal = new Modals.GoodsReceiptsForm();
            modal.SetFormModalType(Architecture.Enums.FormModalTypes.CREATE);
            DialogResult result = modal.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void LoadData() {
            dgGreceipts.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            Dictionary<string, object> conditions = new Dictionary<string,object>();
            query.Select()
                .From("view_greceipts, view_users")
                .Where("greceipt_user_id", "user_id")
            ;
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                
                // Get items
                int greceipt_id = Integer.Parse(row["greceipt_id"]);
                query = new QueryBuilder();
                query.Select()
                    .From("view_s_fullwarehouse")
                    .Where("greceipt_id", greceipt_id);
                QueryResult resultItems = dbConn.Query(query);
                List<string> listSummary = new List<string>();
                for (int j = 0; j < resultItems.RowCount(); j++) {
                    QueryResultRow rowItem = resultItems.GetSingle(j);
                    listSummary.Add(String.Format("{0}x {1}"
                        , rowItem["warehouselist_quantity"].ToString()
                        , rowItem["good_name"].ToString()));
                }

                dgGreceipts.Rows.Add(new object[] {
                    row["greceipt_id"].ToString(),
                    row["user_username"].ToString(),
                    row["greceipt_warehouse_id"].ToString(),
                    row["greceipt_created"].ToString(),
                    row["greceipt_type"].ToString(),
                    resultItems.RowCount().ToString(),
                    String.Join(" | ", listSummary.ToArray())
                });
            }
            DataGridViews.SelectIndex(0, ref dgGreceipts);
        }

    }
}
