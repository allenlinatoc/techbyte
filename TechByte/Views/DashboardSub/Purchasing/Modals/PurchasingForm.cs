using Guitar32.Controllers;
using Guitar32.Data;
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
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Goods;
using TechByte.Architecture.Beans;

namespace TechByte.Views.DashboardSub.Purchasing.Modals
{
    public partial class PurchasingForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private int key;
        private TechByte.Architecture.Enums.FormModalTypes type;
        private ComboBind
            cbVendor,
            cbDelivery,
            cbGreceipt;


        public PurchasingForm() {
            InitializeComponent();
            this.type = Architecture.Enums.FormModalTypes.CREATE;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void PurchasingForm_Load(object sender, EventArgs e) {
            InitFormModal();
        }

        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboDelivery_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboGreceipts_SelectedIndexChanged(object sender, EventArgs e) {
            GoodsReceipt greceipt = new GoodsReceipt(Integer.Parse(cbGreceipt.GetValue()));
            ComputeGross(
                float.Parse(
                    greceipt.getWarehouseEntry().getItemListObject().GetTotalCost().ToString()
                ));
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Architecture.Beans.Purchasing purchasing
                = new Architecture.Beans.Purchasing();
            Invoice invoice = new Invoice();
            invoice.setVendor(new Company(Integer.Parse(cbVendor.GetValue())));
            invoice.setDelivery(new Delivery(Integer.Parse(cbDelivery.GetValue())));
            invoice.setGoodsReceipt(new GoodsReceipt(Integer.Parse(cbGreceipt.GetValue())));
            invoice.setGrossTotal(new Currency(numericGrosstotal.Value.ToString()));
            invoice.setActualTotal(new Currency(numericActualtotal.Value.ToString()));
            invoice.setAmountPaid(new Currency(numericAmountpaid.Value.ToString()));
            invoice.setChange(new Currency(numericChange.Value.ToString()));
            purchasing.setInvoice(invoice);
            if (!purchasing.CreateData()) {
                MessageBox.Show("Failed to create Purchasing entry, please try again later");
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                return;
            }
            MessageBox.Show("Purchasing entry has been successfully created!");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void numericAmountpaid_ValueChanged(object sender, EventArgs e) {
            float change = (float)(numericActualtotal.Value - numericAmountpaid.Value);
            change = change < 0 ? 0 : change;
            numericChange.Value = (decimal)change;
            UpdateSaveButton();
        }


        private void ComputeGross(float grossTotal) {
            numericGrosstotal.Value = (decimal)grossTotal;
            float tax = TechByte.Configs.AppConfig.TaxRate / 100;
            float actualTotal = grossTotal * tax;
            numericActualtotal.Value = Math.Abs((decimal)actualTotal);
        }
        private void UpdateSaveButton() {
            btnSave.Enabled = comboVendor.Items.Count > 0
                && comboDelivery.Items.Count > 0
                && comboGreceipt.Items.Count > 0
                && numericAmountpaid.Value >= numericActualtotal.Value;
        }


        public void Fetch() {
            if (this.type == Architecture.Enums.FormModalTypes.VIEW) {
                Architecture.Beans.Purchasing purchasing
                    = new Architecture.Beans.Purchasing(this.key);
                cbVendor.SetByValue(purchasing.getInvoice().getVendor().getId());
                cbDelivery.SetByValue(purchasing.getInvoice().getDelivery().getId());
                cbGreceipt.SetByValue(purchasing.getInvoice().getGoodsReceipt().getId());
                numericGrosstotal.Value = (decimal)purchasing.getInvoice().getGrossTotal();
                numericActualtotal.Value = (decimal)purchasing.getInvoice().getActualTotal();
                numericAmountpaid.Value = (decimal)purchasing.getInvoice().getAmountPaid();
                numericChange.Value = (decimal)purchasing.getInvoice().getChange();
            }
        }

        public void SetFormModalKey(object key) {
            this.key = Integer.Parse(key);
            this.SetFormModalType(Architecture.Enums.FormModalTypes.VIEW);
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            QueryBuilder query = new QueryBuilder();
            QueryResult result;

            // {{ Combo Vendor
            cbVendor = new ComboBind(ref comboVendor);
            query.Select()
                .From("tblcompanies")
                .Where("upper(type)", Strings.Surround("VENDOR"), true);
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbVendor.AddItem(row["name"].ToString(), row["id"]);
            }
            cbVendor.TrySelect(0);
            // }}
            // {{ Combo Delivery
            cbDelivery = new ComboBind(ref comboDelivery);
            query.Select()
                .From("tbldeliveries")
                .Where("id NOT IN (SELECT delivery_id FROM tblinvoices)");
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbDelivery.AddItem(row["id"].ToString(), row["id"]);
            }
            cbDelivery.TrySelect(0);
            // }}
            // {{ Combo Goods receipt
            cbGreceipt = new ComboBind(ref comboGreceipt);
            query.Select()
                .From("tblgreceipts")
                .Where("id NOT IN (SELECT greceipt_id FROM tblinvoices)");
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbGreceipt.AddItem(row["id"].ToString(), row["id"]);
            }
            cbGreceipt.TrySelect(0);
            // }}
            UpdateSaveButton();

            switch(this.type) {
                case Architecture.Enums.FormModalTypes.CREATE: {
                    this.EnableCloseDetections();
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                    break;
                    }
                case Architecture.Enums.FormModalTypes.VIEW: {
                    btnSave.Hide();
                    btnCancel.Text = "Close";
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "View");
                    this.DisableCloseDetections();
                    break;
                    }
            }
            this.Text = lblTitle.Text;
            this.Fetch();
        }
    }
}
