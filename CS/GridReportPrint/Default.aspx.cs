using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using DevExpress.XtraReports.UI;
using DevExpress.Utils.Design;
using DevExpress.XtraPrinting;

namespace GridReportPrint {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {            
            if (this.Request.QueryString["isPrint"] == "true") {                
                int categoryID = Convert.ToInt32(this.Request.QueryString["categoryID"]);
                using (XtraReport report = new ProductsReport())
                using (MemoryStream ms = new MemoryStream()) {
                    report.Parameters["CategoryID"].Visible = false;
                    report.Parameters["CategoryID"].Value = categoryID;

                    report.ExportToPdf(ms, new PdfExportOptions() {
                        ShowPrintDialogOnOpen = true
                    });
                 
                    this.Response.ContentType = "application/pdf";
                    this.Response.Clear();
                    this.Response.BinaryWrite(ms.ToArray());
                    this.Response.End();
                }
            }
        }
    }
}
