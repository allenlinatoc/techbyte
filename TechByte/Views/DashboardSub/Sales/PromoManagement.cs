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
using TechByte.Architecture.Beans;


namespace TechByte.Views.DashboardSub.Sales
{
    public partial class PromoManagement : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public PromoManagement() {
            InitializeComponent();
        }

        private void PromoManagement_Load(object sender, EventArgs e) {

        }

        private void LoadData() {
            dgPromos.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblpromos");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                dgPromos.Rows.Add(new object[] {
                    row["id"].ToString(),
                    row["name"].ToString(),
                    row["discount"].ToString(),
                    Strings.UppercaseFirst(row["status"].ToString()),
                });
            }
            DataGridViews.SelectIndex(0, ref dgPromos);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) {
            btnActivateToggle.Visible = dgPromos.SelectedRows.Count > 0;
            if (dgPromos.SelectedRows.Count > 0) {
                String status = DataGridViews.GetSelectedValue("Status", ref dgPromos).ToString().ToUpper();
                btnActivateToggle.Text = status.Equals("ACTIVE") ? "Deactivate" : "Activate";
            }
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.PromoManagementForm modal = new Modals.PromoManagementForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void btnActivateToggle_Click(object sender, EventArgs e) {
            int promoId = Integer.Parse(DataGridViews.GetSelectedValue("ID", ref dgPromos));
            Promo promo = new Promo(promoId);
            DialogResult result = MessageBox.Show("Are you sure you want to " + btnActivateToggle.Text.ToLower() + " promo \"" + promo.getName() + "\"?", "Confirm action", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                promo.setStatus(new Architecture.Validations.AccountStatus(promo.getStatus().Equals("ACTIVE") ? "INACTIVE" : "ACTIVE"));
                if (!promo.Update()) {
                    MessageBox.Show("Failed to complete the requested operation, please try again later");
                    return;
                }
                MessageBox.Show(String.Format("Promo \"{0}\" has been successfully {1}d", promo.getName(), btnActivateToggle.Text));
                LoadData();
            }
        }

        private void dgPromos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (dgPromos.SelectedRows.Count > 0) {
                int promoId = Integer.Parse(DataGridViews.GetSelectedValue("ID", ref dgPromos));
                Modals.PromoManagementForm modal = new Modals.PromoManagementForm();
                modal.SetFormModalKey(promoId);
                DialogResult result = modal.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK) {
                    LoadData();
                }
            }
        }

    }
}
