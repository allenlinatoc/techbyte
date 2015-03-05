namespace TechByte.Views.DashboardSub.Sales.Modals
{
    partial class SalesManagementForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboGreceipt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericGrosstotal = new System.Windows.Forms.NumericUpDown();
            this.numericActualtotal = new System.Windows.Forms.NumericUpDown();
            this.numericAmountpaid = new System.Windows.Forms.NumericUpDown();
            this.numericChange = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.lblTitle.Size = new System.Drawing.Size(79, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "{0} sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Goods receipt ID";
            // 
            // comboGreceipt
            // 
            this.comboGreceipt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGreceipt.FormattingEnabled = true;
            this.comboGreceipt.Location = new System.Drawing.Point(171, 74);
            this.comboGreceipt.Name = "comboGreceipt";
            this.comboGreceipt.Size = new System.Drawing.Size(102, 21);
            this.comboGreceipt.TabIndex = 2;
            this.comboGreceipt.SelectedIndexChanged += new System.EventHandler(this.comboGreceipt_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gross total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Actual total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount paid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Change";
            // 
            // numericGrosstotal
            // 
            this.numericGrosstotal.Enabled = false;
            this.numericGrosstotal.Location = new System.Drawing.Point(171, 113);
            this.numericGrosstotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericGrosstotal.Name = "numericGrosstotal";
            this.numericGrosstotal.ReadOnly = true;
            this.numericGrosstotal.Size = new System.Drawing.Size(118, 20);
            this.numericGrosstotal.TabIndex = 4;
            this.numericGrosstotal.ValueChanged += new System.EventHandler(this.numericGrosstotal_ValueChanged);
            // 
            // numericActualtotal
            // 
            this.numericActualtotal.Enabled = false;
            this.numericActualtotal.Location = new System.Drawing.Point(171, 139);
            this.numericActualtotal.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericActualtotal.Name = "numericActualtotal";
            this.numericActualtotal.ReadOnly = true;
            this.numericActualtotal.Size = new System.Drawing.Size(118, 20);
            this.numericActualtotal.TabIndex = 4;
            this.numericActualtotal.ValueChanged += new System.EventHandler(this.numericActualtotal_ValueChanged);
            // 
            // numericAmountpaid
            // 
            this.numericAmountpaid.Location = new System.Drawing.Point(171, 165);
            this.numericAmountpaid.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericAmountpaid.Name = "numericAmountpaid";
            this.numericAmountpaid.Size = new System.Drawing.Size(118, 20);
            this.numericAmountpaid.TabIndex = 4;
            this.numericAmountpaid.ValueChanged += new System.EventHandler(this.numericAmountpaid_ValueChanged);
            // 
            // numericChange
            // 
            this.numericChange.Enabled = false;
            this.numericChange.Location = new System.Drawing.Point(171, 191);
            this.numericChange.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericChange.Name = "numericChange";
            this.numericChange.ReadOnly = true;
            this.numericChange.Size = new System.Drawing.Size(118, 20);
            this.numericChange.TabIndex = 4;
            this.numericChange.ValueChanged += new System.EventHandler(this.numericChange_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(314, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(233, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SalesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numericChange);
            this.Controls.Add(this.numericAmountpaid);
            this.Controls.Add(this.numericActualtotal);
            this.Controls.Add(this.numericGrosstotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboGreceipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{0} sales";
            this.Load += new System.EventHandler(this.SalesManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericGrosstotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericActualtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAmountpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGreceipt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericGrosstotal;
        private System.Windows.Forms.NumericUpDown numericActualtotal;
        private System.Windows.Forms.NumericUpDown numericAmountpaid;
        private System.Windows.Forms.NumericUpDown numericChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}