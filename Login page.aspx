<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login page.aspx.cs" Inherits="Project_Version_1.Login_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Login with your information as a student or a teacher.</h2>
        <p>&nbsp;</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <p>
        <asp:Label ID="Label1" runat="server" Text="Username or password is wrong"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

        </p>

    </form>
</body>
</html>
