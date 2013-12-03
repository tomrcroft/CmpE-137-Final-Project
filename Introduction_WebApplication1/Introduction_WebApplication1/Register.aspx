<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Introduction_WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
    
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    
    &nbsp;Enter a New User Name.<br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;Enter a New Password.<br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;Re-Enter the New Password.<br />
        <br />
        <asp:TextBox ID="NameTextBox5" runat="server"></asp:TextBox>
&nbsp;Enter your Full Name.<br />
        <br />
        <asp:TextBox ID="EmailTextBox6" runat="server"></asp:TextBox>
&nbsp;Enter your Email.<br />
        <br />
        Gender:&nbsp;&nbsp;&nbsp;&nbsp; <asp:RadioButtonList ID="MyGender" runat="server">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Prefer Not To Say</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <asp:TextBox ID="BirthdayTextBox7" runat="server"></asp:TextBox>
&nbsp;Enter your Birthday. (ex: Month/Date/Year (12/31/2013)<br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Finish." OnClick="Button1_Click" />
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server" BorderColor="White" BorderWidth="0px" ReadOnly="True" Width="312px"></asp:TextBox>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Login.aspx">Logout.</asp:HyperLink>
&nbsp; (Return to the Login Page)<br />
    
    </div>
    </form>
</body>
</html>
