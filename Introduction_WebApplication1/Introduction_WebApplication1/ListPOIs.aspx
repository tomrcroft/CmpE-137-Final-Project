<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListPOIs.aspx.cs" Inherits="Introduction_WebApplication1.ListPOIs" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome To the Web-Based Student Social Mobile Framework</title>
</head>
<body>
    <div>
        <h1>Welcome to the Web-Based Student Social Mobile Framework!</h1>
        <div>
          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Login.aspx">Logout</asp:HyperLink>
          <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="UserProfile.aspx">My Profile</asp:HyperLink>
        </div>

        <h2>Points of Interest</h2>
        <asp:Table ID="Table1" runat="server"></asp:Table>
    
    </div>
</body>
</html>
