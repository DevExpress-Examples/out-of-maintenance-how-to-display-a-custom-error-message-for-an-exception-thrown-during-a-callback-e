<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v17.2, Version=17.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxButton ID="btnCallback" runat="server" Text="Perform Callback" AutoPostBack="false">
                <ClientSideEvents Click="function(s, e) { callback.PerformCallback(); } " />
            </dx:ASPxButton>
            <dx:ASPxLabel ID="lblMessage" runat="server" Text="" ClientInstanceName="label" ForeColor="Red">
            </dx:ASPxLabel>
            <dx:ASPxCallback ID="callback" runat="server" ClientInstanceName="callback" OnCallback="SaveData">
                <ClientSideEvents CallbackComplete="function (s, e) {
                    var strs = e.result.split('|');
                    if (strs[0] == 'Error')
                        label.SetText(strs[1]);
                }" />
            </dx:ASPxCallback>
        </div>
    </form>
</body>
</html>
