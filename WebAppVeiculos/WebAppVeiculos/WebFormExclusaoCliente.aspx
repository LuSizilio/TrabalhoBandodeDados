﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormExclusaoCliente.aspx.cs" Inherits="WebAppVeiculos.WebFormExclusaoCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Exclusão de Cliente"></asp:Label>
            <br />
            <table style="width: 200px;">
                <tr>
                    <td style="text-align:right">Nome:</td>
                    <td><asp:TextBox ID="TextBox_Nome" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="text-align:right">Data Nasc.:</td>
                    <td><asp:Calendar ID="Calendar_Data" runat="server" ReadOnly="true"></asp:Calendar></td>
                </tr>
                <tr>
                    <td style="text-align:right">CPF:</td>
                    <td><asp:TextBox ID="TextBox_CPF" runat="server" ReadOnly="true"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button_Excluir" runat="server" Text="Excluir" OnClick="Button_Excluir_Click" /></td>
                    <td><asp:Button ID="Button_Cancelar" runat="server" Text="Cancelar" OnClick="Button_Cancelar_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
