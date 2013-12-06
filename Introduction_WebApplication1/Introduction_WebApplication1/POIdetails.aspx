
<!DOCTYPE html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POIdetails.aspx.cs" Inherits="Introduction_WebApplication1.POIdetails" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <h1>Point of Interest Details</h1>
        </div>

        <div>
        <h2>Description</h2>
        <asp:Table ID="descriptionTable" runat="server"></asp:Table>
    </div>
        
        <div>
        <h2>Reviews and ratings</h2>
        <asp:Table ID="reviewTable" runat="server"></asp:Table>
            <br />
    </div>
        <asp:TextBox ID="reviewTextbox" runat="server" Height="20px" Width="128px">Review</asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="ratingList" runat="server">
            <asp:ListItem Value="1"></asp:ListItem>
            <asp:ListItem Value="2"></asp:ListItem>
            <asp:ListItem Value="3"></asp:ListItem>
            <asp:ListItem Value="4"></asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit Review" />
    </form>
</body>
</html>
