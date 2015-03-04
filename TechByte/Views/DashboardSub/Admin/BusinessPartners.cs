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
using TechByte.Architecture.Beans.Business;


namespace TechByte.Views.DashboardSub.Admin
{
    public partial class BusinessPartners : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;
        public BusinessPartners() {
            InitializeComponent();
        }

        protected void LoadData() {
            dgCompanies.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            Dictionary<object, object> conditions = new Dictionary<object, object>();
            conditions.Add("company_address_id", "address_id");
            query.Select()
                .From("view_companies, view_addressdetails")
                .Where(conditions);
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow resRow = result.GetSingle(i);
                dgCompanies.Rows.Add(new object[] {
                    resRow["company_id"].ToString(),
                    resRow["company_name"].ToString(),
                    Strings.UppercaseFirst(resRow["company_type"].ToString()),
                    resRow["company_status"].ToString().ToUpper(),
                    resRow["address_city"].ToString() + ", " + resRow["address_region"].ToString()
                });
            }
            dgCompanies.ClearSelection();
            DataGridViews.SelectIndex(0, ref dgCompanies);
        }

        private void BusinessPartners_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void btnNew_Click(object sender, EventArgs e) {
            Modals.BusinessPartnersForm modal = new Modals.BusinessPartnersForm();
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            Modals.BusinessPartnersForm modal = new Modals.BusinessPartnersForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgCompanies));
            modal.SetFormModalType(Architecture.Enums.FormModalTypes.UPDATE);
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void btnActivateToggle_Click(object sender, EventArgs e) {
            String companyName = DataGridViews.GetSelectedValue(1, ref dgCompanies).ToString();
            DialogResult result =
                MessageBox.Show("Are you sure you want to " + btnActivateToggle.Text.ToLower() + " " + companyName + "?", "Confirm activation/deactivation", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                String newStatus = btnActivateToggle.Text.ToUpper().Equals("ACTIVATE") ? "ACTIVE" : "INACTIVE";
                Company company = new Company(Integer.Parse(DataGridViews.GetSelectedValue(0, ref dgCompanies)));
                company.setStatus(new Architecture.Validations.AccountStatus(newStatus));
                if (!company.Update()) {
                    MessageBox.Show("Unable to perform requested operation. Please try again later.");
                    return;
                }
                MessageBox.Show("Company " + Strings.Surround(companyName) + " has been successfully " + btnActivateToggle.Text.ToLower() + "d!");
                LoadData();
                return;
            }
        }

        private void dgCompanies_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Modals.BusinessPartnersForm modal = new Modals.BusinessPartnersForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgCompanies));
            modal.SetFormModalType(Architecture.Enums.FormModalTypes.UPDATE);
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                LoadData();
            }
        }

        private void dgCompanies_SelectionChanged(object sender, EventArgs e) {
            btnEdit.Visible = dgCompanies.SelectedRows.Count > 0;
            btnActivateToggle.Visible = dgCompanies.SelectedRows.Count > 0;
            if (dgCompanies.SelectedRows.Count > 0) {
                String status = DataGridViews.GetSelectedValue("STATUS", ref dgCompanies).ToString().ToUpper();
                btnActivateToggle.Text = status.Equals("ACTIVE") ? "Deactivate" : "Activate";
            }
        }

        private void dgCompanies_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
