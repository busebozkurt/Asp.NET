<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionKavrami.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblSession" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnGonder" runat="server" Text="Gönder" OnClick="btnGonder_Click" />
        </div>
    </form>
</body>
</html>
