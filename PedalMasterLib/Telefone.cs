using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class Telefone
    {
        

        public int Id { get; set; }
        public string? Telefones { get; set; }
        public string? Tipo { get; set; }
        public bool Ativo { get; set; }
        public Cliente IdClientes { get; set; }
        public Funcionarios IdFuncionarios { get; set; }

        public Telefone()
        {
        }

        public Telefone(string? telefones, string? tipo, Cliente idClientes)
        {
            Telefones = telefones;
            Tipo = tipo;
            IdClientes = idClientes;
        }

        public Telefone(string? telefones, string? tipo, Funcionarios idFuncionarios)
        {
            Telefones = telefones;
            Tipo = tipo;
            IdFuncionarios = idFuncionarios;
        }

        public Telefone(int id, string? telefones, string? tipo, bool ativo)
        {
            Id = id;
            Telefones = telefones;
            Tipo = tipo;
            Ativo = ativo;
        }

        public static Telefone ObterPorId(int id)
        {
            Telefone telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from telefone where pk_idTelefone = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetBoolean(3)
                    );
            }
            cmd.Connection.Close();
            return telefone;
        }

        public static List<Telefone> ObterLista()
        {
            List<Telefone> telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from telefone";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetBoolean(3)
                    ));
            }
            cmd.Connection.Close();
            return telefone;
        }

        public static List<Telefone> ObterListaPorIdCliente(int id)
        {
            List<Telefone> telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from telefone where pk_idTelefone = (select fk_idClientesTelefones_Telefone from clientestelefones where fk_idClientesTelefones_Clientes = {id})";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetBoolean(3)
                    ));
            }
            cmd.Connection.Close();
            return telefone;
        }
        public static List<Telefone> ObterListaPorIdFuncionarios(int id)
        {
            List<Telefone> telefone = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from telefone where pk_idTelefone = (select fk_idFuncionariosTelefones_Telefones from funcionariostelefones where fk_idFuncionariosTelefones_Funcionarios = {id})";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                telefone.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetBoolean(3)
                    ));
            }
            cmd.Connection.Close();
            return telefone;
        }

        public void InserirTelefoneClientes()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spClientes_Insert_Telefone";
            cmd.Parameters.AddWithValue("sp_idCliente", IdClientes.Id);
            cmd.Parameters.AddWithValue("sptelefone",Telefones);
            cmd.Parameters.AddWithValue("sptipo",Tipo);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public void InserirTelefoneFuncionarios()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spFuncionarios_Insert_Telefone";
            cmd.Parameters.AddWithValue("spid_Funcionarios", IdFuncionarios);
            cmd.Parameters.AddWithValue("sptelefone", Telefones);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
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
            cmd.CommandText = "spFuncionarios_Insert_Telefone";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("sptelefone", Telefones);
            cmd.Parameters.AddWithValue("sptipo", Tipo);
            cmd.Parameters.AddWithValue("spAtivo", Ativo);
            cmd.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update telefone set Ativo = 0 where pk_idTelefone = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update telefone set Ativo = 1 where pk_idTelefone = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }   
}

