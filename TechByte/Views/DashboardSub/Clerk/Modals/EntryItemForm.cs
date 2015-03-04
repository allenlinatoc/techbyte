using Guitar32;
using Guitar32.Controllers;
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
using TechByte.Architecture.Beans.Goods;


namespace TechByte.Views.DashboardSub.Clerk.Modals
{
    public partial class EntryItemForm : FormController,
        TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private TechByte.Architecture.Enums.FormModalTypes
            type;
        private ComboBind
            comboBind_Category, comboBind_Item;



        public EntryItemForm() : base(true) {
            InitializeComponent();
            this.type = Architecture.Enums.FormModalTypes.CREATE;
        }

        private void EntryItemForm_Load(object sender, EventArgs e) {
            InitFormModal();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e) {
            // Fetch item for given comboCategory
            if (comboCategory.Items.Count > 0 && comboCategory.SelectedIndex >= 0) {
                int categoryId = Integer.Parse(comboBind_Category.GetValue());

                QueryBuilder query = new QueryBuilder();
                query.Select()
                    .From("tblgoods")
                    .Where("category_id", categoryId);
                QueryResult result = dbConn.Query(query);
                comboBind_Item = new ComboBind(ref comboItem);
                for (int i = 0; i < result.RowCount(); i++) {
                    QueryResultRow row = result.GetSingle(i);
                    comboBind_Item.AddItem(row["name"].ToString(), row["id"]);
                }
                comboBind_Item.TrySelect(0);

            }
        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e) {
            btnSave.Enabled = comboItem.SelectedIndex >= 0;
            ComputeTotalCost();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            FormData formData = new FormData();
            formData.Add("CATEGORY_ID", comboBind_Category.GetValue());
            formData.Add("CATEGORY_NAME", comboBind_Category.GetDisplay());
            formData.Add("GOOD_ID", comboBind_Item.GetValue());
            formData.Add("GOOD_NAME", comboBind_Item.GetDisplay());
            formData.Add("QUANTITY", numericQuantity.Value);
            formData.Add("TOTAL_COST", numericTotalcost.Value);
            this.SetFormData(formData);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e) {
            ComputeTotalCost();
        }

        private void ComputeTotalCost() {
            if (comboItem.Items.Count > 0 && comboItem.SelectedIndex >= 0) {
                int goodId = Integer.Parse(comboBind_Item.GetValue());
                Good good = new Good(goodId);
                float totalPrice = good.getPrice() * (float)numericQuantity.Value;
                numericTotalcost.Value = (decimal)totalPrice;
            }
            else {
                numericTotalcost.Value = 0;
            }
        }



        public void Fetch() {
            // Fetch from FormData
            if (this.HasFormData()) {
                int categoryId = Integer.Parse(this.GetFormData()["CATEGORY_ID"]);
                int goodId = Integer.Parse(this.GetFormData()["GOOD_ID"]);
                int quantity = Integer.Parse(this.GetFormData()["QUANTITY"]);
                float totalCost = (float)this.GetFormData()["TOTAL_COST"];
                comboBind_Category.SetByValue(categoryId);
                comboBind_Item.SetByValue(goodId);
                numericQuantity.Value = (decimal)quantity;
                numericTotalcost.Value = (decimal)totalCost;
            }
        }

        public void SetFormModalKey(object key) {
            throw new NotImplementedException();
        }

        public void SetFormModalType(Architecture.Enums.FormModalTypes type) {
            this.type = type;
        }

        public void InitFormModal() {
            // Initialize combo boxes
            comboBind_Category = new ComboBind(ref comboCategory);
            comboBind_Category.ClearItems();
            comboBind_Item = new ComboBind(ref comboItem);
            comboBind_Item.ClearItems();


            // Fetch categories
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblgoodscategories");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                comboBind_Category.AddItem(row["name"].ToString(), Integer.Parse(row["id"]));
            }
            comboBind_Category.TrySelect(0);


            switch (this.type) {
                case Architecture.Enums.FormModalTypes.CREATE: {
                    break;
                    }
                case Architecture.Enums.FormModalTypes.VIEW: {
                    this.Fetch();
                    this.DisableCloseDetections();
                    break;
                    }
            }
        }


    }
}
