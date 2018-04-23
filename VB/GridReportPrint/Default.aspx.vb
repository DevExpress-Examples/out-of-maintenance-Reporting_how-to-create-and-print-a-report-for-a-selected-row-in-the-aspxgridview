Imports Microsoft.VisualBasic
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

Namespace GridReportPrint
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If isPrint.Value="true" Then
				Dim fields() As String = { "CategoryID" }
				Dim CatID As Integer = Convert.ToInt32(Grid.GetRowValues(Convert.ToInt32(visibleIndex.Value), fields))
				Viewer.Report = New XtraReport1(CatID)
				isPrint.Value = "false"
			End If
		End Sub
	End Class
End Namespace
