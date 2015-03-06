namespace TechByte.Views.DashboardSub.Purchasing.Modals
{
    partial class PurchasingForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDelivery = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboGreceipt = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.numericGrosstotal = new System.Windows.Forms.NumericUpDown();
            this.numericActualtotal = new System.Windows.Forms.NumericUpDown();
            this.numericAmountpaid = new System.Windows.Forms.NumericUpDown();
            this.numericChange = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericGrosstotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericActualtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChange)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "{0} purchase";
            // 
            // comboVendor
            // 
            this.comboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Location = new System.Drawing.Point(159, 107);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(206, 21);
            this.comboVendor.TabIndex = 1;
            this.comboVendor.SelectedIndexChanged += new System.EventHandler(this.comboVendor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor";
            // 
            // comboDelivery
            // 
            this.comboDelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDelivery.FormattingEnabled = true;
            this.comboDelivery.Location = new System.Drawing.Point(159, 134);
            this.comboDelivery.Name = "comboDelivery";
            this.comboDelivery.Size = new System.Drawing.Size(84, 21);
            this.comboDelivery.TabIndex = 1;
            this.comboDelivery.SelectedIndexChanged += new System.EventHandler(this.comboDelivery_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delivery ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Goods receipt ID";
            // 
            // comboGreceipt
            // 
            this.comboGreceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGreceipt.FormattingEnabled = true;
            this.comboGreceipt.Location = new System.Drawing.Point(159, 161);
            this.comboGreceipt.Name = "comboGreceipt";
            this.comboGreceipt.Size = new System.Drawing.Size(84, 21);
            this.comboGreceipt.TabIndex = 1;
            this.comboGreceipt.SelectedIndexChanged += new System.EventHandler(this.comboGreceipts_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Gross total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Net total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Amount paid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Change";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(159, 64);
            this.txtType.MaxLength = 15;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(142, 20);
            this.txtType.TabIndex = 4;
            this.txtType.Text = "PAYABLE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Type";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(399, 325);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(318, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // numericGrosstotal
            // 
            this.numericGrosstotal.BackColor = System.Drawing.SystemColors.Control;
            this.numericGrosstotal.DecimalPlaces = 2;
            this.numericGrosstotal.Enabled = false;
            this.numericGrosstotal.Location = new System.Drawing.Point(159, 201);
            this.numericGrosstotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericGrosstotal.Name = "numericGrosstotal";
            this.numericGrosstotal.ReadOnly = true;
            this.numericGrosstotal.Size = new System.Drawing.Size(120, 20);
            this.numericGrosstotal.TabIndex = 6;
            this.numericGrosstotal.ThousandsSeparator = true;
            // 
            // numericActualtotal
            // 
            this.numericActualtotal.BackColor = System.Drawing.SystemColors.Control;
            this.numericActualtotal.DecimalPlaces = 2;
            this.numericActualtotal.Enabled = false;
            this.numericActualtotal.Location = new System.Drawing.Point(159, 227);
            this.numericActualtotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericActualtotal.Name = "numericActualtotal";
            this.numericActualtotal.ReadOnly = true;
            this.numericActualtotal.Size = new System.Drawing.Size(120, 20);
            this.numericActualtotal.TabIndex = 6;
            this.numericActualtotal.ThousandsSeparator = true;
            // 
            // numericAmountpaid
            // 
            this.numericAmountpaid.BackColor = System.Drawing.Color.White;
            this.numericAmountpaid.DecimalPlaces = 2;
            this.numericAmountpaid.Location = new System.Drawing.Point(159, 264);
            this.numericAmountpaid.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericAmountpaid.Name = "numericAmountpaid";
            this.numericAmountpaid.Size = new System.Drawing.Size(120, 20);
            this.numericAmountpaid.TabIndex = 6;
            this.numericAmountpaid.ThousandsSeparator = true;
            this.numericAmountpaid.ValueChanged += new System.EventHandler(this.numericAmountpaid_ValueChanged);
            // 
            // numericChange
            // 
            this.numericChange.BackColor = System.Drawing.SystemColors.Control;
            this.numericChange.DecimalPlaces = 2;
            this.numericChange.Enabled = false;
            this.numericChange.Location = new System.Drawing.Point(159, 290);
            this.numericChange.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericChange.Name = "numericChange";
            this.numericChange.ReadOnly = true;
            this.numericChange.Size = new System.Drawing.Size(120, 20);
            this.numericChange.TabIndex = 6;
            this.numericChange.ThousandsSeparator = true;
            // 
            // PurchasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(486, 360);
            this.Controls.Add(this.numericChange);
            this.Controls.Add(this.numericActualtotal);
            this.Controls.Add(this.numericAmountpaid);
            this.Controls.Add(this.numericGrosstotal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboGreceipt);
            this.Controls.Add(this.comboDelivery);
            this.Controls.Add(this.comboVendor);
            this.Controls.Add(this.lblTitle);
            this.Name = "PurchasingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{0} purchase";
            this.Load += new System.EventHandler(this.PurchasingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericGrosstotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericActualtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboGreceipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown numericGrosstotal;
        private System.Windows.Forms.NumericUpDown numericActualtotal;
        private System.Windows.Forms.NumericUpDown numericAmountpaid;
        private System.Windows.Forms.NumericUpDown numericChange;
    }
}