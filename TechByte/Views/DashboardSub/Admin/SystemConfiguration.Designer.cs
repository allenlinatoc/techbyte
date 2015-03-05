namespace TechByte.Views.DashboardSub.Admin
{
    partial class SystemConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkClerk = new System.Windows.Forms.CheckBox();
            this.checkSales = new System.Windows.Forms.CheckBox();
            this.checkPurchasing = new System.Windows.Forms.CheckBox();
            this.checkHR = new System.Windows.Forms.CheckBox();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboLockdown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaxrate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChangeBackcolor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "System configuration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkClerk);
            this.groupBox1.Controls.Add(this.checkSales);
            this.groupBox1.Controls.Add(this.checkPurchasing);
            this.groupBox1.Controls.Add(this.checkHR);
            this.groupBox1.Controls.Add(this.checkAdmin);
            this.groupBox1.Location = new System.Drawing.Point(16, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Modules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enable or disable system modules by ticking\r\ncheckboxes below";
            // 
            // checkClerk
            // 
            this.checkClerk.AutoSize = true;
            this.checkClerk.Checked = true;
            this.checkClerk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkClerk.Location = new System.Drawing.Point(17, 176);
            this.checkClerk.Name = "checkClerk";
            this.checkClerk.Size = new System.Drawing.Size(92, 17);
            this.checkClerk.TabIndex = 2;
            this.checkClerk.Text = "Clerk / Goods";
            this.checkClerk.UseVisualStyleBackColor = true;
            // 
            // checkSales
            // 
            this.checkSales.AutoSize = true;
            this.checkSales.Checked = true;
            this.checkSales.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSales.Location = new System.Drawing.Point(17, 151);
            this.checkSales.Name = "checkSales";
            this.checkSales.Size = new System.Drawing.Size(52, 17);
            this.checkSales.TabIndex = 2;
            this.checkSales.Text = "Sales";
            this.checkSales.UseVisualStyleBackColor = true;
            // 
            // checkPurchasing
            // 
            this.checkPurchasing.AutoSize = true;
            this.checkPurchasing.Checked = true;
            this.checkPurchasing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPurchasing.Location = new System.Drawing.Point(17, 126);
            this.checkPurchasing.Name = "checkPurchasing";
            this.checkPurchasing.Size = new System.Drawing.Size(79, 17);
            this.checkPurchasing.TabIndex = 2;
            this.checkPurchasing.Text = "Purchasing";
            this.checkPurchasing.UseVisualStyleBackColor = true;
            // 
            // checkHR
            // 
            this.checkHR.AutoSize = true;
            this.checkHR.Checked = true;
            this.checkHR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHR.Location = new System.Drawing.Point(17, 101);
            this.checkHR.Name = "checkHR";
            this.checkHR.Size = new System.Drawing.Size(109, 17);
            this.checkHR.TabIndex = 2;
            this.checkHR.Text = "Human Resource";
            this.checkHR.UseVisualStyleBackColor = true;
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Checked = true;
            this.checkAdmin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAdmin.Location = new System.Drawing.Point(17, 78);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(91, 17);
            this.checkAdmin.TabIndex = 2;
            this.checkAdmin.Text = "Administration";
            this.checkAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboLockdown);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(280, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System lock-down";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "By turning on \"Lock-down\", no one will be\r\nable to log-in to the system except th" +
    "e admin.";
            // 
            // comboLockdown
            // 
            this.comboLockdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLockdown.FormattingEnabled = true;
            this.comboLockdown.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.comboLockdown.Location = new System.Drawing.Point(156, 28);
            this.comboLockdown.Name = "comboLockdown";
            this.comboLockdown.Size = new System.Drawing.Size(68, 23);
            this.comboLockdown.TabIndex = 3;
            this.comboLockdown.SelectedIndexChanged += new System.EventHandler(this.comboLockdown_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "System is Lock-down is {0}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "System lock-down status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTaxrate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(553, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Global rates";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 45);
            this.label7.TabIndex = 2;
            this.label7.Text = "This is the tax rate being used for\r\nall monetary transactions involving\r\nvalue-a" +
    "dded tax.";
            // 
            // txtTaxrate
            // 
            this.txtTaxrate.Location = new System.Drawing.Point(60, 28);
            this.txtTaxrate.MaxLength = 2;
            this.txtTaxrate.Name = "txtTaxrate";
            this.txtTaxrate.Size = new System.Drawing.Size(23, 22);
            this.txtTaxrate.TabIndex = 3;
            this.txtTaxrate.Text = "12";
            this.txtTaxrate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tax rate";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChangeBackcolor);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(16, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 219);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User-interface Appearance";
            // 
            // btnChangeBackcolor
            // 
            this.btnChangeBackcolor.BackColor = System.Drawing.Color.Gray;
            this.btnChangeBackcolor.Location = new System.Drawing.Point(149, 108);
            this.btnChangeBackcolor.Name = "btnChangeBackcolor";
            this.btnChangeBackcolor.Size = new System.Drawing.Size(90, 23);
            this.btnChangeBackcolor.TabIndex = 3;
            this.btnChangeBackcolor.UseVisualStyleBackColor = false;
            this.btnChangeBackcolor.Click += new System.EventHandler(this.btnChangeBackcolor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Dashboard background";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(225, 45);
            this.label9.TabIndex = 2;
            this.label9.Text = "Customize the appearance of the system\r\ndepending on the available customization\r" +
    "\noptions below";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(585, 536);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(666, 536);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SystemConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 578);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SystemConfiguration";
            this.Text = "Configure system";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SystemConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkAdmin;
        private System.Windows.Forms.CheckBox checkHR;
        private System.Windows.Forms.CheckBox checkSales;
        private System.Windows.Forms.CheckBox checkPurchasing;
        private System.Windows.Forms.CheckBox checkClerk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboLockdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTaxrate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnChangeBackcolor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}