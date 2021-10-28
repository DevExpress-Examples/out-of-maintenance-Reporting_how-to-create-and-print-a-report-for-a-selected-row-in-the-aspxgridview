Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevExpress.Utils.Design
Imports DevExpress.XtraPrinting

Namespace GridReportPrint

    Public Partial Class _Default
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(Request.QueryString("isPrint"), "true") Then
                Dim categoryID As Integer = Convert.ToInt32(Request.QueryString("categoryID"))
                Using report As XtraReport = New ProductsReport()
                    Using ms As MemoryStream = New MemoryStream()
                        report.Parameters("CategoryID").Visible = False
                        report.Parameters("CategoryID").Value = categoryID
                        report.ExportToPdf(ms, New PdfExportOptions() With {.ShowPrintDialogOnOpen = True})
                        Response.ContentType = "application/pdf"
                        Response.Clear()
                        Response.BinaryWrite(ms.ToArray())
                        Response.End()
                    End Using
                End Using
            End If
        End Sub
    End Class
End Namespace
