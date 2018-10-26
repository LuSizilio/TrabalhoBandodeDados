<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormCadastroVeiculo.aspx.cs" Inherits="WebAppVeiculos.WebFormCadastroVeiculo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Cadastro de Veículos" style="float: left;"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Incluir" style="float: right;" PostBackUrl="~/WebFormInclusaoVeiculo.aspx"/>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                    <asp:BoundField DataField="fabricante" HeaderText="fabricante" SortExpression="fabricante" />
                    <asp:BoundField DataField="modelo" HeaderText="modelo" SortExpression="modelo" />
                    <asp:BoundField DataField="ano_fabricacao" HeaderText="ano_fabricacao" SortExpression="ano_fabricacao" />
                    <asp:BoundField DataField="placa" HeaderText="placa" SortExpression="placa" />
                    <asp:BoundField DataField="uf" HeaderText="uf" SortExpression="uf" />
                    <asp:ButtonField CommandName="Editar" Text="Editar" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ListarVeiculos" TypeName="WebAppVeiculos.DAL.DALVeiculo"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
