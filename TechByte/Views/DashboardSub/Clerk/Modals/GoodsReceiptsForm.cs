﻿using Guitar32;
using Guitar32.Data;
using Guitar32.Database;
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
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Goods;
using TechByte.Architecture.Beans.Warehouse;

namespace TechByte.Views.DashboardSub.Clerk.Modals
{
    public partial class GoodsReceiptsForm : Form, TechByte.Architecture.Common.IFormModal
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        private TechByte.Architecture.Enums.FormModalTypes
            type;
        private ComboBind comboBind_Type;



        public GoodsReceiptsForm() {
            InitializeComponent();
        }

        private void GoodsReceiptsForm_Load(object sender, EventArgs e) {
            InitFormModal();
        }


        private void btnAdd_Click(object sender, EventArgs e) {
            EntryItemForm modal = new EntryItemForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                FormData formData = modal.GetFormData();
                dgItems.Rows.Add(new object[] {
                    formData["CATEGORY_ID"].ToString(),
                    formData["CATEGORY_NAME"].ToString(),
                    formData["GOOD_ID"].ToString(),
                    formData["GOOD_NAME"].ToString(),
                    formData["QUANTITY"].ToString()
                });
            }
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            if (dgItems.Rows.Count > 0 && dgItems.SelectedRows.Count > 0) {
                DataGridViews.RemoveSelected(ref dgItems);
            }
        }

        private void dgItems_SelectionChanged(object sender, EventArgs e) {
            btnRemove.Visible = dgItems.SelectedRows.Count > 0;
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgItems.SelectedRows.Count > 0) {
                int selectedIndex = dgItems.SelectedRows[0].Index;
                DataGridViewRow row = dgItems.Rows[selectedIndex];

                // Build FormData
                FormData formData = new FormData();
                formData.Add("CATEGORY_ID", row.Cells["Column1"].Value);
                formData.Add("GOOD_ID", row.Cells["Column3"].Value);
                formData.Add("QUANTITY", row.Cells["Column5"].Value);

                // Show edit modal
                EntryItemForm modal = new EntryItemForm();
                modal.SetFormModalType(Architecture.Enums.FormModalTypes.UPDATE);
                modal.SetFormData(formData);
                modal.ShowDialog(this);

                if (modal.DialogResult == System.Windows.Forms.DialogResult.OK) {
                    FormData newFormData = modal.GetFormData();
                    row.SetValues(new object[] {
                        newFormData["CATEGORY_ID"].ToString(),
                        newFormData["CATEGORY_NAME"].ToString(),
                        newFormData["GOOD_ID"].ToString(),
                        newFormData["GOOD_NAME"].ToString(),
                        newFormData["QUANTITY"].ToString()
                    });
                    dgItems.Rows.RemoveAt(selectedIndex);
                    dgItems.Rows.Insert(selectedIndex, row);
                    DataGridViews.SelectIndex(selectedIndex, ref dgItems);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            WarehouseEntry warehouseEntry = new WarehouseEntry();

            // Build a warehouse entry list
            WarehouseEntryItemList list = new WarehouseEntryItemList();
            for (int i = 0; i < dgItems.Rows.Count; i++) {
                DataGridViewRow row = dgItems.Rows[i];
                WarehouseEntryItem item = new WarehouseEntryItem();
                item.setParentWarehouseEntry(warehouseEntry);
                Good good = new Good(Integer.Parse(row.Cells["Column3"].Value));
                item.setGood(good);
                item.setQuantity(Integer.Parse(row.Cells["Column5"].Value));
                if (!item.CreateData()) {
                    MessageBox.Show("Failed to create a warehouse entry item");
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                    return;
                }
                list.Add(item);
            }

            // Warehouse entry
            warehouseEntry.setCreationDate(Guitar32.Validations.DateTime.CreateFromNativeDateTime(System.DateTime.Today));
            warehouseEntry.setItemList(list);
            if (!warehouseEntry.CreateData()) {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                MessageBox.Show("Failed to create Warehouse Entry");
                return;
            }

            GoodsReceipt greceipt = new GoodsReceipt();
            greceipt.setPIC((SystemUser)Guitar32.Utilities.Session.Get("CURRENT_USER"));
            greceipt.setType(new Guitar32.Validations.SingleWordAlpha(comboBind_Type.GetValue().ToString()));
            greceipt.setWarehouseEntry(warehouseEntry);
            greceipt.setCreationDate(new Guitar32.Validations.DateTime(warehouseEntry.getCreationDate()));
            if (!greceipt.CreateData()) {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                MessageBox.Show("Creation of goods receipt");
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            this.comboBind_Type = new ComboBind(ref comboType);
            comboBind_Type
                .AddItem("Incoming", "INCOMING")
                .AddItem("Outgoing", "OUTGOING")
            ;
            comboBind_Type.TrySelect(0);

            switch (this.type) {
                case Architecture.Enums.FormModalTypes.CREATE: {
                    break;
                    }
            }
        }
    }
}
