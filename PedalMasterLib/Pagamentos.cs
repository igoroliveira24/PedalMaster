using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    internal class Pagamentos
    {
        

        public int Id { get; set; }
        public double Valor { get; set; }
        public Pedidos IdPedidos { get; set; }
        public string? Tipo { get; set; }

        public Pagamentos()
        {
            
        }

        public Pagamentos(double valor, Pedidos idPedidos, string? tipo)
        {
            Valor = valor;
            IdPedidos = idPedidos;
            Tipo = tipo;
        }

        public Pagamentos(int id, double valor, Pedidos idPedidos, string? tipo)
        {
            Id = id;
            Valor = valor;
            IdPedidos = idPedidos;
            Tipo = tipo;
        }

        public static Pagamentos ObterPorId(int id)
        {
            Pagamentos pagamentos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pagamentos where pk_idPagamentos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pagamentos = new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    Pedidos.ObterPorId(dr.GetInt32(2)),
                    dr.GetString(3)
                    );
            }

            return pagamentos;
        }

        public static List<Pagamentos> ObterLista()
        {
            List<Pagamentos> pagamentos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pagamentos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pagamentos.Add(new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    Pedidos.ObterPorId(dr.GetInt32(2)),
                    dr.GetString(3)
                    ));
            }

            return pagamentos;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "INSERT INTO pagamentos(Valor,fk_idPagamnetos_Pedidos,tipoPagamento) " +
                "VALUES(" +
                $"(SELECT SUM((Valor - Desconto) * Quantidade - (select Desconto from pedidos where pk_idItensPedidos = {IdPedidos})) as Soma FROM itenspedidos WHERE fk_idItensPedidos_Pedidos = {IdPedidos});," +
                $"{IdPedidos}," +
                $"'{Tipo}')";
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
            cmd.CommandText = $"UPDATE pagamentos SET Tipo = {Tipo} where pk_idPagamentos = {Id}";
            cmd.Connection.Close();
        }
    }
}
