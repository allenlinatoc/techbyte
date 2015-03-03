using Guitar32;
using Guitar32.Database;
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
using TechByte.Architecture.Beans.Accounts;
using TechByte.Architecture.Beans.Profiles;
using TechByte.Architecture.Usecases;
using TechByte.Views.DashboardSub.Admin.Modals;



namespace TechByte.Views.DashboardSub.Admin
{
    public partial class UserManagement : Form
    {


        public UserManagement()
        {
            InitializeComponent();
        }



        private void btnNew_Click(object sender, EventArgs e) {
            UserManagementForm formNew = new UserManagementForm();
            DialogResult result = formNew.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK) {
                // Refresh data
                this.LoadData();
            }
        }


        private void btnEdit_Click(object sender, EventArgs e) {
            UserManagementForm formEdit = new UserManagementForm();
            formEdit.SetFormModalType(Architecture.Enums.FormModalTypes.Update);
            // Get User ID
            object cellValue = DataGridViews.GetSelectedValue("ID", ref dgUsers);
            int id = int.Parse(cellValue.ToString());
            // Pass User ID
            formEdit.SetFormModalKey(id);
            // Show dialog
            DialogResult result = formEdit.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                // Refresh
                LoadData();
            }
        }


        private void UserManagement_Load(object sender, EventArgs e) {
            this.LoadData();
        }


        public void LoadData() {
            UCSystemUserCollection systemUserCollection = new UCSystemUserCollection();
            SystemResponse response;

            dgUsers.Rows.Clear();
            // Fetch users from database
            systemUserCollection.Fetch();
            response = systemUserCollection.getResponse();
            if (response.GetCode() == "00") {
                QueryResult result = (QueryResult)response.GetData();
                for (int i = 0; i < result.RowCount(); i++) {
                    DataGridViewRow nRow = new DataGridViewRow();
                    QueryResultRow dbRow = result.GetSingle(i);
                    dgUsers.Rows.Add(new object[] {
                        dbRow["user_id"].ToString(),
                        dbRow["user_username"].ToString(),
                        dbRow["profile_fname"].ToString() + " " + dbRow["profile_lname"].ToString(),
                        dbRow["power_name"].ToString(),
                        dbRow["user_status"].ToString()
                    });
                }
            }
            else {
                MessageBox.Show(response.GetMessage());
            }
            dgUsers.ClearSelection();
            DataGridViews.SelectIndex(0, ref dgUsers);
        }


        private void dgUsers_SelectionChanged(object sender, EventArgs e) {
            DataGridView dataGridView = (DataGridView)sender;
            btnEdit.Visible = dataGridView.SelectedRows.Count > 0;
            btnActivateToggle.Visible = dataGridView.SelectedRows.Count > 0;
            if (btnActivateToggle.Visible) {
                btnActivateToggle.Text =
                    DataGridViews.GetSelectedValue(4, ref dataGridView)
                        .ToString().Trim().ToUpper().Equals("ACTIVE") ? "Deactivate" : "Activate";
            }
        }

        private void dgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            UserManagementForm formEdit = new UserManagementForm();
            formEdit.SetFormModalType(Architecture.Enums.FormModalTypes.Update);
            // Get User ID
            object cellValue = DataGridViews.GetSelectedValue("ID", ref dgUsers);
            int id = int.Parse(cellValue.ToString());
            // Pass User ID
            formEdit.SetFormModalKey(id);
            // Show dialog
            DialogResult result = formEdit.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK) {
                // Refresh
                LoadData();
            }
        }

        private void btnActivateToggle_Click(object sender, EventArgs e) {
            object
                cellStatus = DataGridViews.GetSelectedValue("STATUS", ref dgUsers),
                cellID = DataGridViews.GetSelectedValue("ID", ref dgUsers);
            ;
            String status = cellStatus.ToString();
            int userId = int.Parse(cellID + "");
            SystemUser user = new SystemUser(userId);
            DialogResult choice =
                MessageBox.Show("Are you sure you want to " + btnActivateToggle.Text.ToLower() + " " + user.getProfileDetails().getFullname().getFirstName() + "'s account?", "Confirm " + btnActivateToggle.Text.ToLower(), MessageBoxButtons.YesNo);
            if (choice == System.Windows.Forms.DialogResult.Yes) {
                user.setStatus(new Architecture.Validations.AccountStatus(status.ToUpper().Equals("ACTIVE") ? "INACTIVE" : "ACTIVE", true));
                if (!user.Update()) {
                    MessageBox.Show("Something went wrong, please check your connection and try again");
                    return;
                }
                MessageBox.Show("User account has been successfully " + btnActivateToggle.Text.ToLower() + "d");
                this.LoadData();
            }
        }


    }
}
