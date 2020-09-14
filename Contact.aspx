<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="EcomAssignment1.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
    <link href="CSS/StyleSheet2.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="panelHeader" runat="server">
            <div id="divNavigation">
                <a href="Default.aspx">Home<i class="arrow down"></i></a> <a>About</a> <a>Pages<i class="arrow down"></i></a> <a>Gallery</a> <a>Blog</a> <a href="Contact.aspx">Contact</a>
            </div>
            <div id="divTitle">
                <p id="title">
                    <asp:Image ID="worldIcon" runat="server" ImageUrl="~/Images/worldIcon.png" Width="21px" />
                    &nbsp;<asp:Label runat="server" ID="titleDesc" Text=""></asp:Label>
                </p>
                <i class="fa fa-search" id="searchIcon"></i>
            </div>
        </asp:Panel>
        <asp:Panel ID="panelContactBody" runat="server">
            <div id="divContactInfo">
                <div id="divAddress">
                    <asp:Label runat="server" CssClass="lblInfoHeaders">ADDRESS:</asp:Label>
                    <asp:Label runat="server" CssClass="lblInfoDesc">
                        <i class="fa fa-home" style="color:orange;"></i>
                        <asp:Label runat="server" ID="lblAddress" Text=""></asp:Label>
                    </asp:Label>
                </div>
                <div id="divPhones">
                    <asp:Label runat="server" CssClass="lblInfoHeaders">PHONES:</asp:Label>
                    <asp:Label runat="server" CssClass="lblInfoDesc">
                        <i class="fa fa-phone" style="color:orange;"></i>
                         <asp:Label runat="server" ID="lblPhone" Text=""></asp:Label>
                    </asp:Label>
                    <asp:Label runat="server" CssClass="lblInfoDesc">
                        <i class="fa fa-fax" style="color:orange;"></i>
                         <asp:Label runat="server" ID="lblFax" Text=""></asp:Label>
                    </asp:Label>
                </div>
                <div id="divEmail">
                    <asp:Label runat="server" CssClass="lblInfoHeaders">EMAIL:</asp:Label>
                    <asp:Label runat="server" CssClass="lblInfoDesc">
                        <i class="fa fa-envelope" style="color:orange;"></i>
                        <a href=""><asp:Label runat="server" ID="lblEmail" Text=""></asp:Label></a>
                    </asp:Label>
                    <asp:Label runat="server" CssClass="lblInfoDesc">
                        Download information as: <a href="">vCard</a>
                    </asp:Label>
                </div>
            </div>
            <div id="divContactForm">
                <div id="divFormHeader">
                    <asp:Label runat="server" ID="lblFormHeader">MISCELLANEOUS INFORMATION:</asp:Label>
                    <asp:Label runat="server" ID="lblFormDesc">Email us with any questions or inquiries or use our contact data.</asp:Label>
                </div>
                <div id="divFormEntries">
                    <asp:TextBox runat="server" CssClass="txtEntries" ID="txtEntryName"></asp:TextBox>
                    <asp:TextBox runat="server" CssClass="txtEntries" ID="txtEntryEmail" TextMode="Email"></asp:TextBox>
                    <asp:TextBox runat="server" CssClass="txtEntries" ID="txtEntryPhone" TextMode="Phone"></asp:TextBox>
                    <asp:TextBox runat="server" CssClass="txtEntries" ID="txtEntryMsg" TextMode="MultiLine"></asp:TextBox>
&nbsp;</div>
                <div id="divBtns">
                    <asp:Button runat="server" Text="Send" CssClass="btnForm" ID="btnSendContact" OnClick="btnSendContact_Click" />
                    <asp:Button runat="server" Text="Clear" CssClass="btnForm" ID="btnClearContact" OnClick="btnClearContact_Click" />
                </div>

            </div>
        </asp:Panel>
    </form>
</body>
</html>
