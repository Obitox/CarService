<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KlijentMeni.aspx.cs" Inherits="Klijent.KlijentMeni" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lbCeneITroskovi" runat="server"></asp:ListBox>
        </div>
        <div>
            <asp:DropDownList ID="ddlPlacanje" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnPlati" runat="server" Text="Placanje" OnClick="Placanje_Click" />
        </div>
        <div>
            <asp:Label ID="lblObavestenja" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
