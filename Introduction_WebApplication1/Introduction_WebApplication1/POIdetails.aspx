<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POIdetails.aspx.cs" Inherits="Introduction_WebApplication1.POIdetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Title" runat="server" Text="Point Of Interest Details"></asp:Label>
        <br />
    
    </div>
    <div>
        <asp:Label ID="descriptionLabel" runat="server" Text="Description: "></asp:Label>
        <br />
        <asp:Label ID="resultLabel" runat="server" Text=" "></asp:Label>
        <br />
        <asp:Label ID="rLabel" runat="server" Text="..."></asp:Label>
        <br />
        <br />
        Reviews:<br />
        <br />
        <asp:Label ID="reviewLabel" runat="server" Text=".."></asp:Label>
    </div>
    </form>
</body>
</html>
