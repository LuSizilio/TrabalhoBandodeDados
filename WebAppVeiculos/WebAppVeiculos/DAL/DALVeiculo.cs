using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppVeiculos.DAL
{
    public class DALVeiculo
    {
        string connectionString = "";

        public DALVeiculo()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Veiculo> ListarVeiculos()
        {
            Modelo.Veiculo aVeiculo;
            // Cria Lista Vazia
            List<Modelo.Veiculo> aListVeiculo = new List<Modelo.Veiculo>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Veiculo";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVeiculo = new Modelo.Veiculo(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetString(4),
                    dr.GetString(5)
                    );
                    aListVeiculo.Add(aVeiculo);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListVeiculo;
        }

        public Modelo.Veiculo Select(int id)
        {
            Modelo.Veiculo aVeiculo = new Modelo.Veiculo();
            // Cria Lista Vazia
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "Select * from Veiculo where id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVeiculo = new Modelo.Veiculo(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetString(4),
                    dr.GetString(5)
                    );
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aVeiculo;
        }

        public void Insert(Modelo.Veiculo obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("exec dbo.sp_InsertVeiculo @fabricante,@modelo ,@ano,@placa,@uf", conn);
            cmd.Parameters.AddWithValue("@fabricante", obj.fabricante);
            cmd.Parameters.AddWithValue("@modelo", obj.modelo);
            cmd.Parameters.AddWithValue("@ano", obj.ano_fabricacao);
            cmd.Parameters.AddWithValue("@placa", obj.placa);
            cmd.Parameters.AddWithValue("@uf", obj.uf);
            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        public void Update(Modelo.Veiculo obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("exec dbo.sp_UpdateVeiculo @id,@fabricante,@modelo ,@ano,@placa,@uf", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@fabricante", obj.fabricante);
            cmd.Parameters.AddWithValue("@modelo", obj.modelo);
            cmd.Parameters.AddWithValue("@ano", obj.ano_fabricacao);
            cmd.Parameters.AddWithValue("@placa", obj.placa);
            cmd.Parameters.AddWithValue("@uf", obj.uf);
            cmd.ExecuteNonQuery();
        }

        public void Delete(Modelo.Veiculo obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("exec dbo.sp_DeleteVeiculo @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.ExecuteNonQuery();
        }
    }
}