<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Project_Version_1.student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            STUDENT ACCOUNT<br />
            <br />
            <br />
            Welcome
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp; !<br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
            <br />
            <br />
            <br />
        </div>

        <div id="content" runat ="server">

            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>

        </div>
    </form>
</body>
</html>
