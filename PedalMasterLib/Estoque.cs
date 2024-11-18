using Mysqlx.Crud;
using PedalMasterLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Estoque
    {
        public Produto ProdutoId { get; set; }
        public int Id { get; set; }
        public string Cor { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataUltMov { get; set; }


        public Estoque()
        {

        }

        public Estoque(int quantidade)
        {

            Quantidade = quantidade;

        }
        public Estoque(Produto produtoId, int quantidade)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;

        }
        public Estoque(Produto produtoId, int quantidade, DateTime dataUltMov)
        {
            ProdutoId = produtoId;
            Quantidade = quantidade;
            DataUltMov = dataUltMov;
        }

        public Estoque(int id, Produto produtoId, int quantidade, DateTime dataUltMov)
        {
            Id = id;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            DataUltMov = dataUltMov;
        }

        public Estoque(Produto produtoId)
        {
            ProdutoId = produtoId;
        }

        public Estoque(Produto produtoId, int id, int quantidade)
        {
            ProdutoId = produtoId;
            Id = id;
            Quantidade = quantidade;
        }

        public Estoque(Produto produtoId, int id, int quantidade, string cor)
        {
            ProdutoId = produtoId;
            Id = id;
            Quantidade = quantidade;
            Cor = cor;
        }

        public Estoque(string cor)
        {
            Cor = cor;
        }

        public void Alterar(int quantidade, int id, string cor)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update estoque " +
                $"set QuantidadeEstoque = {quantidade} " +
                $"where fk_Estoque_Produto = {id} and Cor = '{cor}'";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void AlterarEstoque(int id,int produtoid)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update estoque " +
                $"set QuantidadeEstoque = (SELECT SUM(QuantidadeEstoque) AS Quantidade FROM estoque where fk_Estoque_Produto = {produtoid} and Cor != '') " +
                $"where pk_idEstoque = {id} and Cor = ''";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Estoque> ObterListaPorProdutoIdEstoqueTodos()
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select produto.pk_idProdutos, estoque.pk_idEstoque, estoque.QuantidadeEstoque, produto.EstoqueMinimo from estoque " +
                $"inner join produto on estoque.fk_Estoque_Produto = produto.pk_idProdutos " +
                $"where estoque.Cor = ''";

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        Produto.ObterPorId(dr.GetInt32(0)),
                        dr.GetInt32(1),
                        dr.GetInt32(2)
                        ));
            }
            cmd.Connection.Close();
            return lista;

        }

        public static List<Estoque> ObterListaPorProdutoIdEmEstoque()
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select produto.pk_idProdutos, estoque.pk_idEstoque, estoque.QuantidadeEstoque, produto.EstoqueMinimo from estoque inner join produto on estoque.fk_Estoque_Produto = produto.pk_idProdutos where estoque.Cor = '' and estoque.QuantidadeEstoque >= produto.EstoqueMinimo";

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        Produto.ObterPorId(dr.GetInt32(0)),
                        dr.GetInt32(1),
                        dr.GetInt32(2)
                        ));
            }
            cmd.Connection.Close();
            return lista;

        }

        public static List<Estoque> ObterListaPorProdutoIdEmFalta()
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select produto.pk_idProdutos, estoque.pk_idEstoque, estoque.QuantidadeEstoque, produto.EstoqueMinimo from estoque inner join produto on estoque.fk_Estoque_Produto = produto.pk_idProdutos where estoque.Cor = '' and estoque.QuantidadeEstoque < produto.EstoqueMinimo";

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        Produto.ObterPorId(dr.GetInt32(0)),
                        dr.GetInt32(1),
                        dr.GetInt32(2)
                        ));
            }
            cmd.Connection.Close();
            return lista;

        }

        public static List<Estoque> ObterEstoquePorProdutoId(int id)
        {
            List<Estoque> estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select produto.pk_idProdutos, estoque.pk_idEstoque, estoque.QuantidadeEstoque, estoque.Cor, produto.EstoqueMinimo from estoque " +
                $"inner join produto on estoque.fk_Estoque_Produto = produto.pk_idProdutos where fk_Estoque_Produto = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque.Add(
                    new(
                        Produto.ObterPorId(dr.GetInt32(0)),
                        dr.GetInt32(1),
                        dr.GetInt32(2),
                        dr.GetString(3)
                        ));
            }

            cmd.Connection.Close();
            return estoque;
        }

        public static Estoque ObterPorId(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoque where pk_idEstoque = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                        dr.GetInt32(0),
                        Produto.ObterPorId(dr.GetInt32(1)),
                        dr.GetInt32(2),
                        dr.GetDateTime(3)
                        );
            }

            cmd.Connection.Close();
            return estoque;
        }

        public static Estoque ObterIdPoridEstoque(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoque where pk_idEstoque = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                        Produto.ObterPorId(dr.GetInt32(0)),
                        dr.GetInt32(1),
                        dr.GetDateTime(2)
                        );
            }

            cmd.Connection.Close();
            return estoque;
        }

        public static Estoque ObterCorPorProdutoId(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select Cor from produto where pk_idProdutos = (select fk_Estoque_Produto from estoque where pk_idEstoque = {id})";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                    dr.GetString(0)
                );
            }

            cmd.Connection.Close();
            return estoque;
        }
        

        public static Estoque ObterQuantidadePorProdutoId(int id)
        {
            Estoque quantidade = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select QuantidadeEstoque from estoque where fk_Estoque_Produto = {id} and Cor = ''";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                quantidade =
                    new(
                        dr.GetInt32(0)

                        );
            }
            cmd.Connection.Close();
            return quantidade;

        }

        public void Inserir(int idProduto, int quantidade, string cor)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"INSERT INTO estoque(fk_Estoque_Produto, QuantidadeEstoque, Cor) VALUES('{idProduto}', '{quantidade}', '{cor}'); select last_insert_id()";
            var dr = cmd.ExecuteReader();
            cmd.Connection.Close();

        }

        public static Estoque VerificarCor(string cor, int idproduto)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select Cor from estoque where Cor = '{cor}' and fk_Estoque_Produto = {idproduto}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                estoque = new(
                     dr.GetString(0)
                 );
            }
            cmd.Connection.Close();
            return estoque;

        }
    }
}