using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TesteConexao
    {
        public MySqlConnection conectar = null;
        public string mensagem = string.Empty;
        public void Verificar()
        {
            conectar = Conexao.ObterConexao();
            mensagem = Conexao.mensagem;
        }
    }
}
