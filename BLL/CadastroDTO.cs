using DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CadastroDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Categoria { get; set; }
        public decimal Preco { get; set; }
        public string CodigoBarras { get; set; }
        public int Fornecedor { get; set; }
        public int Quantidade { get; set; }
        public string Mensagem { get; set; }
    }
    public class CadastroDados
    {
        public ArrayList PegarCategoria(CadastroDTO dados)
        {
            string sql = "SELECT categoria_id,categoria_nome FROM tb_categoria";
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.ObterConexao());

            ArrayList lista = new ArrayList();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(reader[0].ToString() + " - " + reader[1].ToString());
                }
                reader.Close();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - CadastroDados - PegarCategoria - " +
                erro.ErrorCode +
                erro.Message;
            }
            return lista;
        }
        public ArrayList PegarFornecedor(CadastroDTO dados)
        {
            string sql = "SELECT fornecedor_id,fornecedor_nome FROM tb_fornecedor";
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.ObterConexao());

            ArrayList lista = new ArrayList();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(reader[0].ToString() + " - " + reader[1].ToString());
                }
                reader.Close();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - CadastroDados - PegarFornecedor - " +
                erro.ErrorCode +
                erro.Message;
            }
            return lista;
        }
        public void InserirDados(CadastroDTO dados)
        {
            try
            {
                string sql = "INSERT INTO tb_produto " +
                    "(produto_nome, produto_descricao, produto_categoria, produto_codigo_barras, produto_preco, produto_fornecedor, produto_quantidade) " +
                    "VALUES (@nome, @descricao, @categoria, @codigo, @preco, @fornecedor, @quantidade)";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.ObterConexao());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new MySqlParameter("@nome", dados.Nome));
                cmd.Parameters.Add(new MySqlParameter("@descricao", dados.Descricao));
                cmd.Parameters.Add(new MySqlParameter("@categoria", dados.Categoria));
                cmd.Parameters.Add(new MySqlParameter("@codigo", dados.CodigoBarras));
                cmd.Parameters.Add(new MySqlParameter("@preco", dados.Preco));
                cmd.Parameters.Add(new MySqlParameter("@fornecedor", dados.Fornecedor));
                cmd.Parameters.Add(new MySqlParameter("@quantidade", dados.Quantidade));

                int registrosInseridos = cmd.ExecuteNonQuery();

                if (registrosInseridos >= 1)
                {
                    dados.Mensagem = "Registro inserido com Sucesso!";
                }
                else
                {
                    dados.Mensagem = "Falha ao inserir o registro!";
                }
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - SalvarCliente - InserirDados - " +
                erro.ErrorCode +
               erro.Message;
            }
        }

    }

}
