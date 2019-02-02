<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="SessionProject.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblInfo" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnBeniUnut"runat="server" Text="Beni Unut" OnClick="btnBeniUnut_Click" />
    </div>
    </form>
</body>
</html>
