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
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Goods;

namespace TechByte.Views.DashboardSub.Clerk
{
    public partial class DeliveryLogistics : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public DeliveryLogistics() {
            InitializeComponent();
        }

        private void DeliveryLogistics_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void LoadData() {
            dgDeliveries.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tbldeliveries");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                SystemUser user = new SystemUser(Integer.Parse(row["user_id"]));
                Company company = new Company(Integer.Parse(row["logistic_id"]));
                GoodsReceipt greceipt = new GoodsReceipt(Integer.Parse(row["greceipt_id"]));
                dgDeliveries.Rows.Add(new object[] {
                    row["id"].ToString(),
                    user.getUsername(),
                    company.getName(),
                    greceipt.getId().ToString(),
                    row["created"].ToString(),
                    greceipt.getWarehouseEntry().getItemList().Length.ToString()
                });
            }
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.DeliveryLogisticsForm modal = new Modals.DeliveryLogisticsForm();
            modal.SetFormModalType(Architecture.Enums.FormModalTypes.CREATE);
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }
    }
}
