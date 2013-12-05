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
            !</p>
        <p>
            You can view and update your information on this page.</p>
        <p>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Name" runat="server" Width="122px"></asp:TextBox>
        </p>
        <p>
            Birthdate:&nbsp; <asp:TextBox ID="Birthdate" runat="server"></asp:TextBox>
&nbsp;(ex: Month/Date/Year (12/31/2013)</p>
        <p>
            Gender:&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButtonList ID="Gender" runat="server" OnSelectedIndexChanged="Gender_SelectedIndexChanged">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Prefer Not To Say</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Email" runat="server" Width="299px"></asp:TextBox>
        </p>
        <p>
            Favorite Places:
        </p>
        <p>
            <asp:CheckBoxList ID="FavoritePlaces" runat="server" DataSourceID="SqlFavePOIs" DataTextField="Name" DataValueField="ID">
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="SqlFavePOIs" runat="server" ConnectionString="<%$ ConnectionStrings:AlexConnectionString %>" SelectCommand="SELECT [ID], [Name] FROM [POIs]" OnSelecting="SqlFavePOIs_Selecting"></asp:SqlDataSource>
        </p>
        <asp:Button ID="Update" runat="server" OnClick="Update_Click" Text="Update" />
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" BorderWidth="0px" ReadOnly="True" Width="535px"></asp:TextBox>
    </form>
</body>
</html>
