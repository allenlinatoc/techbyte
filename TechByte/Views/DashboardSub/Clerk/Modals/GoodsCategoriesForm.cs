using Guitar32.Controllers;
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
using TechByte.Architecture.Beans.Goods;

namespace TechByte.Views.DashboardSub.Clerk.Modals
{
    public partial class GoodsCategoriesForm : FormController, Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private int key;
        private TechByte.Architecture.Enums.FormModalTypes type;


        public GoodsCategoriesForm() {
            InitializeComponent();
            this.type = Architecture.Enums.FormModalTypes.Create;
        }

        private void GoodsCategoriesForm_Load(object sender, EventArgs e) {
            InitFormModal();
            Fetch();
            // Load monitors
            this.AddInputMonitor(new InputMonitor(txtName, true))
                .AddInputMonitor(new InputMonitor(txtDescription, true));
            ;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (this.IsSubmittable()) {
                GoodsCategory category;
                if (this.type == Architecture.Enums.FormModalTypes.Create) {
                    if (GoodsCategory.NameExists(new MultiWordAlphaNumeric(txtName.Text))) {
                        MessageBox.Show("That category name already exists. Please choose another name");
                        return;
                    }
                    category = new GoodsCategory();
                    category.setName(new MultiWordAlphaNumeric(txtName.Text));
                    category.setDescription(new MultiWordAlphaNumeric(txtDescription.Text));
                    bool categoryCreateSuccess = category.CreateData();
                    if (categoryCreateSuccess) {
                        MessageBox.Show("Goods category has been successfully created!");
                        this.DisableCloseDetections();
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Unable to create a new Goods category, please check your connection and try again");
                    }
                }
                else {
                    category = new GoodsCategory(this.key);
                    category.setName(new MultiWordAlphaNumeric(txtName.Text));
                    category.setDescription(new MultiWordAlphaNumeric(txtDescription.Text));
                    bool categoryUpdateSuccess = category.Update();
                    if (categoryUpdateSuccess) {
                        MessageBox.Show("Changes have been successfully saved!");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                    else {
                        MessageBox.Show("Unable to save changes you made, please check your connection and try again");
                    }
                }
            }
        }

        public void Fetch() {
            if (this.type == Architecture.Enums.FormModalTypes.Update) {
                GoodsCategory category = new GoodsCategory(this.key);
                txtName.Text = category.getName();
                txtDescription.Text = category.getDescription();
            }
        }

        public void SetFormModalKey(object key) {
            this.key = Integer.Parse(key);
            this.SetFormModalType(Architecture.Enums.FormModalTypes.Update);
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            switch (this.type) {
                case Architecture.Enums.FormModalTypes.Create: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "New");
                    this.EnableCloseDetections();
                    break;
                    }
                case Architecture.Enums.FormModalTypes.Update: {
                    lblTitle.Text = lblTitle.Text.Replace("{0}", "Edit");
                    this.DisableCloseDetections();
                    break;
                    }
            }
            this.Text = lblTitle.Text;
        }
    }
}
