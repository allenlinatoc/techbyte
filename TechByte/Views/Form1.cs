using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TechByte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Opacity = 0;
            timerFade.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormManager.Initialize();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;


            Boolean result = new Models.SystemLogin().Login(username, password);
            if (result) {
                this.Hide();
                txtUsername.Clear();
                txtPassword.Clear();
                FormManager.frmDashboard.Show(this);
                this.Show();
                FormManager.frmDashboard.Focus();
            }
            else {
                MessageBox.Show("Username or password incorrect!");
                txtPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                this.Enabled = true;
            }
        }
    }
}
