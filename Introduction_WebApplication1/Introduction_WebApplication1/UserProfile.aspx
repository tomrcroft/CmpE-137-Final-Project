<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="Introduction_WebApplication1.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ~ ~
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="ListPOIs.aspx">Return to the List of POIs</asp:HyperLink>
&nbsp;~ ~</div>
        <p>
            Welcome
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
