using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedalMasterLib
{
    /// <summary>
    /// Classe estática (não necessita declaração de instancia) de conexão de banco de dados MYSQL
    /// </summary>
    
    }

    public class Banco
    {
        /// <summary>
        /// Método abrir da classe Banco é utilizado para representar comandos SQL no servidor, cujos dados foram inforados na string de conexão (strconn)
        /// </summary>
        /// <returns>Entrega um objeto de comandos SQL, que serão executados na conexão informada</returns>
        public static MySqlCommand Abrir()
        {
            string strconn = @"server=localhost;database=pedalteste;user=root;password=";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {
                throw;
            }
            return cmd;
        }
    }

