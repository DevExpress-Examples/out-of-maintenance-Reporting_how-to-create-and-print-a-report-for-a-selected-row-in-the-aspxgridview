Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports DevExpress.Utils.Design
Imports DevExpress.XtraPrinting

Namespace GridReportPrint
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Me.Request.QueryString("isPrint") = "true" Then
				Dim categoryID As Integer = Convert.ToInt32(Me.Request.QueryString("categoryID"))
				Using report As XtraReport = New ProductsReport()
				Using ms As New MemoryStream()
					report.Parameters("CategoryID").Visible = False
					report.Parameters("CategoryID").Value = categoryID

					report.ExportToPdf(ms, New PdfExportOptions() With {.ShowPrintDialogOnOpen = True})

					Me.Response.ContentType = "application/pdf"
					Me.Response.Clear()
					Me.Response.BinaryWrite(ms.ToArray())
					Me.Response.End()
				End Using
				End Using
			End If
		End Sub
	End Class
End Namespace
