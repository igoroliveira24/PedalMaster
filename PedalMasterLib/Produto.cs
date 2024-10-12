using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    internal class Produto
    {
        

        public int Id { get; set; }
        public string? CodBar { get; set; }
        public string? Nome { get; set; }
        public string? Marca { get; set; }
        public TipoProduto Tipo { get; set; }
        public int Tamanho { get; set; }
        public double Preco { get; set; }
        public int EstoqueMin { get; set; }
        public DateTime DataCad { get; set; }
        public string? Cor { get; set; }
        public double Desconto { get; set; }
        public string? Descricao { get; set; }

        public Produto()
        {

            
        }

        public Produto(string? codBar, string? nome, string? marca,
            TipoProduto tipo, int tamanho, double preco,
            string? cor, double desconto, string? descricao)
        {

            CodBar = codBar;
            Nome = nome;
            Marca = marca;
            Tipo = tipo;
            Tamanho = tamanho;
            Preco = preco;      
            Cor = cor;
            Desconto = desconto;
            Descricao = descricao;
        }

        public Produto(string? codBar, string? nome, string? marca,
            TipoProduto tipo, int tamanho, double preco, int estoqueMin,
            DateTime dataCad, string? cor, double desconto, string? descricao)
        {
            
            CodBar = codBar;
            Nome = nome;
            Marca = marca;
            Tipo = tipo;
            Tamanho = tamanho;
            Preco = preco;
            EstoqueMin = estoqueMin;
            DataCad = dataCad;
            Cor = cor;
            Desconto = desconto;
            Descricao = descricao;
        }

        public Produto(int id, string? codBar, string? nome, string? marca,
            TipoProduto tipo, int tamanho, double preco, int estoqueMin, 
            DateTime dataCad, string? cor, double desconto, string? descricao)
        {
            Id = id;
            CodBar = codBar;
            Nome = nome;
            Marca = marca;
            Tipo = tipo;
            Tamanho = tamanho;
            Preco = preco;
            EstoqueMin = estoqueMin;
            DataCad = dataCad;
            Cor = cor;
            Desconto = desconto;
            Descricao = descricao;
        }


        public static Produto ObterPorId(int id)
        {
            Produto produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto where pk_idProdutos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    TipoProduto.ObterPorId(dr.GetInt32(4)),
                    dr.GetInt32(5),
                    dr.GetDouble(6),
                    dr.GetInt32(7),
                    dr.GetDateTime(8),
                    dr.GetString(9),
                    dr.GetDouble(10),
                    dr.GetString(11)

                    );
            }
            cmd.Connection.Close();
            return produto;
        }

        

        public static List<Produto> ObterLista()
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    TipoProduto.ObterPorId(dr.GetInt32(4)),
                    dr.GetInt32(5),
                    dr.GetDouble(6),
                    dr.GetInt32(7),
                    dr.GetDateTime(8),
                    dr.GetString(9),
                    dr.GetDouble(10),
                    dr.GetString(11)

                    ));
            }
            cmd.Connection.Close();
            return produto;
        }

        public static List<Produto> ObterPorIdTipo(int id)
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto where fk_idTipoProduto = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    TipoProduto.ObterPorId(dr.GetInt32(4)),
                    dr.GetInt32(5),
                    dr.GetDouble(6),
                    dr.GetInt32(7),
                    dr.GetDateTime(8),
                    dr.GetString(9),
                    dr.GetDouble(10),
                    dr.GetString(11)

                    ));
            }
            cmd.Connection.Close();
            return produto;
        }

        public static List<Produto> ObterPorCor(string? cor)
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto where Cor = {cor}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    TipoProduto.ObterPorId(dr.GetInt32(4)),
                    dr.GetInt32(5),
                    dr.GetDouble(6),
                    dr.GetInt32(7),
                    dr.GetDateTime(8),
                    dr.GetString(9),
                    dr.GetDouble(10),
                    dr.GetString(11)

                    ));
            }
            cmd.Connection.Close();
            return produto;
        }

        public static List<Produto> ObterPorTamanho(int tam)
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto where Tamanho = {tam}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    TipoProduto.ObterPorId(dr.GetInt32(4)),
                    dr.GetInt32(5),
                    dr.GetDouble(6),
                    dr.GetInt32(7),
                    dr.GetDateTime(8),
                    dr.GetString(9),
                    dr.GetDouble(10),
                    dr.GetString(11)

                    ));
            }
            cmd.Connection.Close();
            return produto;
        }

        public static List<Produto> ObterPorMarca(string? marca)
        {
            List<Produto> produto = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from produto where Marca = {marca}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                produto.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    TipoProduto.ObterPorId(dr.GetInt32(4)),
                    dr.GetInt32(5),
                    dr.GetDouble(6),
                    dr.GetInt32(7),
                    dr.GetDateTime(8),
                    dr.GetString(9),
                    dr.GetDouble(10),
                    dr.GetString(11)

                    ));
            }
            cmd.Connection.Close();
            return produto;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spInsert_Produto";
            cmd.Parameters.AddWithValue("spCodigoDeBarras",CodBar);
            cmd.Parameters.AddWithValue("spNome", Nome);
            cmd.Parameters.AddWithValue("spMarca", Marca);
            cmd.Parameters.AddWithValue("sp_fkTipoProduto", Tipo);
            cmd.Parameters.AddWithValue("spTamanho", Tamanho);
            cmd.Parameters.AddWithValue("spPreco", Preco);
            cmd.Parameters.AddWithValue("spClasseDesconto", Desconto);
            cmd.Parameters.AddWithValue("spCor", Cor);
            cmd.Parameters.AddWithValue("spDescricao", Descricao);
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
            cmd.CommandText = "spUpdate_Produto";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spCodigoDeBarras", CodBar);
            cmd.Parameters.AddWithValue("spNome", Nome);
            cmd.Parameters.AddWithValue("spMarca", Marca);
            cmd.Parameters.AddWithValue("sp_fkTipoProduto", Tipo);
            cmd.Parameters.AddWithValue("spTamanho", Tamanho);
            cmd.Parameters.AddWithValue("spPreco", Preco);
            cmd.Parameters.AddWithValue("spEstoqueMinimo", EstoqueMin);
            cmd.Parameters.AddWithValue("spClasseDesconto", Desconto);
            cmd.Parameters.AddWithValue("spCor", Cor);
            cmd.Parameters.AddWithValue("spDescricao", Descricao);
            cmd.Connection.Close();
        }

    }
}
