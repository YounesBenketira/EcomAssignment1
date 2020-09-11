<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcomAssignment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 600px">
    <form id="form1" runat="server">
        <asp:Panel ID="panelHeader" runat="server">
            <div id="divNavigation">
                <a href="Default.aspx">Home</a> <a>About</a> <a>Pages</a> <a>Gallery</a> <a>Blog</a> <a href="Contact.aspx">Contact</a></div>
            <div id="divTitle">
                <p id="title">
                    <asp:Image ID="worldIcon" runat="server" ImageUrl="~/Images/worldIcon.png" Width="21px" />
                    &nbsp;Safari Adventure</p>
            </div>
        </asp:Panel>
        <asp:Panel ID="panelBody" runat="server">
            <div id="divHomeImage">
                <asp:Label ID="labelHomeImage" runat="server" Text="Explore Africa"></asp:Label>
                <asp:Label ID="labelHomeImage2" runat="server" Text="During Amazing Safari Tours!"></asp:Label>
                <asp:Image ID="imgHomeImage" runat="server" />
            </div>
                </asp:Panel>
    </form>
</body>
</html>
