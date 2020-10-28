Namespace GridReportPrint
	Partial Public Class ProductsReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim queryParameter1 As New DevExpress.DataAccess.Sql.QueryParameter()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ProductsReport))
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.DetailData3_Odd = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GrandTotalCaption1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GrandTotalData1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.GrandTotalBackground1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.table1 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.table2 = New DevExpress.XtraReports.UI.XRTable()
			Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
			Me.label2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.label3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.label4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.label5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.CategoryID = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "ProductID"
			table3.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""267"" />"
			table3.Name = "Products"
			columnExpression1.Table = table3
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table3
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "SupplierID"
			columnExpression3.Table = table3
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "CategoryID"
			columnExpression4.Table = table3
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "QuantityPerUnit"
			columnExpression5.Table = table3
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "UnitPrice"
			columnExpression6.Table = table3
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "UnitsInStock"
			columnExpression7.Table = table3
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "UnitsOnOrder"
			columnExpression8.Table = table3
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "ReorderLevel"
			columnExpression9.Table = table3
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "Discontinued"
			columnExpression10.Table = table3
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "EAN13"
			columnExpression11.Table = table3
			column11.Expression = columnExpression11
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.FilterString = "[Products.CategoryID] = ?CategoryID"
			selectQuery1.GroupFilterString = ""
			selectQuery1.Name = "Products"
			queryParameter1.Name = "CategoryID"
			queryParameter1.Type = GetType(DevExpress.DataAccess.Expression)
			queryParameter1.Value = New DevExpress.DataAccess.Expression("?CategoryID", GetType(Integer))
			selectQuery1.Parameters.Add(queryParameter1)
			selectQuery1.Tables.Add(table3)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' Title
			' 
			Me.Title.BackColor = System.Drawing.Color.Transparent
			Me.Title.BorderColor = System.Drawing.Color.Black
			Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.Title.BorderWidth = 1F
			Me.Title.Font = New System.Drawing.Font("Arial", 14.25F)
			Me.Title.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.Title.Name = "Title"
			' 
			' DetailCaption1
			' 
			Me.DetailCaption1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.DetailCaption1.BorderColor = System.Drawing.Color.White
			Me.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailCaption1.BorderWidth = 2F
			Me.DetailCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.DetailCaption1.ForeColor = System.Drawing.Color.White
			Me.DetailCaption1.Name = "DetailCaption1"
			Me.DetailCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData1
			' 
			Me.DetailData1.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left
			Me.DetailData1.BorderWidth = 2F
			Me.DetailData1.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData1.ForeColor = System.Drawing.Color.Black
			Me.DetailData1.Name = "DetailData1"
			Me.DetailData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' DetailData3_Odd
			' 
			Me.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(231)))), (CInt((CByte(231)))), (CInt((CByte(231)))))
			Me.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent
			Me.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.DetailData3_Odd.BorderWidth = 1F
			Me.DetailData3_Odd.Font = New System.Drawing.Font("Arial", 8.25F)
			Me.DetailData3_Odd.ForeColor = System.Drawing.Color.Black
			Me.DetailData3_Odd.Name = "DetailData3_Odd"
			Me.DetailData3_Odd.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F)
			Me.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GrandTotalCaption1
			' 
			Me.GrandTotalCaption1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.GrandTotalCaption1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GrandTotalCaption1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(147)))), (CInt((CByte(147)))), (CInt((CByte(147)))))
			Me.GrandTotalCaption1.Name = "GrandTotalCaption1"
			Me.GrandTotalCaption1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F)
			Me.GrandTotalCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GrandTotalData1
			' 
			Me.GrandTotalData1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.GrandTotalData1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GrandTotalData1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.GrandTotalData1.Name = "GrandTotalData1"
			Me.GrandTotalData1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F)
			Me.GrandTotalData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' GrandTotalBackground1
			' 
			Me.GrandTotalBackground1.BackColor = System.Drawing.Color.White
			Me.GrandTotalBackground1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.GrandTotalBackground1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.GrandTotalBackground1.BorderWidth = 2F
			Me.GrandTotalBackground1.Name = "GrandTotalBackground1"
			' 
			' PageInfo
			' 
			Me.PageInfo.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold)
			Me.PageInfo.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(75)))), (CInt((CByte(75)))), (CInt((CByte(75)))))
			Me.PageInfo.Name = "PageInfo"
			Me.PageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.pageInfo1, Me.pageInfo2})
			Me.BottomMargin.Name = "BottomMargin"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label1})
			Me.ReportHeader.HeightF = 60F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' GroupHeader1
			' 
			Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table1})
			Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
			Me.GroupHeader1.HeightF = 28F
			Me.GroupHeader1.Name = "GroupHeader1"
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.table2})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.panel1})
			Me.ReportFooter.HeightF = 49.38444F
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' pageInfo1
			' 
			Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.pageInfo1.Name = "pageInfo1"
			Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
			Me.pageInfo1.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.pageInfo1.StyleName = "PageInfo"
			' 
			' pageInfo2
			' 
			Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331F, 6F)
			Me.pageInfo2.Name = "pageInfo2"
			Me.pageInfo2.SizeF = New System.Drawing.SizeF(313F, 23F)
			Me.pageInfo2.StyleName = "PageInfo"
			Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			Me.pageInfo2.TextFormatString = "Page {0} of {1}"
			' 
			' label1
			' 
			Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(6F, 6F)
			Me.label1.Name = "label1"
			Me.label1.SizeF = New System.Drawing.SizeF(638F, 24.19433F)
			Me.label1.StyleName = "Title"
			Me.label1.Text = "Products"
			' 
			' table1
			' 
			Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table1.Name = "table1"
			Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow1})
			Me.table1.SizeF = New System.Drawing.SizeF(650F, 28F)
			' 
			' tableRow1
			' 
			Me.tableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell1, Me.tableCell2, Me.tableCell3})
			Me.tableRow1.Name = "tableRow1"
			Me.tableRow1.Weight = 1R
			' 
			' tableCell1
			' 
			Me.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell1.Name = "tableCell1"
			Me.tableCell1.StyleName = "DetailCaption1"
			Me.tableCell1.StylePriority.UseBorders = False
			Me.tableCell1.Text = "Product Name"
			Me.tableCell1.Weight = 0.367323232797476R
			' 
			' tableCell2
			' 
			Me.tableCell2.Name = "tableCell2"
			Me.tableCell2.StyleName = "DetailCaption1"
			Me.tableCell2.StylePriority.UseTextAlignment = False
			Me.tableCell2.Text = "Unit Price"
			Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell2.Weight = 0.27048224815955529R
			' 
			' tableCell3
			' 
			Me.tableCell3.Name = "tableCell3"
			Me.tableCell3.StyleName = "DetailCaption1"
			Me.tableCell3.StylePriority.UseTextAlignment = False
			Me.tableCell3.Text = "Units In Stock"
			Me.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell3.Weight = 0.36219449556790867R
			' 
			' table2
			' 
			Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.table2.Name = "table2"
			Me.table2.OddStyleName = "DetailData3_Odd"
			Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.tableRow2})
			Me.table2.SizeF = New System.Drawing.SizeF(650F, 25F)
			' 
			' tableRow2
			' 
			Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.tableCell4, Me.tableCell5, Me.tableCell6})
			Me.tableRow2.Name = "tableRow2"
			Me.tableRow2.Weight = 11.5R
			' 
			' tableCell4
			' 
			Me.tableCell4.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
			Me.tableCell4.Name = "tableCell4"
			Me.tableCell4.StyleName = "DetailData1"
			Me.tableCell4.StylePriority.UseBorders = False
			Me.tableCell4.Weight = 0.367323232797476R
			' 
			' tableCell5
			' 
			Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
			Me.tableCell5.Name = "tableCell5"
			Me.tableCell5.StyleName = "DetailData1"
			Me.tableCell5.StylePriority.UseTextAlignment = False
			Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell5.TextFormatString = "{0:C2}"
			Me.tableCell5.Weight = 0.27048224815955529R
			' 
			' tableCell6
			' 
			Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitsInStock]")})
			Me.tableCell6.Name = "tableCell6"
			Me.tableCell6.StyleName = "DetailData1"
			Me.tableCell6.StylePriority.UseTextAlignment = False
			Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.tableCell6.Weight = 0.36219454251802885R
			' 
			' panel1
			' 
			Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.label2, Me.label3, Me.label4, Me.label5})
			Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.panel1.Name = "panel1"
			Me.panel1.SizeF = New System.Drawing.SizeF(650F, 49.38444F)
			Me.panel1.StyleName = "GrandTotalBackground1"
			' 
			' label2
			' 
			Me.label2.LocationFloat = New DevExpress.Utils.PointFloat(238.7601F, 11.5F)
			Me.label2.Name = "label2"
			Me.label2.SizeF = New System.Drawing.SizeF(32.83011F, 14.88444F)
			Me.label2.StyleName = "GrandTotalCaption1"
			Me.label2.Text = "AVG"
			' 
			' label3
			' 
			Me.label3.CanGrow = False
			Me.label3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([UnitPrice])")})
			Me.label3.LocationFloat = New DevExpress.Utils.PointFloat(271.5902F, 11.5F)
			Me.label3.Name = "label3"
			Me.label3.SizeF = New System.Drawing.SizeF(142.9833F, 14.88444F)
			Me.label3.StyleName = "GrandTotalData1"
			Me.label3.StylePriority.UseTextAlignment = False
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.label3.Summary = xrSummary1
			Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.label3.TextFormatString = "{0:C2}"
			Me.label3.WordWrap = False
			' 
			' label4
			' 
			Me.label4.LocationFloat = New DevExpress.Utils.PointFloat(414.5735F, 11.5F)
			Me.label4.Name = "label4"
			Me.label4.SizeF = New System.Drawing.SizeF(33.46234F, 14.88444F)
			Me.label4.StyleName = "GrandTotalCaption1"
			Me.label4.Text = "SUM"
			' 
			' label5
			' 
			Me.label5.CanGrow = False
			Me.label5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([UnitsInStock])")})
			Me.label5.LocationFloat = New DevExpress.Utils.PointFloat(448.0359F, 11.5F)
			Me.label5.Name = "label5"
			Me.label5.SizeF = New System.Drawing.SizeF(201.9641F, 14.88444F)
			Me.label5.StyleName = "GrandTotalData1"
			Me.label5.StylePriority.UseTextAlignment = False
			xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.label5.Summary = xrSummary2
			Me.label5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.label5.WordWrap = False
			' 
			' CategoryID
			' 
			Me.CategoryID.Description = "CategoryID"
			Me.CategoryID.Name = "CategoryID"
			Me.CategoryID.Type = GetType(Integer)
			Me.CategoryID.ValueInfo = "0"
			Me.CategoryID.Visible = False
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.GroupHeader1, Me.Detail, Me.ReportFooter})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.DataMember = "Products"
			Me.DataSource = Me.sqlDataSource1
			Me.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.CategoryID})
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.DetailCaption1, Me.DetailData1, Me.DetailData3_Odd, Me.GrandTotalCaption1, Me.GrandTotalData1, Me.GrandTotalBackground1, Me.PageInfo})
			Me.Version = "19.2"
			CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private Title As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData1 As DevExpress.XtraReports.UI.XRControlStyle
		Private DetailData3_Odd As DevExpress.XtraReports.UI.XRControlStyle
		Private GrandTotalCaption1 As DevExpress.XtraReports.UI.XRControlStyle
		Private GrandTotalData1 As DevExpress.XtraReports.UI.XRControlStyle
		Private GrandTotalBackground1 As DevExpress.XtraReports.UI.XRControlStyle
		Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
		Private pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private label1 As DevExpress.XtraReports.UI.XRLabel
		Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
		Private table1 As DevExpress.XtraReports.UI.XRTable
		Private tableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private table2 As DevExpress.XtraReports.UI.XRTable
		Private tableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private tableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private tableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private panel1 As DevExpress.XtraReports.UI.XRPanel
		Private label2 As DevExpress.XtraReports.UI.XRLabel
		Private label3 As DevExpress.XtraReports.UI.XRLabel
		Private label4 As DevExpress.XtraReports.UI.XRLabel
		Private label5 As DevExpress.XtraReports.UI.XRLabel
		Private CategoryID As DevExpress.XtraReports.Parameters.Parameter
	End Class
End Namespace
