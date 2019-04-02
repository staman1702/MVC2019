<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PozdravnaPoruka.aspx.cs" Inherits="WebFormsPrimjer.PozdravnaPoruka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            pozdravna poruka<br />           
            <asp:Label ID="Label1" runat="server" Text="Ime"></asp:Label><br />
            <asp:TextBox ID="txtime" runat="server" OnTextChanged="txtime_TextChanged" style="color: #990000; background-color: #FFFFCC"></asp:TextBox><br />
            <asp:Button ID="btnObradi" runat="server" Text="Button" Height="32px" OnClick="btnObradi_Click" Width="125px" /><br />
            <asp:Label ID="LBLrezultat" runat="server" Text="Label"></asp:Label><br />

        </div>
    </form>
</body>
</html>
