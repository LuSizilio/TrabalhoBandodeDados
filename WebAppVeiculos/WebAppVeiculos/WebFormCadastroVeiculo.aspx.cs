﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppVeiculos
{
    public partial class WebFormCadastroVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                string codigo;

                // Le o numero da linha selecionada
                int index = Convert.ToInt32(e.CommandArgument);

                // Copia o conteúdo da primeira célula da linha -> Código do Livro
                codigo = GridView1.Rows[index].Cells[0].Text;

                // Grava código do Livro na sessão
                Session["au_id"] = codigo;

                // Chama a tela de edição
                Response.Redirect("~\\WebFormAlteracaoVeiculo.aspx?id=" + codigo);
            }
        }
    }
}