<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInclusaoVeiculo.aspx.cs" Inherits="WebAppVeiculos.WebFormInclusaoVeiculo" %>

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
                    <td><asp:TextBox ID="TextBox_Fabricante" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Modelo</td>
                    <td><asp:TextBox ID="TextBox_Modelo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Ano</td>
                    <td><asp:Calendar ID="Calendar_Ano" runat="server"></asp:Calendar></td>
                </tr>
                <tr>
                    <td>Placa</td>
                    <td><asp:TextBox ID="TextBox_Placa" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>UF</td>
                    <td><asp:TextBox ID="TextBox_UF" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button_Salvar" runat="server" Text="Salvar" /></td>
                    <td><asp:Button ID="Button_Cancelar" runat="server" Text="Cancelar" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
