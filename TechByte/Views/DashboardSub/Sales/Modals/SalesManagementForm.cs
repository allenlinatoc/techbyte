using Guitar32.Controllers;
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
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Goods;
using TechByte.Architecture.Beans.Warehouse;


namespace TechByte.Views.DashboardSub.Sales.Modals
{
    public partial class SalesManagementForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private int key;
        private TechByte.Architecture.Enums.FormModalTypes type;
        private ComboBind cbGreceipt;


        public SalesManagementForm() {
            InitializeComponent();
            this.type = Architecture.Enums.FormModalTypes.CREATE;
        }

        private void SalesManagementForm_Load(object sender, EventArgs e) {
            InitFormModal();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Architecture.Beans.Sales sales = new Architecture.Beans.Sales();
            SalesInvoice salesInvoice = new SalesInvoice();
            salesInvoice.setUser((Architecture.Beans.Accounts.SystemUser)Guitar32.Utilities.Session.Get("CURRENT_USER"));
            salesInvoice.setGoodsReceipt(new GoodsReceipt(Integer.Parse(cbGreceipt.GetValue())));
            salesInvoice.setGrossTotal(new Currency(numericGrosstotal.Value.ToString()));
            salesInvoice.setActualTotal(new Currency(numericActualtotal.Value.ToString()));
            salesInvoice.setAmountPaid(new Currency(numericAmountpaid.Value.ToString()));
            salesInvoice.setChange(new Currency(numericChange.Value.ToString()));
            sales.setSalesInvoice(salesInvoice);
            if (!sales.CreateData()) {
                MessageBox.Show("Unable to create Sales entry, please try again later");
                return;
            }
            MessageBox.Show("Sales entry has been successfully created!");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void numericGrosstotal_ValueChanged(object sender, EventArgs e) {

        }

        private void numericActualtotal_ValueChanged(object sender, EventArgs e) {

        }

        private void numericAmountpaid_ValueChanged(object sender, EventArgs e) {
            decimal change = numericAmountpaid.Value < numericActualtotal.Value ? 0 : (numericAmountpaid.Value - numericActualtotal.Value);
            numericChange.Value = change;
            btnSave.Enabled = numericAmountpaid.Value >= numericActualtotal.Value;
        }

        private void numericChange_ValueChanged(object sender, EventArgs e) {

        }




        public void Fetch() {

        }

        public void SetFormModalKey(object key) {
            this.key = Integer.Parse(key);
            this.SetFormModalType(Architecture.Enums.FormModalTypes.VIEW);
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            cbGreceipt = new ComboBind(ref comboGreceipt);
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblgreceipts");
            if (this.type == Architecture.Enums.FormModalTypes.CREATE) {
                query.Where("id NOT IN (SELECT greceipt_id FROM tblinvoices) AND "
                + "id NOT IN (SELECT greceipt_id FROM tblsalesinvoice) AND "
                + "upper(type) = " + Strings.Surround("OUTGOING"));
            }
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbGreceipt.AddItem(row["id"].ToString(), Integer.Parse(row["id"]));
            }
            cbGreceipt.TrySelect(0);


            switch (this.type) {
                case Architecture.Enums.FormModalTypes.CREATE: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                    this.EnableCloseDetections();
                    break;
                    }
                case Architecture.Enums.FormModalTypes.VIEW: {
                    btnCancel.Text = "Close";
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "View");
                    Guitar32.Utilities.UI.Controls.DisableTouch(comboGreceipt);
                    Guitar32.Utilities.UI.Controls.DisableTouch(numericAmountpaid);
                    this.DisableCloseDetections();
                    this.Fetch();
                    break;
                    }
            }

            // Disable some controls
            Guitar32.Utilities.UI.Controls.DisableTouch(numericGrosstotal);
            Guitar32.Utilities.UI.Controls.DisableTouch(numericActualtotal);
            Guitar32.Utilities.UI.Controls.DisableTouch(numericChange);

            this.Text = lblTitle.Text;

        }


        private void comboGreceipt_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboGreceipt.Items.Count > 0 && comboGreceipt.SelectedIndex >= 0) {
                int greceiptId = Integer.Parse(cbGreceipt.GetValue());
                GoodsReceipt greceipt = new GoodsReceipt(greceiptId);
                float grossTotal = greceipt.getWarehouseEntry().getItemListObject().GetTotalCost();
                float actualTotal = grossTotal + (grossTotal * (float.Parse(TechByte.Configs.AppConfig.TaxRate.ToString())/100));
                numericGrosstotal.Value = decimal.Parse(grossTotal.ToString());
                numericActualtotal.Value = decimal.Parse(actualTotal.ToString());
            }
        }



    }
}
