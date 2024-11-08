﻿using System;
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

        public ItemPedido(int id, int quantidade)
        {
            Id = id;
            Quantidade = quantidade;
        }

        public ItemPedido(Pedidos idPedido, Produto produto, double valorUnit, int quantidade, double desconto)
        {

            IdPedido = idPedido;
            Produto = produto;
            ValorUnit = valorUnit;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int id, int quantidade, double valorUnit,   double desconto, Pedidos idPedido, Produto produto)
        {
            Id = id;
            Quantidade = quantidade;
            ValorUnit = valorUnit;       
            Desconto = desconto;
            IdPedido = idPedido;
            Produto = produto;
            
        }

        // sp_itempedido_insert`(sppedido_id int, spproduto_id int, spquantidade decimal (10,2), spdesconto decimal(10,2))

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_insert";
            cmd.Parameters.AddWithValue("sppedido_id", IdPedido);
            cmd.Parameters.AddWithValue("spproduto_id", Produto.Id);
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
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
