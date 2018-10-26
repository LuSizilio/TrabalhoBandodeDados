<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastroCliente.aspx.cs" Inherits="WebAppVeiculos.WebFormCadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Cadastro de Clientes" style="float: left;"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Incluir" style="float: right;" PostBackUrl="~/WebFormInclusaoCliente.aspx"/>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
