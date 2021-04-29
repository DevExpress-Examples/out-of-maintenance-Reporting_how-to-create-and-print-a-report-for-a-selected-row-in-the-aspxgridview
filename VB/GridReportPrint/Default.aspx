<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GridReportPrint._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v19.2.Web.WebForms, Version=19.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>

<%@ Register Assembly="DevExpress.Web.v19.2, Version=19.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
        function PrintReport(categoryID) {
            window.open("Default.aspx?isPrint=true&categoryID=" + categoryID, "PrintingFrame")
            var frameElement = document.getElementById("FrameToPrint");
            frameElement.addEventListener("load", function (e) {
                if (frameElement.contentDocument.contentType !== "text/html")
                    frameElement.contentWindow.print();
            });
        }

        function Grid_CustomButtonClick(s, e) {
            if (e.buttonID == 'btnPrint') {
                PrintReport(s.GetRowKey(e.visibleIndex));
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb"
                SelectCommand="SELECT [CategoryID], [CategoryName], [Description] FROM [Categories]"></asp:AccessDataSource>
            <dx:ASPxGridView ID="Grid" runat="server" DataSourceID="AccessDataSource1" AutoGenerateColumns="False" KeyFieldName="CategoryID">
                <Columns>
                    <dx:GridViewCommandColumn ButtonType="Button" Caption="Print" VisibleIndex="0">
                        <CustomButtons>
                            <dx:GridViewCommandColumnCustomButton ID="btnPrint" Text="Print">
                            </dx:GridViewCommandColumnCustomButton>
                        </CustomButtons>
                    </dx:GridViewCommandColumn>
                    <dx:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True" VisibleIndex="1">
                        <EditFormSettings Visible="False" />
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="2">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
                    </dx:GridViewDataTextColumn>
                </Columns>                
                <ClientSideEvents CustomButtonClick="Grid_CustomButtonClick" />
            </dx:ASPxGridView>


            <iframe id="FrameToPrint" name="PrintingFrame" style="position: absolute; left: -10000px; top: -10000px;"></iframe>
        </div>
    </form>

</body>
</html>
