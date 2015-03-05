namespace TechByte.Views.DashboardSub.Sales
{
    partial class PromoManagement
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
            this.btnNew = new System.Windows.Forms.Button();
            this.dgPromos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActivateToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPromos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(149, 38);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgPromos
            // 
            this.dgPromos.AllowUserToAddRows = false;
            this.dgPromos.AllowUserToDeleteRows = false;
            this.dgPromos.AllowUserToResizeColumns = false;
            this.dgPromos.AllowUserToResizeRows = false;
            this.dgPromos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPromos.ColumnHeadersHeight = 30;
            this.dgPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgPromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgPromos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPromos.Location = new System.Drawing.Point(167, 12);
            this.dgPromos.MultiSelect = false;
            this.dgPromos.Name = "dgPromos";
            this.dgPromos.RowHeadersVisible = false;
            this.dgPromos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPromos.Size = new System.Drawing.Size(519, 312);
            this.dgPromos.TabIndex = 9;
            this.dgPromos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPromos_CellDoubleClick);
            this.dgPromos.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 41;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Discount";
            this.Column3.Name = "Column3";
            this.Column3.Width = 72;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.Width = 60;
            // 
            // btnActivateToggle
            // 
            this.btnActivateToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateToggle.Location = new System.Drawing.Point(12, 56);
            this.btnActivateToggle.Name = "btnActivateToggle";
            this.btnActivateToggle.Size = new System.Drawing.Size(149, 38);
            this.btnActivateToggle.TabIndex = 8;
            this.btnActivateToggle.Text = "Activate/Deactivate";
            this.btnActivateToggle.UseVisualStyleBackColor = true;
            this.btnActivateToggle.Visible = false;
            this.btnActivateToggle.Click += new System.EventHandler(this.btnActivateToggle_Click);
            // 
            // PromoManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 336);
            this.Controls.Add(this.dgPromos);
            this.Controls.Add(this.btnActivateToggle);
            this.Controls.Add(this.btnNew);
            this.Name = "PromoManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promo management";
            this.Load += new System.EventHandler(this.PromoManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPromos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgPromos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnActivateToggle;
    }
}