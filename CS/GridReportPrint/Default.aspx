<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridReportPrint._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.1.Web, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"></asp:AccessDataSource>
        &nbsp;
        <dxwgv:ASPxGridView ID="Grid" runat="server" DataSourceID="AccessDataSource1" AutoGenerateColumns="False" KeyFieldName="CategoryID" CssFilePath="~/App_Themes/BlackGlass/{0}/styles.css" CssPostfix="BlackGlass">
            <Columns>
            <dxwgv:GridViewCommandColumn ButtonType="Button" Caption="Print" VisibleIndex="0">
                <CustomButtons>
                    <dxwgv:GridViewCommandColumnCustomButton ID="btnPrint" Text="Print">
                    </dxwgv:GridViewCommandColumnCustomButton>
                </CustomButtons>
            </dxwgv:GridViewCommandColumn>
                <dxwgv:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="1">
                    <EditFormSettings Visible="False" />
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="2">
                </dxwgv:GridViewDataTextColumn>
                <dxwgv:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
                </dxwgv:GridViewDataTextColumn>
            </Columns>
            <Styles CssFilePath="~/App_Themes/BlackGlass/{0}/styles.css" CssPostfix="BlackGlass">
                <Header ImageSpacing="5px" SortingImageSpacing="5px">
                </Header>
            </Styles>
            <Images ImageFolder="~/App_Themes/BlackGlass/{0}/">
                <FilterRowButton Height="13px" Width="13px" />
            </Images>
            <ClientSideEvents CustomButtonClick="function(s, e) {
	if(e.buttonID == 'btnPrint'){
		document.getElementById('visibleIndex').value = e.visibleIndex;
		document.getElementById('isPrint').value = 'true';
		Viewer.Print();
	}
}" />
        </dxwgv:ASPxGridView>
        <div width="1" heigth="1">
            <dxxr:reportviewer id="Viewer" runat="server" clientinstancename="Viewer" PrintUsingAdobePlugIn="true"></dxxr:reportviewer>
        </div>
    </div>
        <input id="visibleIndex" type="hidden" runat ="server" />
        <input id="isPrint" type="hidden" runat="server" value="false" />
    </form>
    
</body>
</html>
