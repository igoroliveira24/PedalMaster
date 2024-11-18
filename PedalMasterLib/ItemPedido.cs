using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Pedidos IdPedido { get; set; }
        public Produto Produto { get; set; }
        public double ValorUnit { get; set; }
        public int Quantidade { get; set; }
        public double Desconto { get; set; }


        public ItemPedido()
        {

        }

        public ItemPedido(int id, int quantidade, double desconto)
        {
            Id = id;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(Pedidos idPedido, Produto produto, double desconto, double valorUnit, int quantidade)
        {

            IdPedido = idPedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int id, int quantidade, double desconto , double valorUnit, Pedidos idPedido, Produto produto)
        {
            Id = id;
            Quantidade = quantidade;
            ValorUnit = valorUnit;       
            Desconto = desconto;
            IdPedido = idPedido;
            Produto = produto;
            
        }

        public ItemPedido(Pedidos idPedido, Produto produto, int quantidade, double desconto)
        {
            Produto = produto;
            IdPedido = idPedido;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public ItemPedido(double valorUnit)
        {
            ValorUnit = valorUnit;
        }

        // sp_itempedido_insert`(sppedido_id int, spproduto_id int, spquantidade decimal (10,2), spdesconto decimal(10,2))

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_Insert_ItensPedidos";
            cmd.Parameters.AddWithValue("spfkPedidos", IdPedido.Id);
            cmd.Parameters.AddWithValue("spfkProdutos", Produto.Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
        }

        public static ItemPedido ObterPoId(int id)
        {
            ItemPedido itens = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from itempedido where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itens =
                    new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetDouble(2),
                        dr.GetDouble(3),
                        Pedidos.ObterPorId(dr.GetInt32(4)),
                        Produto.ObterPorId(dr.GetInt32(5))

                    );
            }
            cmd.Connection.Close();
            return itens;

        }

        public static ItemPedido ObterValorTotal(int id)
        {
            ItemPedido itens = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select SUM((Valor * Quantidade) * (1 - Desconto / 100)) from itenspedidos where fk_idItensPedidos_Pedidos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itens =
                    new(
                        dr.GetDouble(0)
                    );
            }
            cmd.Connection.Close();
            return itens;

        }

        public static List<ItemPedido> ObterListaPorPedido(int id)
        {
            List<ItemPedido> itens = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from itenspedidos where fk_idItensPedidos_Pedidos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itens.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetInt32(1),
                        dr.GetDouble(2),
                        dr.GetDouble(3),
                        Pedidos.ObterPorId(dr.GetInt32(4)),
                        Produto.ObterPorId(dr.GetInt32(5))
                        )
                    );
            }
            cmd.Connection.Close();
            return itens;

        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_Update_ItensPedido";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spquantidade", Quantidade);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void AtualizarDescontoAtacado( int desconto, int id)
        {
            desconto -= 10;

            var cmd = Banco.Abrir();
            cmd.CommandText = $"update itenspedidos set Desconto = {desconto} where pk_idItensPedidos = {id};";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void Deletar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from itenspedidos where pk_idItensPedidos = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
