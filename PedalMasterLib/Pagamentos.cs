using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class Pagamentos
    {
        

        public int Id { get; set; }
        public double Valor { get; set; }
        public string Parcelas { get; set; }
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

        public Pagamentos(double valor)
        {
            Valor = valor;
        }

        public Pagamentos(double valor, string parcelas, Pedidos idPedidos, string? tipo)
        {

            Valor = valor;
            Parcelas = parcelas;
            IdPedidos = idPedidos;
            Tipo = tipo;
        }

        public Pagamentos(int id, double valor, string parcelas, Pedidos idPedidos, string? tipo)
        {
            Id = id;
            Valor = valor;
            Parcelas = parcelas;
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

        public static Pagamentos ObterValorTotal(int id)
        {
            Pagamentos pagamentos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select SUM(valor) from pagamentos where fk_idPagamnetos_Pedidos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pagamentos = new(
                    dr.GetDouble(0)
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

        public static List<Pagamentos> ObterListaPagamentosPorPedido(int id)
        {
            List<Pagamentos> pagamentos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pagamentos where fk_idPagamnetos_Pedidos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pagamentos.Add(new(
                    dr.GetInt32(0),
                    dr.GetDouble(1),
                    dr.GetString(2),
                    Pedidos.ObterPorId(dr.GetInt32(3)),
                    dr.GetString(4)
                    ));
            }

            return pagamentos;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spInsert_Pagamentos";
            cmd.Parameters.AddWithValue("spvalor", Valor);
            cmd.Parameters.AddWithValue("spParcelas", Parcelas);
            cmd.Parameters.AddWithValue("spfk_idPagamnetos_Pedidos", IdPedidos.Id);
            cmd.Parameters.AddWithValue("tipoPagamento", Tipo);
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
