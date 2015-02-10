using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TechByte.Views.Dashboard;

namespace TechByte
{
    public partial class Dashboard : Form
    {

        UserManagement Form_UserManagement;


        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //this.Form_UserManagement = new UserManagement();
            //this.Form_UserManagement.MdiParent = this;
            //this.Form_UserManagement.Show();
        }

        private void accountsManagementToolStripMenuItem_Click(object sender, EventArgs e) {
            Form_UserManagement = new UserManagement();
            Form_UserManagement.MdiParent = this;
            Form_UserManagement.Show();
        }
    }
}
