using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;

namespace PedalMasterLib
{
    public class Funcionarios
    {


        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Rg { get; set; }
        public DateTime DataNasc { get; set; }
        public Cargos IdFuncionarios { get; set; }
        public bool Ativo { get; set; }
        public List<Email> Emails { get; set; }
        public Email Emails2 { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }

        //loginFuncionarios
        public int IdLogin { get; set; }
        public int IdEmail { get; set; }
        public string Senha { get; set; }

        public Email Email
        {
            get => default;
            set
            {
            }
        }

        public Telefone Telefone
        {
            get => default;
            set
            {
            }
        }

        public Cargos Cargos
        {
            get => default;
            set
            {
            }
        }

        public Endereco Endereco
        {
            get => default;
            set
            {
            }
        }

        public Funcionarios()
        {

        }

        public Funcionarios(string? nome, string? cpf, string? rg, DateTime dataNasc, Cargos idFuncionarios)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNasc = dataNasc;
            IdFuncionarios = idFuncionarios;

        }
        public Funcionarios(string? nome, string? cpf, string? rg, DateTime dataNasc, Cargos idFuncionarios, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNasc = dataNasc;
            IdFuncionarios = idFuncionarios;
            Ativo = ativo;
        }

        public Funcionarios(int id, string? nome, string? cpf, string? rg, DateTime dataNasc, Cargos idFuncionarios, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNasc = dataNasc;
            IdFuncionarios = idFuncionarios;
            Ativo = ativo;
        }

        public Funcionarios(int id, string? nome, string? cpf, string? rg, DateTime dataNasc, Cargos idFuncionarios, bool ativo, List<Email> email, List<Endereco> endereco, List<Telefone> telefone)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNasc = dataNasc;
            IdFuncionarios = idFuncionarios;
            Ativo = ativo;
            Emails = email;
            Enderecos = endereco;
            Telefones = telefone;
        }


        public Funcionarios(int idLogin, int id, int idEmail, string senha)
        {
            IdLogin = idLogin;
            Id = id;
            IdEmail = idEmail;
            Senha = senha;
        }

        public static Funcionarios ObrterPorID(int id)
        {
            Funcionarios funcionarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from funcionarios where pk_idFuncionarios = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionarios = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    Cargos.ObterPorId(dr.GetInt32(5)),
                    dr.GetBoolean(6)
                    );
            }
            cmd.Connection.Close();
            return funcionarios;
        }

        public void ObrterPorCPF(string Cpf)
        {
            Funcionarios funcionarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from funcionarios where CPF = {Cpf}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Id = dr.GetInt32(0);

            }
            cmd.Connection.Close();

        }

        public static List<Funcionarios> ObrterLista()
        {
            List<Funcionarios> funcionarios = new();
            Funcionarios funcionario = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from funcionarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionarios.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    Cargos.ObterPorId(dr.GetInt32(5)),
                    dr.GetBoolean(6)
                    ));
                funcionario.Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
            return funcionarios;
        }

        public static List<Funcionarios> ObrterListaPorId(int id)
        {
            List<Funcionarios> funcionarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from funcionarios where pk_idFuncionarios = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionarios.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    Cargos.ObterPorId(dr.GetInt32(5)),
                    dr.GetBoolean(6),
                    Email.ObterListaPorIdFuncionarios(dr.GetInt32(0)),
                    Endereco.ObterListaPorIdFuncionarios(dr.GetInt32(0)),
                    Telefone.ObterListaPorIdFuncionarios(dr.GetInt32(0))
                    ));

            }
            cmd.Connection.Close();
            return funcionarios;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spInsert_Funcionarios";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sprg", Rg);
            cmd.Parameters.AddWithValue("spdatnasc", DataNasc);
            cmd.Parameters.AddWithValue("spid_cargos", IdFuncionarios.Id);
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
            cmd.CommandText = "spUpdate_Funcionarios";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sprg", Rg);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            cmd.Parameters.AddWithValue("spid_cargos", IdFuncionarios);
            cmd.Parameters.AddWithValue("spativo", Ativo);
            cmd.Connection.Close();
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update funcionarios set Ativo = 0 where pk_idFuncionarios = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public static void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update funcionarios set Ativo = 1 where pk_idFuncionarios = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public static Funcionarios EfetuarLogin(int email, string senha)
        {
            Funcionarios funcionarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from loginFuncionarios where fk_idEmail = {email} and  senha = '{senha}'"; // md5 gera um hash de 32 caracteres/criptografia simples
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                funcionarios = new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetInt32(2),
                    dr.GetString(3)
                    );
            }
            cmd.Connection.Close();
            return funcionarios;
        }
    }

}
