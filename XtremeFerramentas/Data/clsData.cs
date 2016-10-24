using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace XtremeFerramentas.Data
{
    public class clsData
    {
        // Dados para conexao SQL

        private MySqlConnection con;

        public static MySqlConnection RetornaConexao()
        {
            string strConn = "Server=localhost;Port=3306;Database=ferramenta_novo;Uid=root;Pwd=root";
            try
            {
                MySqlConnection ocnn = new MySqlConnection(strConn);
                ocnn.Open();
                return ocnn;
            }
            catch(Exception ex)
            {
                throw (new Exception(ex.ToString()));

            }

        }

    }
}
