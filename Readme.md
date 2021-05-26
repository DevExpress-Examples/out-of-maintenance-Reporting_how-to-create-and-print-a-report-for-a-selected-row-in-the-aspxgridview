<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/GridReportPrint/Default.aspx) (VB: [Default.aspx](./VB/GridReportPrint/Default.aspx))
* [Default.aspx.cs](./CS/GridReportPrint/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/GridReportPrint/Default.aspx.vb))
<!-- default file list end -->
# How to create and print a report for a selected row in the ASPxGridView control

This example demonstrates how to prepare a report, corresponding to a particular row, in [ASPxGridView](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxGridView) using the [GridViewClientSideEvents.CustomButtonClick](https://docs.devexpress.com/AspNet/js-ASPxClientGridView.CustomButtonClick) client-side event. The clicked row's key (CategoryID) is passed to the report as a [parameter](https://docs.devexpress.com/XtraReports/4812/detailed-guide-to-devexpress-reporting/shape-report-data/use-report-parameters?v=20.1). This parameter is used to [filter the report's data source](https://docs.devexpress.com/XtraReports/4804/detailed-guide-to-devexpress-reporting/shape-report-data/filter-data/filter-data-at-the-data-source-level?v=20.1). The approach described in the [How to print a report without displaying it in a web application](https://github.com/DevExpress-Examples/Reporting_how-to-print-a-report-without-displaying-it-in-a-web-application-e454) code example is used to trigger the report's printing.


