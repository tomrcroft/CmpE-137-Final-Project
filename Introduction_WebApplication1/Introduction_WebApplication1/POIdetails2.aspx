<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POIdetails2.aspx.cs" Inherits="Introduction_WebApplication1.POIdetails2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
        <h1><asp:Label ID="POINameLabel" runat="server" Text="Description: "></asp:Label></h1>
        <p><asp:Label ID="POIDescriptionLabel" runat="server" Text="Description: "></asp:Label></p>
    </div>
    <form id="form1" runat="server">
    <div>
        <h4>Make a Review</h4>
        <asp:Label ID="reviewRatingLabel" runat="server" Text="Rating: " AssociatedControlID="ratingDropDown" />
        <asp:DropDownList ID="ratingDropDown" runat="server">
            <asp:ListItem Selected="True" Value="1"> 1 </asp:ListItem>
            <asp:ListItem Value="2"> 2 </asp:ListItem>
            <asp:ListItem Value="3"> 3 </asp:ListItem>
            <asp:ListItem Value="4"> 4 </asp:ListItem>
            <asp:ListItem Value="5"> 5 </asp:ListItem>
        </asp:DropDownList><br />
        <asp:Label ID="reviewCommentLabel" runat="server" Text="Comment: " AssociatedControlID="commentTextBox" /><br />
        <asp:TextBox ID="commentTextBox" runat="server" Height="133px" Width="360px"></asp:TextBox><br />
        <asp:Button ID="submitReview" runat="server" Text="Submit" OnClick="submitReview_Click" />
    </div>
    </form>
    <div>
        <h4>Reviews</h4>
        <asp:Table ID="ReviewsTable" runat="server"></asp:Table>
    </div>
</body>
</html>
