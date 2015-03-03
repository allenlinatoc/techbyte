using Guitar32;
using Guitar32.Controllers;
using Guitar32.Database;
using Guitar32.Utilities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TechByte.Views.DashboardSub.Clerk
{
    public class Goods : Form
    {
        private Button btnNew;
        private Button btnEdit;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dgGoods;

        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;



        public Goods() {
            InitializeComponent();
            LoadData();
        }

        private void InitializeComponent() {
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgGoods = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(135, 38);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(12, 56);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 38);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgGoods
            // 
            this.dgGoods.AllowUserToAddRows = false;
            this.dgGoods.AllowUserToDeleteRows = false;
            this.dgGoods.AllowUserToOrderColumns = true;
            this.dgGoods.AllowUserToResizeRows = false;
            this.dgGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGoods.ColumnHeadersHeight = 30;
            this.dgGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3,
            this.Column4});
            this.dgGoods.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgGoods.Location = new System.Drawing.Point(153, 12);
            this.dgGoods.MultiSelect = false;
            this.dgGoods.Name = "dgGoods";
            this.dgGoods.RowHeadersVisible = false;
            this.dgGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGoods.Size = new System.Drawing.Size(455, 288);
            this.dgGoods.TabIndex = 6;
            this.dgGoods.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGoods_CellDoubleClick);
            this.dgGoods.SelectionChanged += new System.EventHandler(this.dgGoods_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Vendor";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Category";
            this.Column5.Name = "Column5";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Product name";
            this.Column3.Name = "Column3";
            this.Column3.Width = 96;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 54;
            // 
            // Goods
            // 
            this.ClientSize = new System.Drawing.Size(620, 312);
            this.Controls.Add(this.dgGoods);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Name = "Goods";
            this.Text = "Goods management";
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).EndInit();
            this.ResumeLayout(false);

        }

        public void LoadData() {
            dgGoods.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("view_s_fullgoods");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                dgGoods.Rows.Add(new object[] {
                    row["good_id"],
                    row["company_name"],
                    row["goodscategory_name"],
                    row["good_name"],
                    row["good_price"]
                });
            }
            DataGridViews.SelectIndex(0, ref dgGoods);
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.GoodsForm modal = new Modals.GoodsForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            Modals.GoodsForm modal = new Modals.GoodsForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgGoods));
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void dgGoods_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Modals.GoodsForm modal = new Modals.GoodsForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgGoods));
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void dgGoods_SelectionChanged(object sender, EventArgs e) {
            btnEdit.Visible = dgGoods.SelectedRows.Count > 0;
        }

    }
}
