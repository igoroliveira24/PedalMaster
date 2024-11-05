using PedalMasterLib;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Estoque(string cor)
        {
            Cor = cor;
        }

        public void AlterarEstoque()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update estoque " +
                $"set QuantidadeEstoque = {Quantidade} " +
                $"where fk_Estoque_Produto = {ProdutoId.Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static List<Estoque> ObterListaPorProdutoIdEstoqueTodos()
        {
            List<Estoque> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select produto.pk_idProdutos, estoque.pk_idEstoque, estoque.QuantidadeEstoque, produto.EstoqueMinimo from estoque " +
                $"inner join produto on estoque.fk_Estoque_Produto = produto.pk_idProdutos ";

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

        public static Estoque ObterEstoquePorProdutoId(int id)
        {
            Estoque estoque = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from estoque where fk_Estoque_Produto = {id}";
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
            cmd.CommandText = $"select quantidade from estoques where fk_Estoque_Produto = {id} ";
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
    }
}