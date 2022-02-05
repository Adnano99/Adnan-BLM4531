<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instructor.aspx.cs" Inherits="Project_Version_1.Instructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            INSTRUCTOR ACCOUNT<br />
            <br />
            Welcome&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp;!<br />
            <br />
            <asp:DropDownList ID="Courses" runat="server" OnSelectedIndexChanged="Courses_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="logout" runat="server" Text="Logout" OnClick="logout_Click" />
            <br />
        </header>
        <div id="content" runat="server">
            <asp:Button ID="Addlecture" runat="server" Text="Add a new lecture" OnClick="Addlecture_Click" />
            <asp:Button ID="ViewLectures" runat="server" Text="View your lectures" OnClick="ViewLectures_Click" />
        </div>
    </form>
</body>
</html>
