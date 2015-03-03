namespace TechByte.Views.DashboardSub.Clerk.Modals
{
    partial class GoodsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboVendor = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.txtGood_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGood_Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericGood_Price = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericGood_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "{0} good/product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category";
            // 
            // comboVendor
            // 
            this.comboVendor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVendor.FormattingEnabled = true;
            this.comboVendor.Location = new System.Drawing.Point(126, 61);
            this.comboVendor.Name = "comboVendor";
            this.comboVendor.Size = new System.Drawing.Size(209, 21);
            this.comboVendor.TabIndex = 2;
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(126, 88);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(167, 21);
            this.comboCategory.TabIndex = 2;
            // 
            // txtGood_Name
            // 
            this.txtGood_Name.Location = new System.Drawing.Point(126, 130);
            this.txtGood_Name.MaxLength = 75;
            this.txtGood_Name.Name = "txtGood_Name";
            this.txtGood_Name.Size = new System.Drawing.Size(260, 20);
            this.txtGood_Name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description";
            // 
            // txtGood_Description
            // 
            this.txtGood_Description.Location = new System.Drawing.Point(126, 156);
            this.txtGood_Description.MaxLength = 500;
            this.txtGood_Description.Multiline = true;
            this.txtGood_Description.Name = "txtGood_Description";
            this.txtGood_Description.Size = new System.Drawing.Size(308, 92);
            this.txtGood_Description.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Unit price";
            // 
            // numericGood_Price
            // 
            this.numericGood_Price.DecimalPlaces = 2;
            this.numericGood_Price.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericGood_Price.Location = new System.Drawing.Point(126, 254);
            this.numericGood_Price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericGood_Price.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericGood_Price.Name = "numericGood_Price";
            this.numericGood_Price.Size = new System.Drawing.Size(120, 20);
            this.numericGood_Price.TabIndex = 4;
            this.numericGood_Price.ThousandsSeparator = true;
            this.numericGood_Price.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(420, 285);
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
            this.btnSave.Location = new System.Drawing.Point(339, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GoodsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(507, 320);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numericGood_Price);
            this.Controls.Add(this.txtGood_Description);
            this.Controls.Add(this.txtGood_Name);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.comboVendor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsForm";
            this.Text = "{0} good/product";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericGood_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboVendor;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.TextBox txtGood_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGood_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericGood_Price;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}