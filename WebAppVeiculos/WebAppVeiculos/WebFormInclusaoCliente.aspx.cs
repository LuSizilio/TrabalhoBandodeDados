using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppVeiculos
{
    public partial class WebFormAddCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Salvar_Click(object sender, EventArgs e)
        {
            DAL.DALCliente DALCliente = new DAL.DALCliente();
            Modelo.Cliente cliente = new Modelo.Cliente(TextBox_Nome.Text, Calendar_Data.SelectedDate, TextBox_CPF.Text);
            try
            {
                DALCliente.Insert(cliente);
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