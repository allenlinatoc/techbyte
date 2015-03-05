namespace TechByte.Views
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.businessPartnersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanResourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMasterDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPurchasingManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalesManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRInvoiceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clerkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsCategoryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(157)))), ((int)(((byte)(232)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.humanResourceToolStripMenuItem,
            this.purchasingToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.clerkToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagementToolStripMenuItem,
            this.systemConfigurationToolStripMenuItem,
            this.businessPartnersToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.userManagementToolStripMenuItem.Text = "User management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // systemConfigurationToolStripMenuItem
            // 
            this.systemConfigurationToolStripMenuItem.Name = "systemConfigurationToolStripMenuItem";
            this.systemConfigurationToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.systemConfigurationToolStripMenuItem.Text = "System configuration";
            this.systemConfigurationToolStripMenuItem.Click += new System.EventHandler(this.systemConfigurationToolStripMenuItem_Click);
            // 
            // businessPartnersToolStripMenuItem
            // 
            this.businessPartnersToolStripMenuItem.Name = "businessPartnersToolStripMenuItem";
            this.businessPartnersToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.businessPartnersToolStripMenuItem.Text = "Business partners management";
            this.businessPartnersToolStripMenuItem.Click += new System.EventHandler(this.businessPartnersToolStripMenuItem_Click);
            // 
            // humanResourceToolStripMenuItem
            // 
            this.humanResourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMasterDataToolStripMenuItem});
            this.humanResourceToolStripMenuItem.Name = "humanResourceToolStripMenuItem";
            this.humanResourceToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.humanResourceToolStripMenuItem.Text = "Human Resource";
            // 
            // employeeMasterDataToolStripMenuItem
            // 
            this.employeeMasterDataToolStripMenuItem.Name = "employeeMasterDataToolStripMenuItem";
            this.employeeMasterDataToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.employeeMasterDataToolStripMenuItem.Text = "Employee master data";
            this.employeeMasterDataToolStripMenuItem.Click += new System.EventHandler(this.employeeMasterDataToolStripMenuItem_Click);
            // 
            // purchasingToolStripMenuItem
            // 
            this.purchasingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPurchasingManagementToolStripMenuItem,
            this.invoiceManagementToolStripMenuItem,
            this.goodsReturnToolStripMenuItem});
            this.purchasingToolStripMenuItem.Name = "purchasingToolStripMenuItem";
            this.purchasingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.purchasingToolStripMenuItem.Text = "Purchasing";
            // 
            // itemPurchasingManagementToolStripMenuItem
            // 
            this.itemPurchasingManagementToolStripMenuItem.Name = "itemPurchasingManagementToolStripMenuItem";
            this.itemPurchasingManagementToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.itemPurchasingManagementToolStripMenuItem.Text = "Item purchasing management";
            this.itemPurchasingManagementToolStripMenuItem.Click += new System.EventHandler(this.itemPurchasingManagementToolStripMenuItem_Click);
            // 
            // invoiceManagementToolStripMenuItem
            // 
            this.invoiceManagementToolStripMenuItem.Name = "invoiceManagementToolStripMenuItem";
            this.invoiceManagementToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.invoiceManagementToolStripMenuItem.Text = "A/P Invoice management";
            this.invoiceManagementToolStripMenuItem.Click += new System.EventHandler(this.invoiceManagementToolStripMenuItem_Click);
            // 
            // goodsReturnToolStripMenuItem
            // 
            this.goodsReturnToolStripMenuItem.Name = "goodsReturnToolStripMenuItem";
            this.goodsReturnToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.goodsReturnToolStripMenuItem.Text = "Goods return";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSalesManagementToolStripMenuItem,
            this.aRInvoiceManagementToolStripMenuItem,
            this.promoManagementToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // itemSalesManagementToolStripMenuItem
            // 
            this.itemSalesManagementToolStripMenuItem.Name = "itemSalesManagementToolStripMenuItem";
            this.itemSalesManagementToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.itemSalesManagementToolStripMenuItem.Text = "Item Sales management";
            // 
            // aRInvoiceManagementToolStripMenuItem
            // 
            this.aRInvoiceManagementToolStripMenuItem.Name = "aRInvoiceManagementToolStripMenuItem";
            this.aRInvoiceManagementToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.aRInvoiceManagementToolStripMenuItem.Text = "A/R Invoice management";
            // 
            // promoManagementToolStripMenuItem
            // 
            this.promoManagementToolStripMenuItem.Name = "promoManagementToolStripMenuItem";
            this.promoManagementToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.promoManagementToolStripMenuItem.Text = "Promo management";
            // 
            // clerkToolStripMenuItem
            // 
            this.clerkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseReportsToolStripMenuItem,
            this.goodsManagementToolStripMenuItem,
            this.goodsCategoryManagementToolStripMenuItem,
            this.goodsReceiptToolStripMenuItem,
            this.deliveryManagementToolStripMenuItem});
            this.clerkToolStripMenuItem.Name = "clerkToolStripMenuItem";
            this.clerkToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.clerkToolStripMenuItem.Text = "Clerk / Goods";
            // 
            // warehouseReportsToolStripMenuItem
            // 
            this.warehouseReportsToolStripMenuItem.Name = "warehouseReportsToolStripMenuItem";
            this.warehouseReportsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.warehouseReportsToolStripMenuItem.Text = "Warehouse reports";
            this.warehouseReportsToolStripMenuItem.Click += new System.EventHandler(this.warehouseReportsToolStripMenuItem_Click);
            // 
            // goodsManagementToolStripMenuItem
            // 
            this.goodsManagementToolStripMenuItem.Name = "goodsManagementToolStripMenuItem";
            this.goodsManagementToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.goodsManagementToolStripMenuItem.Text = "Goods management";
            this.goodsManagementToolStripMenuItem.Click += new System.EventHandler(this.goodsManagementToolStripMenuItem_Click);
            // 
            // goodsCategoryManagementToolStripMenuItem
            // 
            this.goodsCategoryManagementToolStripMenuItem.Name = "goodsCategoryManagementToolStripMenuItem";
            this.goodsCategoryManagementToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.goodsCategoryManagementToolStripMenuItem.Text = "Goods category management";
            this.goodsCategoryManagementToolStripMenuItem.Click += new System.EventHandler(this.goodsCategoryManagementToolStripMenuItem_Click);
            // 
            // goodsReceiptToolStripMenuItem
            // 
            this.goodsReceiptToolStripMenuItem.Name = "goodsReceiptToolStripMenuItem";
            this.goodsReceiptToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.goodsReceiptToolStripMenuItem.Text = "Goods receipts";
            this.goodsReceiptToolStripMenuItem.Click += new System.EventHandler(this.goodsReceiptToolStripMenuItem_Click);
            // 
            // deliveryManagementToolStripMenuItem
            // 
            this.deliveryManagementToolStripMenuItem.Name = "deliveryManagementToolStripMenuItem";
            this.deliveryManagementToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.deliveryManagementToolStripMenuItem.Text = "Delivery and Logistics";
            this.deliveryManagementToolStripMenuItem.Click += new System.EventHandler(this.deliveryManagementToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "TechByte Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem businessPartnersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanResourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMasterDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPurchasingManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSalesManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRInvoiceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clerkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsCategoryManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryManagementToolStripMenuItem;
    }
}