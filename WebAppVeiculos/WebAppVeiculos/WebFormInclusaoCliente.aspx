<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormInclusaoCliente.aspx.cs" Inherits="WebAppVeiculos.WebFormAddCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Inclusão de Cliente"></asp:Label>
            <br />
            <table style="width: 200px;">
                <tr>
                    <td>Nome</td>
                    <td><asp:TextBox ID="TextBox_Nome" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Data Nasc.</td>
                    <td><asp:Calendar ID="Calendar_Data" runat="server"></asp:Calendar></td>
                </tr>
                <tr>
                    <td>CPF</td>
                    <td><asp:TextBox ID="TextBox_CPF" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button_Salvar" runat="server" Text="Salvar" OnClick="Button_Salvar_Click" /></td>
                    <td><asp:Button ID="Button_Cancelar" runat="server" Text="Cancelar" OnClick="Button_Cancelar_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
