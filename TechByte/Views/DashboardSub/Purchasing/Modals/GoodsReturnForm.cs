using Guitar32;
using Guitar32.Data;
using Guitar32.Database;
using Guitar32.Controllers;
using Guitar32.Utilities;
using Guitar32.Utilities.UI;
using Guitar32.Validations;
using Guitar32.Validations.Monitors;
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



namespace TechByte.Views.DashboardSub.Purchasing.Modals
{
    public partial class GoodsReturnForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private int key;
        private TechByte.Architecture.Enums.FormModalTypes type;
        private ComboBind
            cbVendor,
            cbDelivery,
            cbGoodsReceipt;



        public GoodsReturnForm() {
            InitializeComponent();
            this.type = Architecture.Enums.FormModalTypes.CREATE;
        }

        private void GoodsReturnForm_Load(object sender, EventArgs e) {
            InitFormModal();
            this.AddInputMonitor(new InputMonitor(txtDescription, true));
        }

        private void comboVendor_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSaveButton();
        }

        private void comboDelivery_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSaveButton();
        }

        private void comboGoodsReceipt_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSaveButton();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (this.IsSubmittable()) {
                GoodsReturn greturn;
                if (this.type == Architecture.Enums.FormModalTypes.CREATE) {
                    greturn = new GoodsReturn();
                    greturn.setUser((SystemUser)Guitar32.Utilities.Session.Get("CURRENT_USER"));
                    greturn.setVendor(new Company(Integer.Parse(cbVendor.GetValue())));
                    greturn.setDelivery(new Delivery(Integer.Parse(cbDelivery.GetValue())));
                    greturn.setGoodsReceipt(new GoodsReceipt(Integer.Parse(cbGoodsReceipt.GetValue())));
                    greturn.setDescription(new MultiWord(txtDescription.Text.Trim()));
                    bool createSuccess = greturn.CreateData();
                    if (!createSuccess) {
                        MessageBox.Show("Unable to create a Goods Return entry, please try again later");
                        return;
                    }
                    MessageBox.Show("Goods return entry has been successfully created!");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }



        public void UpdateSaveButton() {
            btnSave.Enabled = comboVendor.SelectedIndex >= 0
                && comboDelivery.SelectedIndex >= 0
                && comboGoodsReceipt.SelectedIndex >= 0;
        }

        public void Fetch() {
            if (this.type == Architecture.Enums.FormModalTypes.VIEW) {
                GoodsReturn greturn = new GoodsReturn(this.key);
                cbVendor.SetByValue(greturn.getVendor().getId());
                cbDelivery.SetByValue(greturn.getDelivery().getId());
                cbGoodsReceipt.SetByValue(greturn.getGoodsReceipt().getId());
                txtDescription.Text = greturn.getDescription();
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

            // {{ BLOCK for Combo Vendor
            cbVendor = new ComboBind(ref comboVendor);
            query.Select()
                .From("tblcompanies");
            if (this.type == Architecture.Enums.FormModalTypes.CREATE) {
                query.Where("upper(status)", Strings.Surround("ACTIVE"), true);
            }
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbVendor.AddItem(row["name"].ToString(), Integer.Parse(row["id"]));
            }
            cbVendor.TrySelect(0);
            // }}
            // {{ BLOCK for Combo Delivery
            cbDelivery = new ComboBind(ref comboDelivery);
            query = new QueryBuilder();
            query.Select()
                .From("tbldeliveries");
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbDelivery.AddItem(row["id"].ToString(), Integer.Parse(row["id"]));
            }
            cbDelivery.TrySelect(0);
            // }}
            // {{ BLOCK for Combo GoodsReceipt
            cbGoodsReceipt = new ComboBind(ref comboGoodsReceipt);
            query = new QueryBuilder();
            query.Select()
                .From("tblgreceipts");
            if (this.type == Architecture.Enums.FormModalTypes.CREATE) {
                query.Where("id NOT IN (SELECT greceipt_id FROM tblinvoices) AND "
                    + "id NOT IN (SELECT greceipt_id FROM tblsalesinvoice) AND "
                    + "id NOT IN (SELECT greceipt_id FROM tblgreturns) AND "
                    + "upper(type) = \"OUTGOING\" ");
            }
            result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                cbGoodsReceipt.AddItem(row["id"].ToString(), Integer.Parse(row["id"]));
            }
            cbGoodsReceipt.TrySelect(0);
            // }}

            switch (this.type) {
                case Architecture.Enums.FormModalTypes.CREATE: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                    break;
                    }
                case Architecture.Enums.FormModalTypes.VIEW: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "View");
                    Guitar32.Utilities.UI.Controls.DisableTouch(comboVendor);
                    Guitar32.Utilities.UI.Controls.DisableTouch(comboDelivery);
                    Guitar32.Utilities.UI.Controls.DisableTouch(comboGoodsReceipt);
                    Guitar32.Utilities.UI.Controls.DisableTouch(txtDescription);
                    btnSave.Hide();
                    btnCancel.Text = "Close";
                    this.DisableCloseDetections();
                    Fetch();
                    break;
                    }
            }
            this.Text = lblTitle.Text;
        }
    }
}
