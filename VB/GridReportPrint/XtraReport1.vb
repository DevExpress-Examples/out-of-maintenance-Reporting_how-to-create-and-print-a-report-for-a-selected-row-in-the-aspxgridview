Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace GridReportPrint
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal CatID As Integer)
			Me.New()
			CType(New NwindDataSetTableAdapters.ProductsTableAdapter(), NwindDataSetTableAdapters.ProductsTableAdapter).Fill(Me.nwindDataSet1.Products, CatID)
		End Sub

	End Class
End Namespace
