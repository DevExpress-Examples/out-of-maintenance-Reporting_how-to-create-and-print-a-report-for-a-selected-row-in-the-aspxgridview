using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace GridReportPrint {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }
        public XtraReport1(int CatID):this() {
            new NwindDataSetTableAdapters.ProductsTableAdapter().Fill(this.nwindDataSet1.Products, CatID);
        }

    }
}
