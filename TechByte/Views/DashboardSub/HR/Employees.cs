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

namespace TechByte.Views.DashboardSub.HR
{
    public partial class Employees : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;

        public Employees() {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void LoadData() {
            dgEmployees.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("view_s_fullusers")
                .Where("upper(power_name) <> " + Strings.Surround("ADMIN"));
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                dgEmployees.Rows.Add(new object[] {
                    row["user_id"].ToString(),
                    row["profile_lname"].ToString() + ", " + row["profile_fname"].ToString(),
                    row["power_name"].ToString(),
                    row["profile_tin"].ToString(),
                    row["contact_email"].ToString(),
                    row["address_city"].ToString() + ", " + row["address_region"].ToString()
                });
            }
            DataGridViews.SelectIndex(0, ref dgEmployees);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            Modals.EmployeesForm modal = new Modals.EmployeesForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgEmployees));
            DialogResult result = modal.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                this.LoadData();
            }
        }

        private void dgEmployees_SelectionChanged(object sender, EventArgs e) {
            btnEdit.Visible = ((DataGridView)sender).SelectedRows.Count > 0;
        }

        private void dgEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Modals.EmployeesForm modal = new Modals.EmployeesForm();
            modal.SetFormModalKey(DataGridViews.GetSelectedValue("ID", ref dgEmployees));
            modal.ShowDialog();
            this.LoadData();
        }
    }
}
