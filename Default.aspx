<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcomAssignment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 548px; margin-bottom: 12px">
    <form id="form1" runat="server">
        <asp:Panel ID="panelHeader" runat="server" Height="80px">
            <div id="divNavigation" style="height: 40px">
                <a href="Default.aspx">Home</a> About Pages Gallery Blog <a href="Contact.aspx">Contact</a></div>
            <div id="divTitle">
                Safari Adventure
                </div>
        </asp:Panel>
        <asp:Panel ID="panelBody" runat="server" Height="430px">
            <div id="divHomeImage">
                <asp:Label ID="labelHomeImage" runat="server" Text="Label"></asp:Label>
                <asp:Image ID="imgHomeImage" runat="server" />
            </div>
                </asp:Panel>
    </form>
</body>
</html>
