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
using TechByte.Architecture.Usecases;
using TechByte.Views.DashboardSub.Modals;



namespace TechByte.Views.DashboardSub
{
    public partial class UserManagement : Form
    {


        public UserManagement()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                cmsOptions.Show(this.Location.X + e.Location.X, this.Location.Y + e.Location.Y);
            }
        }


        private void btnNew_Click(object sender, EventArgs e) {
            UserManagementForm formNew = new UserManagementForm();
            formNew.ShowDialog(this);
            this.LoadData();
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
            formEdit.ShowDialog();
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
                    Dictionary<string, object> dbRow = result.GetSingle(i);
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
                        .ToString().Trim().ToUpper().Equals("ACTIVE") ? "Activate" : "Deactivate";
            }
        }


    }
}
