using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ConexaoBancoMySQL
    {
        public MySqlConnection conn = null;
        public String connectionString = @"server=localhost;User Id = root; password=root;database=controle_relatorio; SslMode = none";
        public MySqlConnection getConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
