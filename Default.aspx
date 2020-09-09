<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EcomAssignment1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body style="height: 548px; margin-bottom: 12px">
    <form id="form1" runat="server">
        <div id="divHeader">
            Home&nbsp; About Pages Gallery Blog Contact</div>
        <div id="divBody">
            <div id="divBodyTitle" style="height: 40px">
                Safari Adventure<br />
                <div id="divBodyImage">
                    <asp:Image ID="bodyImg" runat="server" ImageAlign="Middle" />
                </div>
            </div>
        </div>
        <div id="divFooter">
        </div>
    </form>
</body>
</html>
