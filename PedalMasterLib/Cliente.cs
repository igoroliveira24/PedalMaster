using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class Cliente
    {
        

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataCad { get; set; }
        public DateTime DataNasc { get; set; }
        public bool Ativo { get; set; }
        public Cliente()
        {
            
        }

        public Cliente(string? nome, string? cpf, DateTime dataCad)
        {

            Nome = nome;
            Cpf = cpf;
            DataCad = dataCad;      
        }

        public Cliente(string? nome, string? cpf, DateTime dataCad, DateTime dataNasc, bool ativo)
        {
            
            Nome = nome;
            Cpf = cpf;
            DataCad = dataCad;
            DataNasc = dataNasc;
            Ativo = ativo;
        }

        public Cliente(int id, string? nome, string? cpf, DateTime dataCad, DateTime dataNasc, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataCad = dataCad;
            DataNasc = dataNasc;
            Ativo = ativo;
        }

        public static Cliente ObterId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where pk_idCliente = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    );
            }
            cmd.Connection.Close();
            return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "")
        {

                List<Cliente> clientes = new();
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                if (nome == "")
                {
                    cmd.CommandText = "select * from clientes " +
                        "order by nome";
                }
                else
                {
                    cmd.CommandText = $"select * from clientes where Nome like '%{nome}%' order by nome limit 10;";


                }

                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    clientes.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDateTime(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    )
                );
                }
                cmd.Connection.Close();
                return clientes;
            
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spInsertClientes";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf",Cpf);
            cmd.Parameters.AddWithValue("spdatanascimento",DataNasc);
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
            cmd.CommandText = "sp_Update_Clientes";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("spdatanascimento", DataNasc);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set Ativo = 0 where pk_idCliente = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set Ativo = 1 where pk_idCliente = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

    }
}
