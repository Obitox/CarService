<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Klijent.View" %>
<%@ Import Namespace="System.Web.Security" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="korisnickoime" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="lozinka" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="On_Click"/>
        </div>
        <div>
            <asp:Label ID="Msg" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
