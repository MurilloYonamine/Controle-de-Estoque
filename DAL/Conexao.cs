using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Properties;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class Conexao
    {
        public static string mensagem = string.Empty;

        private static string strConn = Settings.Default.strConexao;

        private static MySqlConnection conn = null;
        public static MySqlConnection ObterConexao()
        {
            conn = new MySqlConnection(strConn);
            try
            {
                conn.Open();
            }
            catch (MySqlException erro)
            {
                conn = null;
                mensagem = erro.ToString();
            }
            return conn;
        }
        public static MySqlConnection FecharConexao()
        {
            conn = new MySqlConnection(strConn);
            try
            {
                conn.Close();
            }
            catch (MySqlException erro)
            {
                conn = null;
                mensagem = erro.ToString();
            }
            return conn;
        }
    }
}
