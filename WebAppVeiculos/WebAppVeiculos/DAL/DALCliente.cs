using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppVeiculos.DAL
{
    public class DALCliente
    {
        string connectionString = "";

        public DALCliente()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> ListarCargos()
        {
            Modelo.Cliente aCliente;
            // Cria Lista Vazia
            List<Modelo.Cliente> aListCliente = new List<Modelo.Cliente>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Cliente";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aCliente = new Modelo.Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDateTime(2),
                    dr.GetString(3)
                    );
                    aListCliente.Add(aCliente);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListCliente;
        }

        public void Insert(Modelo.Cliente obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("exec dbo.sp_InsertCliente @nome,@data,@cpf", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@data", obj.data_nascimento);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        public void Update(Modelo.Cliente obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("exec dbo.sp_UpdateCliente @id,@nome,@data,@cpf", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@data", obj.data_nascimento);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.ExecuteNonQuery();
        }

        public void Delete(Modelo.Cliente obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("exec dbo.sp_DeleteCliente @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();
        }


    }
}