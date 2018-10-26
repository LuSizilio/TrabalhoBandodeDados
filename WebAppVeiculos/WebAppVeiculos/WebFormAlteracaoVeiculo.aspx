<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAlteracaoVeiculo.aspx.cs" Inherits="WebAppVeiculos.WebFormAlteracaoVeiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Inclusão de Veículo"></asp:Label>
            <br />
            <table style="width: 200px;">
                <tr>
                    <td>Fabricante</td>
                    <td><asp:TextBox ID="TextBox_Fabricante" runat="server" Text=""></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Modelo</td>
                    <td><asp:TextBox ID="TextBox_Modelo" runat="server" Text=""></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ano</td>
                    <td><asp:TextBox ID="TextBox_Ano" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Placa</td>
                    <td><asp:TextBox ID="TextBox_Placa" runat="server" Text=""></asp:TextBox></td>
                </tr>
                <tr>
                    <td>UF</td>
                    <td><asp:TextBox ID="TextBox_UF" runat="server" Text=""></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button_Salvar" runat="server" Text="Salvar" OnClick="Button_Salvar_Click" /></td>
                    <td><asp:Button ID="Button_Cancelar" runat="server" Text="Cancelar" OnClick="Button_Cancelar_Click" /></td>
                    <td><asp:Button ID="Button_Excluir" runat="server" Text="Excluir" OnClick="Button_Excluir_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
