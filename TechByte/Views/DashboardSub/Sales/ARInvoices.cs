using Guitar32.Database;
using Guitar32.Utilities;
using Guitar32.Utilities.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TechByte.Architecture.Beans;
using TechByte.Architecture.Beans.Goods;



namespace TechByte.Views.DashboardSub.Sales
{
    public partial class ARInvoices : Form
    {
        private DatabaseConnection dbConn = TechByte.Configs.DatabaseInstance.databaseConnection;


        public ARInvoices() {
            InitializeComponent();
        }

        private void ARInvoices_Load(object sender, EventArgs e) {

        }

        private void LoadData() {
            dgARInvoices.Rows.Clear();
            QueryBuilder query = new QueryBuilder();
            query.Select()
                .From("tblsalesinvoice");
            QueryResult result = dbConn.Query(query);
            for (int i = 0; i < result.RowCount(); i++) {
                QueryResultRow row = result.GetSingle(i);
                SalesInvoice sinvoice = new SalesInvoice(Integer.Parse(row["id"]));
                dgARInvoices.Rows.Add(new object[] {
                    sinvoice.getId().ToString(),
                    sinvoice.getUser().getUsername(),
                    sinvoice.getGoodsReceipt().getId(),
                    sinvoice.getGrossTotal().ToString(),
                    sinvoice.getActualTotal().ToString(),
                    sinvoice.getAmountPaid().ToString(),
                    sinvoice.getChange().ToString()
                });
            }
            DataGridViews.SelectIndex(0, ref dgARInvoices);
        }

    }
}
