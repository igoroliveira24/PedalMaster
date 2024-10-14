using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class Cartoes
    {
        

        public int Id { get; set; }
        public string? NomeCartao { get; set; }
        public string? Bandeira { get; set; }
        public int NumeroCartao { get; set; }
        public DateTime Validade { get; set; }
        public string? Tipo { get; set; }
        public string? Cvv { get; set; }
        public bool Ativo { get; set; }
        public Cliente IdCliente { get; set; }

        public Cartoes()
        {
            
        }

        public Cartoes(string? nomeCartao, string? bandeira, int numeroCartao, DateTime validade, string? tipo, string? cvv, bool ativo)
        {
            NomeCartao = nomeCartao;
            Bandeira = bandeira;
            NumeroCartao = numeroCartao;
            Validade = validade;
            Tipo = tipo;
            Cvv = cvv;
            Ativo = ativo;
        }

        public Cartoes(int id, string? nomeCartao, string? bandeira, int numeroCartao, DateTime validade, string? tipo, string? cvv, bool ativo)
        {
            Id = id;
            NomeCartao = nomeCartao;
            Bandeira = bandeira;
            NumeroCartao = numeroCartao;
            Validade = validade;
            Tipo = tipo;
            Cvv = cvv;
            Ativo = ativo;
        }

        public static Cartoes ObterPorId(int id)
        {
            Cartoes cartoes = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cartoes where pk_idCartoes = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cartoes = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetDateTime(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetBoolean(7)
                    );
            }

            cmd.Connection.Close();
            return cartoes;
        }

        public static List<Cartoes> ObterLista()
        {
            List<Cartoes> cartoes = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cartoes";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cartoes.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetDateTime(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetBoolean(7)
                    ));
            }

            cmd.Connection.Close();
            return cartoes;
        }

        public static List<Cartoes> ObterListaPorIdCliente(int id)
        {
            List<Cartoes> cartoes = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cartoes where pk_idCartoes = (select pk_idCartoesClientes from cartoesclientes where fk_idCartoesClientes_Clientes = {id})";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cartoes.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetInt32(3),
                    dr.GetDateTime(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetBoolean(7)
                    ));
            }

            cmd.Connection.Close();
            return cartoes;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spInsert_cartoes";
            cmd.Parameters.AddWithValue("sp_idClientes", IdCliente);
            cmd.Parameters.AddWithValue("spnome",NomeCartao);
            cmd.Parameters.AddWithValue("spbandeira",Bandeira);
            cmd.Parameters.AddWithValue("spnumero",NumeroCartao);
            cmd.Parameters.AddWithValue("spvalidade",Validade);
            cmd.Parameters.AddWithValue("sptipo",Tipo);
            cmd.Parameters.AddWithValue("spcvv",Cvv);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spUpdate_Cartoes";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", NomeCartao);
            cmd.Parameters.AddWithValue("spbandeira", Bandeira);
            cmd.Parameters.AddWithValue("spnumero", NumeroCartao);
            cmd.Parameters.AddWithValue("spvalidade", Validade);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            cmd.Parameters.AddWithValue("spcvv", Cvv);
            cmd.Parameters.AddWithValue("spativo", Ativo);        
            cmd.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update cartoes set Ativo = 0 where pk_idCartoes = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update cartoes set Ativo = 1 where pk_idCartoes = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

    }
}
