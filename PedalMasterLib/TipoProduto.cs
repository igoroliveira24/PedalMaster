using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    internal class TipoProduto
    {
        

        public int Id { get; set; }
        public string? Tipoproduto { get; set; }

        public TipoProduto()
        {
            
        }

        public TipoProduto(string? tipoproduto)
        {
            Tipoproduto = tipoproduto;
        }

        public TipoProduto(int id, string? tipoproduto)
        {
            Id = id;
            Tipoproduto = tipoproduto;
        }

        public static TipoProduto ObterPorId(int id)
        {
            TipoProduto tipoproduto = new ();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from tipoproduto where pk_idTipoProduto = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoproduto = new(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    );
            }

            return tipoproduto;
        }

        public static List<TipoProduto> ObterLista()
        {
            List<TipoProduto> tipoprodutos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from tipoproduto";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tipoprodutos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    ));
            }

            cmd.Connection.Close();
            return tipoprodutos;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"INSERT INTO tipoproduto(tipo) VALUES('{Tipoproduto}')";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();


        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"UPDATE tipoproduto SET tipo = '{Tipoproduto}' where pk_idTipoProduto = {Id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
        }

    }
}
