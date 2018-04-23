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

namespace GridReportPrint {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (isPrint.Value=="true") {
                string[] fields = { "CategoryID" };
                int CatID = Convert.ToInt32(Grid.GetRowValues(Convert.ToInt32(visibleIndex.Value), fields));
                Viewer.Report = new XtraReport1(CatID);
                isPrint.Value = "false";
            }
        }
    }
}
