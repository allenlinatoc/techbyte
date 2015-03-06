using Guitar32.Controllers;
using Guitar32.Common;
using Guitar32.Data;
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
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Goods;


namespace TechByte.Views.DashboardSub.Clerk.Modals
{
    public partial class DeliveryLogisticsForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private TechByte.Architecture.Enums.FormModalTypes type;
        private ComboBind
            cbLogistics,
            cbGreceipts;


        public DeliveryLogisticsForm() {
            InitializeComponent();
        }

        private void DeliveryLogisticsForm_Load(object sender, EventArgs e) {
            InitFormModal();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Delivery delivery = new Delivery();
            Console.WriteLine(System.DateTime.Now);
            Console.WriteLine(Guitar32.Validations.DateTime.CreateFromNativeDateTime(System.DateTime.Now, true).getValue());
            delivery.setCreationDate(Guitar32.Validations.DateTime.CreateFromNativeDateTime(System.DateTime.Now, true));
            delivery.setUser((TechByte.Architecture.Beans.Accounts.SystemUser)
                Guitar32.Utilities.Session.Get("CURRENT_USER"));
            delivery.setGoodsReceipt(
                new GoodsReceipt(Integer.Parse(cbGreceipts.GetValue())));
            delivery.setLogistic(
                new Architecture.Beans.Business.Company(Integer.Parse(cbLogistics.GetValue())));
            if (!delivery.CreateData()) {
                MessageBox.Show("Unable to create Delivery entry, please try again later");
                return;
            }
            MessageBox.Show("Delivery entry has been successfully created!");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        public void Fetch() {
            throw new NotImplementedException();
        }

        public void SetFormModalKey(object key) {
            throw new NotImplementedException();
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            QueryBuilder query = new QueryBuilder();
            QueryResult result;

            // Combo Logistics
            cbLogistics = new ComboBind(ref comboLogistics);
            query.Select()
                .From("tblcompanies")
                .Where("upper(type)", Strings.Surround("LOGISTICS"), true);
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbLogistics.AddItem(row["name"].ToString(), Integer.Parse(row["id"]));
            }
            cbLogistics.TrySelect(0);

            // Combo Goods Receipts
            cbGreceipts = new ComboBind(ref comboGreceipts);
            query = new QueryBuilder(
                "SELECT * "
                + "FROM view_greceipts "
                + "WHERE greceipt_id NOT IN (SELECT greceipt_id FROM tbldeliveries) AND "
                    + "upper(greceipt_type) = \"INCOMING\"");
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbGreceipts.AddItem(row["greceipt_id"].ToString(), Integer.Parse(row["greceipt_id"]));
            }
            cbGreceipts.TrySelect(0);

            btnSave.Enabled = cbGreceipts.getControl().Items.Count > 0 && cbLogistics.getControl().Items.Count > 0;
            switch (this.type) {
                case Architecture.Enums.FormModalTypes.CREATE: {
                    this.EnableCloseDetections();
                    break;
                    }
            }
        }
    }
}
