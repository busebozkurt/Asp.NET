<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CookieDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   <asp:DropDownList ID="ddlUrunler" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlUrunler_SelectedIndexChanged"></asp:DropDownList>
    </div>
    </form>
</body>
</html>
