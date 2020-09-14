<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcomAssignment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" />
</head>
<body style="height: 600px">
    <form id="form1" runat="server">
        <asp:Panel ID="panelHeader" runat="server">
            <div id="divNavigation">
                <a href="Default.aspx">Home<i class="arrow down"></i></a> <a>About</a> <a>Pages<i class="arrow down"></i></a> <a>Gallery</a> <a>Blog</a> <a href="Contact.aspx">Contact</a>
            </div>
            <div id="divTitle">
                <p id="title">
                    <asp:Image ID="worldIcon" runat="server" ImageUrl="~/Images/worldIcon.png" Width="21px" />
                    &nbsp;<asp:Label runat="server" id="titleDesc" Text=""></asp:Label>
                </p>
                <i class="fa fa-search" id="searchIcon"></i>
            </div>
        </asp:Panel>
        <asp:Panel ID="panelBody" runat="server">
            <div id="backgroundInfo"></div>
            <div id="divInformation">
                <div class="infoCard">
                    <div></div>
                    <asp:Label runat="server" id="cardHeader0" Text="" CssClass="infoCardHeader"></asp:Label>
                    <asp:Image runat="server" CssClass="infoCardImage" ImageUrl="~/Images/wierdDeers.jpg" />
                    <asp:Label runat="server" id="cardTitle0" Text="" CssClass="infoCardTitle"></asp:Label>
                    <asp:Label runat="server" id="cardDesc0" Text="" CssClass="infoCardDesc"></asp:Label>
                    <asp:Label runat="server" Text="more" CssClass="infoCardBtn"></asp:Label>
                </div>
                <div class="infoCard">
                    <div></div>
                    <asp:Label runat="server" id="cardHeader1" Text="" CssClass="infoCardHeader"></asp:Label>
                    <asp:Image runat="server" CssClass="infoCardImage" ImageUrl="~/Images/elephants.jpg" />
                    <asp:Label runat="server" id="cardTitle1" Text="" CssClass="infoCardTitle"></asp:Label>
                    <asp:Label runat="server" id="cardDesc1" Text="" CssClass="infoCardDesc"></asp:Label>
                    <asp:Label runat="server" Text="more" CssClass="infoCardBtn"></asp:Label>
                </div>
                <div class="infoCard">
                    <div></div>
                    <asp:Label runat="server" id="cardHeader2" Text="" CssClass="infoCardHeader"></asp:Label>
                    <asp:Image runat="server" CssClass="infoCardImage" ImageUrl="~/Images/cheeta.jpeg" />
                    <asp:Label runat="server" id="cardTitle2" Text="" CssClass="infoCardTitle"></asp:Label>
                    <asp:Label runat="server" id="cardDesc2" Text="" CssClass="infoCardDesc"></asp:Label>
                    <asp:Label runat="server" Text="more" CssClass="infoCardBtn"></asp:Label>
                </div>
            </div>
            <div id="divHomeImage">
                <asp:Label ID="labelHomeImage" runat="server" Text="Explore Africa"></asp:Label>
                <asp:Label ID="labelHomeImage2" runat="server" Text="During Amazing Safari Tours!"></asp:Label>
                <asp:Image ID="imgHomeImage" runat="server" ImageAlign="Top" ImageUrl="~/Images/Monkey.jpg" />
                <asp:Button runat="server" CssClass="slideShowBtns" ID="slide1" OnClick="SlideOnePressed"/>
                <asp:Button runat="server" CssClass="slideShowBtns" ID="slide2" OnClick="SlideTwoPressed"/>
                <asp:Button runat="server" CssClass="slideShowBtns" ID="slide3" OnClick="SlideThreePressed"/>
            </div>
        </asp:Panel>
    </form>
</body>
</html>
