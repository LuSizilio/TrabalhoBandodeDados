<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormMenu.aspx.cs" Inherits="WebAppVeiculos.WebFormMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebFormCadastroCliente.aspx">Cadastro de Cliente</asp:HyperLink>
            <asp:HyperLink ID="HyperLink2" runat="server">Cadastro de Veículo</asp:HyperLink>
        </div>
    </form>
</body>
</html>
