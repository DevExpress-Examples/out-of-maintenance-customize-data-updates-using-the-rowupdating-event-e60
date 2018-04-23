<%-- BeginRegion Page setup --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Grid_Editing_CustomUpdate_CustomUpdate" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web"  TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dxwp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%-- EndRegion --%>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Customize data updates using the RowUpdating event</title>
</head>
<body>
    <form id="form1" runat="server">
    
    <dxwgv:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="ObjectDataSource1" KeyFieldName="Id" Width="300px" OnRowUpdating="grid_RowUpdating" >
        <%-- BeginRegion Grid Columns --%>
        <Columns>
            <dxwgv:GridViewCommandColumn VisibleIndex="0" ShowEditButton="True"/>
            <dxwgv:GridViewDataColumn FieldName="Id" VisibleIndex="1">
                <EditFormSettings Visible="false" />
            </dxwgv:GridViewDataColumn>
            <dxwgv:GridViewDataColumn FieldName="Name" VisibleIndex="2">
                <EditFormSettings ColumnSpan="2" />
            </dxwgv:GridViewDataColumn>
            <dxwgv:GridViewDataColumn FieldName="Quantity" VisibleIndex="3">
            </dxwgv:GridViewDataColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Price" VisibleIndex="4">
                <PropertiesTextEdit DisplayFormatString="c"></PropertiesTextEdit>
            </dxwgv:GridViewDataTextColumn>
            <dxwgv:GridViewDataTextColumn FieldName="Total" VisibleIndex="5">
                <EditFormSettings Visible="false" />
                <PropertiesTextEdit DisplayFormatString="c"></PropertiesTextEdit>
            </dxwgv:GridViewDataTextColumn>
        </Columns>
        <%-- EndRegion --%>
        <SettingsEditing EditFormColumnCount="2" />
    </dxwgv:ASPxGridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
            SelectMethod="GetItems" TypeName="InvoiceItemsProvider"></asp:ObjectDataSource>
    </form>
</body>
</html>
