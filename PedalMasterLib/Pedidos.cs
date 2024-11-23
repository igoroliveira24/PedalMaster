using SysPecNSLib;
using System.Data;

namespace PedalMasterLib
{
    public class Pedidos
    {
        

        public int Id { get; set; }
        public string? Estatus { get; set; }
        public double Desconto { get; set; }
        public DateTime DatPed { get; set; }
        public Funcionarios IdFuncionarios { get; set; }
        public Cliente IdCliente { get; set; }

        public ItemPedido ItemPedido
        {
            get => default;
            set
            {
            }
        }

        public Pagamentos Pagamentos
        {
            get => default;
            set
            {
            }
        }

        public Pedidos()
        {

        }

        public Pedidos(string? estatus, double desconto, DateTime datPed, Funcionarios idFuncionarios, Cliente idCliente)
        {
            Estatus = estatus;
            Desconto = desconto;
            DatPed = datPed;
            IdFuncionarios = idFuncionarios;
            IdCliente = idCliente;
        }

        public Pedidos(int id, string? estatus, double desconto, DateTime datPed, Funcionarios idFuncionarios, Cliente idCliente)
        {
            Id = id;
            Estatus = estatus;
            Desconto = desconto;
            DatPed = datPed;
            IdFuncionarios = idFuncionarios;
            IdCliente = idCliente;
        }

        public Pedidos(double desconto, Funcionarios idFuncionarios, Cliente idCliente)
        {
            Desconto = desconto;
            IdFuncionarios = idFuncionarios;
            IdCliente = idCliente;
        }

        public Pedidos(int id, string? estatus, double desconto)
        {
            Id = id;
            Estatus = estatus;
            Desconto = desconto;
        }

        public static Pedidos ObterPorId(int id)
        {
            Pedidos pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where pk_idPedidos = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    );
            }
            cmd.Connection.Close();
            return pedidos;
        }

        public static List<Pedidos> ObterLista()
        {
            List<Pedidos> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    ));
            }
            cmd.Connection.Close();
            return pedidos;
        }

        public static List<Pedidos> ObterListaEmAberto()
        {
            List<Pedidos> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where Estatus = 'A'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    ));
            }
            cmd.Connection.Close();
            return pedidos;
        }
        public static List<Pedidos> ObterListaFechado()
        {
            List<Pedidos> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where Estatus = 'F'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    ));
            }
            cmd.Connection.Close();
            return pedidos;
        }
        public static List<Pedidos> ObterListaCancelado()
        {
            List<Pedidos> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from pedidos where Estatus = 'C'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    ));
            }
            cmd.Connection.Close();
            return pedidos;
        }

        public static List<Pedidos> ObterListaPorCliente(int id)
        {
            List<Pedidos> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where fk_Pedidos_Clientes = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    ));
            }
            cmd.Connection.Close();
            return pedidos;
        }

        public static List<Pedidos> ObterListaPorFuncionario(int id)
        {
            List<Pedidos> pedidos = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from pedidos where fk_idPedidos_Funcionarios = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    ));
            }
            cmd.Connection.Close();
            return pedidos;
        }

        public static List<Pedidos> ObterListaPorTempo(DateTime um, DateTime dois)
        {
            List<Pedidos> pedidos = new();
            var cmd = Banco.Abrir();
            if (dois == default(DateTime))
            {
            cmd.CommandText = $"select * from pedidos where DataPedido = {um}";
            }
            else
            {
                cmd.CommandText = $"select * from pedidos where DataPedido BETWEEN {um} and {dois}";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pedidos.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetDouble(2),
                    dr.GetDateTime(3),
                    Funcionarios.ObrterPorID(dr.GetInt32(4)),
                    Cliente.ObterId(dr.GetInt32(5))
                    ));
            }
            cmd.Connection.Close();
            return pedidos;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_Insert_Pedidos";
            cmd.Parameters.AddWithValue("spdesconto",Desconto);
            cmd.Parameters.AddWithValue("spfkFuncionarios",IdFuncionarios.Id);
            cmd.Parameters.AddWithValue("spfkClientes",IdCliente.Id);
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
            cmd.CommandText = "sp_Update_Pedidos";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spestatus", Estatus);
            cmd.Parameters.AddWithValue("spdesconto", Desconto);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void EstatusFechado(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update pedidos set Estatus = 'F' where pk_idPedidos = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void EstatusAberto(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update pedidos set Estatus = 'A' where pk_idPedidos = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        public void EstatusCancelado(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"update pedidos set Estatus = 'C' where pk_idPedidos = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }

        
    }
}
