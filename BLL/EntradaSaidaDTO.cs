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
    public class EntradaSaidaDTO
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Tipo { get; set; }
        public int Total { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string Fornecedor { get; set; }
        public string Categoria { get; set; }
        public string Mensagem { get; set; }

        public decimal TotalEstoque(EntradaSaidaDTO dados, int total)
        {
            return total + Convert.ToInt32(dados.Quantidade);
        }
    }
    public class PegarDados
    {
        public ArrayList Produtos(EntradaSaidaDTO dados)
        {
            string sql = "SELECT produto_id, produto_nome FROM tb_produto";
            MySqlCommand cmd = new MySqlCommand(sql, Conexao.ObterConexao());

            ArrayList listaProduto = new ArrayList();

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaProduto.Add(reader[0].ToString() + ". " + reader[1].ToString());
                }

                reader.Close();
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - CadastroDados - PegarCategoria - " +
                erro.ErrorCode +
                erro.Message;
            }
            return listaProduto;
        }
        public void DadosProduto(EntradaSaidaDTO dados)
        {
            string sql = "SELECT produto_id, produto_descricao, produto_preco, produto_quantidade, produto_fornecedor, produto_categoria " +
                "FROM tb_produto WHERE produto_nome = @produto";

            MySqlCommand cmd = new MySqlCommand(sql, Conexao.ObterConexao());

            try
            {
                cmd.Parameters.Add(new MySqlParameter("@produto", dados.Produto.Split('.')[1].TrimStart()));
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    dados.Id = Convert.ToInt32(reader[0]);
                    dados.Descricao = reader[1].ToString();
                    dados.Preco = Convert.ToDecimal(reader[2]);
                    dados.Total = Convert.ToInt32(reader[3]);
                    dados.Fornecedor = reader[4].ToString();
                    dados.Categoria = reader[5].ToString();
                }
            }
            catch (MySqlException erro)
            {
                dados.Mensagem = "ERRO - CadastroDados - PegarCategoria - " +
                erro.ErrorCode +
                erro.Message;
            }
        }
        public void Movimentacao(EntradaSaidaDTO dados)
        {
            try
            {
                string sql = "INSERT INTO tb_movimentacao_estoque " +
                             "(movimentacao_produto, movimentacao_tipo, movimentacao_quantidade, movimentacao_data) " +
                             "VALUES (@produto, @tipo, @quantidade, @data)";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.ObterConexao());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new MySqlParameter("@produto", dados.Produto.Split('.')[0].TrimStart()));
                cmd.Parameters.Add(new MySqlParameter("@tipo", dados.Tipo));
                cmd.Parameters.Add(new MySqlParameter("@quantidade", dados.Quantidade));
                cmd.Parameters.Add(new MySqlParameter("@data", dados.Data));

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
                dados.Mensagem = "ERRO - PegarDados - Movimentacao - " +
                erro.ErrorCode +
               erro.Message;
            }
        }
        public void MovimentacaoAtualizacao(EntradaSaidaDTO dados)
        {
            try
            {
                string sql = "UPDATE tb_produto " +
                             "SET produto_quantidade = @quantidade " +
                             "WHERE produto_id = @id";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao.ObterConexao());
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add(new MySqlParameter("@quantidade", dados.Total));
                cmd.Parameters.Add(new MySqlParameter("@id", dados.Id));


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
                dados.Mensagem = "ERRO - PegarDados - Movimentacao - " +
                erro.ErrorCode +
               erro.Message;
            }
        }

    }
}

