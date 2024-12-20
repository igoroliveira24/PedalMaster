﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class Endereco
    {


        public int Id { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Complemento { get; set; }
        public string? Cep { get; set; }
        public bool Ativo { get; set; }
        public Cliente IdCliente { get; set; }
        public Funcionarios IdFuncionarios { get; set; }

        public Endereco()
        {



        }

        public Endereco(int id, string? cep, string? numero, string? complemento)
        {
            Id = id;
            Cep = cep;
            Numero = numero;
            Complemento = complemento;

        }

        public Endereco(string? logradouro, string? numero, string? bairro, string? cidade, string? uf, string? complemento, string? cep, Funcionarios idFuncionarios)
        {

            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            Cep = cep;
            IdFuncionarios = idFuncionarios;

        }

        public Endereco(string? logradouro, string? numero, string? bairro, string? cidade, string? uf, string? complemento, string? cep,Cliente idCliente)
        {

            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            Cep = cep;
            IdCliente = idCliente;

        }

        public Endereco(string? logradouro, string? numero, string? bairro, string? cidade, string? uf, string? complemento, string? cep)
        {

            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            Cep = cep;

        }

        public Endereco(string? logradouro, string? numero, string? bairro, string? cidade, string? uf, string? complemento, string? cep, bool ativo)
        {

            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            Cep = cep;
            Ativo = ativo;
        }

        public Endereco(int id, string? logradouro, string? numero, string? bairro, string? cidade, string? uf, string? complemento, string? cep)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            Cep = cep;
        }

        public Endereco(int id, string? logradouro, string? numero, string? bairro, string? cidade, string? uf, string? complemento, string? cep, bool ativo)
        {
            Id = id;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Complemento = complemento;
            Cep = cep;
            Ativo = ativo;
        }


        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos where pk_idEnderecos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetBoolean(8)
                    );
            }

            cmd.Connection.Close();
            return endereco;
        }

        public static List<Endereco> ObterLista()
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from enderecos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetBoolean(8)
                    ));
            }

            cmd.Connection.Close();
            return enderecos;
        }

        public static List<Endereco> ObterListaPorIdCliente(int id)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select pk_idEnderecos,CEP,Numero,Complemento from clientes INNER JOIN clientesenderecos ON clientesenderecos.fk_idClientesEnderecos_Clientes = clientes.pk_idCliente inner join enderecos on enderecos.pk_idEnderecos = clientesenderecos.fk_idClientesEnderecos_Enderecos where clientes.pk_idCliente = {id} and enderecos.Ativo = 1";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3)
                    ));
            }

            cmd.Connection.Close();
            return enderecos;
        }

        public static List<Endereco> ObterListaPorIdFuncionarios(int id)
        {
            List<Endereco> enderecos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select pk_idEnderecos,CEP,Numero,Complemento from funcionarios INNER JOIN funcionariosenderecos ON funcionariosenderecos.fk_idFuncionariosEnderecos_Funcionarios = funcionarios.pk_idFuncionarios inner join enderecos on enderecos.pk_idEnderecos = funcionariosenderecos.fk_idFuncionariosEnderecos_Enderecos where funcionarios.pk_idFuncionarios = {id} and enderecos.Ativo = 1";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enderecos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3)
                    ));
            }

            cmd.Connection.Close();
            return enderecos;
        }

        public void InserirEnderecosEmClientes()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spClientes_Insert_Enderecos";
            cmd.Parameters.AddWithValue("spid_Cliente", IdCliente.Id);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spcep", Cep);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public void InserirEnderecosEmFuncionarios()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spFuncionarios_Insert_Enderecos";
            cmd.Parameters.AddWithValue("sp_idFuncionarios", IdFuncionarios.Id);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spcep", Cep);
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
            cmd.CommandText = "sp_Update_Endereco";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", Uf);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spcep", Cep);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update enderecos set Ativo = 0 where pk_idEnderecos = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update enderecos set Ativo = 1 where pk_idEnderecos = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

    }
}
