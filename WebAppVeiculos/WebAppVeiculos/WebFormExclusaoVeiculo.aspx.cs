using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppVeiculos
{
    public partial class WebFormExclusaoVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.DALVeiculo DALVeiculo = new DAL.DALVeiculo();
                Modelo.Veiculo veiculo = DALVeiculo.Select(int.Parse(Request.QueryString["id"]));
                TextBox_Fabricante.Text = veiculo.fabricante;
                TextBox_Modelo.Text = veiculo.modelo;
                TextBox_Ano.Text = veiculo.ano_fabricacao.ToString();
                TextBox_Placa.Text = veiculo.placa;
                TextBox_UF.Text = veiculo.uf;
            }
        }

        protected void Button_Excluir_Click(object sender, EventArgs e)
        {
            DAL.DALVeiculo DALVeiculo = new DAL.DALVeiculo();
            Modelo.Veiculo veiculo = DALVeiculo.Select(int.Parse(Request.QueryString["id"]));
            try
            {
                DALVeiculo.Delete(veiculo);
                Response.Redirect("~\\WebFormCadastroVeiculo.aspx");
            }
            catch
            {

            }
        }

        protected void Button_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\WebFormCadastroVeiculo.aspx");
        }
    }
}