<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        CALCULADORA C#</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-bottom: 0px" Text="SUMAR" Width="174px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="RESTAR" Width="155px" />
        </p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MULTIPLICAR" Width="171px" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="DIVIDIR" Width="160px" />
    </form>
</body>
</html>
