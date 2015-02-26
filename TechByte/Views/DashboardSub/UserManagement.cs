using Guitar32;
using Guitar32.Database;
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
        }

        private void UserManagement_Load(object sender, EventArgs e) {
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
                    Console.WriteLine("LINE1: " + dbRow["user_username"]);
                    dgUsers.Rows.Add( new object[] {
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
        }
    }
}
