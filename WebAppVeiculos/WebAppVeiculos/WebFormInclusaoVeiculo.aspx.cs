using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppVeiculos
{
    public partial class WebFormInclusaoVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Salvar_Click(object sender, EventArgs e)
        {
            DAL.DALVeiculo DALVeiculo = new DAL.DALVeiculo();
            Modelo.Veiculo veiculo = new Modelo.Veiculo(TextBox_Fabricante.Text, TextBox_Modelo.Text, int.Parse(TextBox_Ano.Text),TextBox_Placa.Text, TextBox_UF.Text);
            try
            {
                DALVeiculo.Insert(veiculo);
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