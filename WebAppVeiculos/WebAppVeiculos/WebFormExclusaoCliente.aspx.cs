using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppVeiculos
{
    public partial class WebFormExclusaoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DAL.DALCliente DALCliente = new DAL.DALCliente();
                Modelo.Cliente cliente = DALCliente.Select(int.Parse(Request.QueryString["id"]));
                TextBox_Nome.Text = cliente.nome;
                Calendar_Data.SelectedDate = cliente.data_nascimento;
                TextBox_CPF.Text = cliente.cpf;
            }
        }

        protected void Button_Excluir_Click(object sender, EventArgs e)
        {
            DAL.DALCliente DALCliente = new DAL.DALCliente();
            Modelo.Cliente cliente = DALCliente.Select(int.Parse(Request.QueryString["id"]));
            try
            {
                DALCliente.Delete(cliente);
                Response.Redirect("~\\WebFormCadastroCliente.aspx");
            }
            catch
            {

            }
        }

        protected void Button_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~\\WebFormCadastroCliente.aspx");
        }
    }
}