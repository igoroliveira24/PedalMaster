using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class Cargos
    {
        

        public int Id { get; set; }
        public string? Cargo { get; set; }
        public string? Sigla { get; set; }
        public double Salario { get; set; }

        public Cargos()
        {
        }

        public Cargos(string? cargo, string? sigla, double salario)
        {
            Cargo = cargo;
            Sigla = sigla;
            Salario = salario;
        }

        public Cargos(int id, string? cargo, string? sigla, double salario)
        {
            Id = id;
            Cargo = cargo;
            Sigla = sigla;
            Salario = salario;
        }

        public static Cargos ObterPorId(int id)
        {
            Cargos cargos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cargos where pk_idCargos = {id}"; ;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cargos = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3)
                    );
            }

            cmd.Connection.Close();
            return cargos;
        }

        public static List<Cargos> ObterLista()
        {
            List<Cargos> cargos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cargos"; ;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cargos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetDouble(3)
                    ));
            }

            cmd.Connection.Close();
            return cargos;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spInsert_Cargos";
            cmd.Parameters.AddWithValue("spcargo",Cargo);
            cmd.Parameters.AddWithValue("spsigla",Sigla);
            cmd.Parameters.AddWithValue("spsalario",Salario);
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
            cmd.CommandText = "spUpdate_Cargos"; 
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcargo", Cargo);
            cmd.Parameters.AddWithValue("spsigla", Sigla);
            cmd.Parameters.AddWithValue("spsalario", Salario);
            cmd.Connection.Close();
        }
    }
}
