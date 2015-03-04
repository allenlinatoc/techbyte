using Guitar32.Controllers;
using Guitar32.Data;
using Guitar32.Database;
using Guitar32.Utilities;
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
using TechByte.Architecture;
using TechByte.Architecture.Beans.Business;
using TechByte.Architecture.Beans.Goods;


namespace TechByte.Views.DashboardSub.Clerk.Modals
{
    public partial class GoodsForm : FormController, Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private Architecture.Enums.FormModalTypes type;
        private int key;

        private ComboBind 
            comboBind_Vendor,
            comboBind_Category
        ;


        public GoodsForm() {
            InitializeComponent();
            this.type = Architecture.Enums.FormModalTypes.CREATE;
        }

        private void GoodsForm_Load(object sender, EventArgs e) {
            QueryBuilder query = new QueryBuilder();
            QueryResult result;

            // Check for existing "VENDOR" Companies
            query.Select()
                .From("tblcompanies")
                .Where("upper(type)", Strings.Surround("VENDOR"), true);
            result = dbConn.Query(query);
            if (result.IsEmpty()) {
                MessageBox.Show("You have no \"vendor\" companies yet. Please contact admin for further assistance");
                this.DisableCloseDetections();
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }

            InitFormModal();
            // Initialize combo boxes
            comboBind_Category = new ComboBind(ref comboCategory);
            query.Select()
                .From("tblgoodscategories");
            result = dbConn.Query(query);
            comboBind_Category.ClearItems();
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                comboBind_Category.AddItem(row["name"].ToString(), Integer.Parse(row["id"]));
            }
            comboBind_Category.TrySelect(0);
            // END of Category
            comboBind_Vendor = new ComboBind(ref comboVendor);
            query.Select()
                .From("tblcompanies")
                .Where("upper(type)", Strings.Surround("VENDOR"), true);
            result = dbConn.Query(query);
            comboBind_Vendor.ClearItems();
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                comboBind_Vendor.AddItem(row["name"].ToString(), Integer.Parse(row["id"]));
            }
            comboBind_Vendor.TrySelect(0);

            Fetch();

            // Add monitors
            this.AddInputMonitor(new InputMonitor(txtGood_Name, true));
        }



        private void btnSave_Click(object sender, EventArgs e) {
            if (this.IsSubmittable()) {
                Good good;
                if (this.type == Architecture.Enums.FormModalTypes.CREATE) {
                    // Create
                    good = new Good();
                    good.setVendor(new Company(Integer.Parse(comboBind_Vendor.GetValue())));
                    good.setGoodsCategory(new GoodsCategory(Integer.Parse(comboBind_Category.GetValue())));
                    good.setName(new MultiWord(txtGood_Name.Text));
                    good.setDescription(new MultiWord(txtGood_Description.Text));
                    good.setPrice(new Currency(numericGood_Price.Value.ToString()));
                    bool goodCreateSuccess = good.CreateData();
                    if (!goodCreateSuccess) {
                        MessageBox.Show("Unable to create product, please check your connection and try again");
                        return;
                    }
                    MessageBox.Show("\"" + good.getName() + "\" has been successfully created!");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.DisableCloseDetections();
                    this.Close();
                }
                else {
                    // Update
                    good = new Good(this.key);
                    good.setVendor(new Company(Integer.Parse(comboBind_Vendor.GetValue())));
                    good.setGoodsCategory(new GoodsCategory(Integer.Parse(comboBind_Category.GetValue())));
                    good.setName(new MultiWord(txtGood_Name.Text));
                    good.setDescription(new MultiWord(txtGood_Description.Text));
                    good.setPrice(new Currency(numericGood_Price.Value.ToString()));
                    bool goodUpdateSuccess = good.Update();
                    if (!goodUpdateSuccess) {
                        MessageBox.Show("Unable to save changes, please check your connection and try again");
                        return;
                    }
                    MessageBox.Show("Changes have been successfully created!");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        public void Fetch() {
            if (this.type == Architecture.Enums.FormModalTypes.UPDATE) {
                Good good = new Good(this.key);
                comboBind_Category.SetByValue(good.getGoodsCategory().getId());
                comboBind_Vendor.SetByValue(good.getVendor().getId());
                txtGood_Name.Text = good.getName();
                txtGood_Description.Text = good.getDescription();
                numericGood_Price.Value = (decimal)good.getPrice();
            }
        }

        public void SetFormModalKey(object key) {
            this.key = Integer.Parse(key);
            this.SetFormModalType(Architecture.Enums.FormModalTypes.UPDATE);
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            switch (this.type) {
                case Architecture.Enums.FormModalTypes.CREATE: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                    this.EnableCloseDetections();
                    break;
                    }
                case Architecture.Enums.FormModalTypes.UPDATE: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "Edit");
                    this.DisableCloseDetections();
                    break;
                    }
            }
            this.Text = lblTitle.Text;
        }
    }
}
