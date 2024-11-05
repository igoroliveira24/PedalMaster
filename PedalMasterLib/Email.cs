using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    public class Email
    {
        

        public int Id { get; set; }
        public string? Emails { get; set; }
        public bool Ativo { get; set; }
        public Cliente IdCliente { get; set; }
        public Funcionarios IdFuncionarios { get; set; }

        public Email()
        {          
        }

        public Email(string? emails)
        {
            Emails = emails;

        }

        public Email(string? emails, Funcionarios idFuncionarios)
        {
            Emails = emails;
            IdFuncionarios = idFuncionarios;
        }

        public Email(string? emails, Cliente idCliente)
        {          
            Emails = emails;
            IdCliente = idCliente;
        }

        public Email(int id, string? emails)
        {
            Id = id;
            Emails = emails;
        }

        public Email(int id, string? emails, bool ativo)
        {
            Id = id;
            Emails = emails;
            Ativo = ativo;
        }

        public static Email ObterPorId(int id)
        {
            Email email = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from email where pk_idEmail = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                email = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetBoolean(2)
                    );
            }

            cmd.Connection.Close();
            return email;
        }

        public void ObterPorEmail(string emailescrito)
        {
            Email email = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from email where Email = '{emailescrito}' and Ativo = 1";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                Id = dr.GetInt32(0);               
                        
                
            }
            cmd.Connection.Close();
           
        }

        public static List<Email> ObterLista()
        {
            List<Email> email = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from email";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                email.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetBoolean(2)
                    ));
            }

            cmd.Connection.Close();
            return email;
        }

        public static List<Email> ObterListaPorIdCliente(int id)
        {
            List<Email> email = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select pk_idEmail,Email from clientes INNER JOIN clientesemails ON clientesemails.fk_idClientesEmails_Clientes = clientes.pk_idCliente inner join email on email.pk_idEmail = clientesemails.fk_idClientesEmails_Email where clientes.pk_idCliente = {id} and email.Ativo;";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                email.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1)
                    ));
            }

            cmd.Connection.Close();
            return email;
        }

        public static List<Email> ObterListaPorIdFuncionarios(int id)
        {
            List<Email> email = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select pk_idEmail,Email from funcionarios INNER JOIN funcionariosemails ON funcionariosemails.fk_idFuncionariosEmails_Funcionarios = funcionarios.pk_idFuncionarios inner join email on email.pk_idEmail = funcionariosemails.fk_idFuncionariosEmails_Emails where funcionarios.pk_idFuncionarios = {id} and email.Ativo";        
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                email.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1)

                    ));
            }

            cmd.Connection.Close();
            return email;
        }

        public void InserirEmailClientes()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spClientes_Insert_Email";
            cmd.Parameters.AddWithValue("sp_idCliente",IdCliente.Id);
            cmd.Parameters.AddWithValue("Email",Emails);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public void InserirEmailFuncionarios()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "spFuncionarios_Insert_Emails";
            cmd.Parameters.AddWithValue("spid_Funcionarios", IdFuncionarios.Id);
            cmd.Parameters.AddWithValue("spemail", Emails);
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
            cmd.CommandText = "sp_Update_Email";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spemail", Emails);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
            cmd.Connection.Close();
        }

        public void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update email set Ativo = 0 where pk_idEmail = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update email set Ativo = 1 where pk_idEmail = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
