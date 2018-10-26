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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                    <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                    <asp:BoundField DataField="data_nascimento" HeaderText="data_nascimento" SortExpression="data_nascimento" />
                    <asp:BoundField DataField="cpf" HeaderText="cpf" SortExpression="cpf" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ListarCargos" TypeName="WebAppVeiculos.DAL.DALCliente"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
