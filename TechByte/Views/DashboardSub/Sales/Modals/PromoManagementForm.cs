using Guitar32.Controllers;
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



namespace TechByte.Views.DashboardSub.Sales.Modals
{
    public partial class PromoManagementForm : FormController, TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private int key;
        private TechByte.Architecture.Enums.FormModalTypes type;


        public PromoManagementForm() : base(true) {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (this.IsSubmittable()) {
                Promo promo;

                if (this.type == Architecture.Enums.FormModalTypes.CREATE) {
                    promo = new Promo();
                    promo.setName(new MultiWord(txtName.Text));
                    promo.setDiscount(float.Parse(numericDiscount.Value.ToString()));
                    promo.setStatus(new Architecture.Validations.AccountStatus("ACTIVE"));
                    bool createSuccess = promo.CreateData();
                    if (!createSuccess) {
                        MessageBox.Show("Unable to create Promo entry, please try again later");
                        return;
                    }
                    MessageBox.Show("Promo entry has been successfully created!");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else if (this.type == Architecture.Enums.FormModalTypes.UPDATE) {
                    promo = new Promo(this.key);
                    promo.setName(new MultiWord(txtName.Text));
                    promo.setDiscount(float.Parse(numericDiscount.Value.ToString()));
                    bool updateSuccess = promo.Update();
                    if (!updateSuccess) {
                        MessageBox.Show("Unable to save changes, please try again later");
                        return;
                    }
                    MessageBox.Show("Changes have been successfully saved!");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult result = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void PromoManagementForm_Load(object sender, EventArgs e) {
            InitFormModal();
            this.AddInputMonitor(new Guitar32.Validations.Monitors.InputMonitor(txtName, true));
        }



        public void Fetch() {
            if (this.type == Architecture.Enums.FormModalTypes.UPDATE) {
                Promo promo = new Promo(this.key);
                txtName.Text = promo.getName();
                numericDiscount.Value = decimal.Parse(promo.getDiscount().ToString());
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
                    Fetch();
                    break;
                    }
            }
            this.Text = lblTitle.Text;
        }
    }
}
