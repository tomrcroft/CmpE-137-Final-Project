
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
        <h2>Reviews</h2>
        <asp:Table ID="reviewTable" runat="server"></asp:Table>
    </div>
    </form>
</body>
</html>
