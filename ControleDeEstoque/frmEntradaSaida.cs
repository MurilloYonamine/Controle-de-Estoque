using BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class frmEntradaSaida : Form
    {
        EntradaSaidaDTO dados = new EntradaSaidaDTO();
        public frmEntradaSaida()
        {
            InitializeComponent();
        }

        private void frmEntradaSaida_Load(object sender, EventArgs e)
        {
            PegarDados pegarDados = new PegarDados();
            ArrayList esList = pegarDados.Produtos(dados);

            foreach (var categoria in esList)
            {
                lstProdutos.Items.Add(categoria);
            }

        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados.Produto = lstProdutos.SelectedItem.ToString();

            PegarDados infoProduto = new PegarDados();
            infoProduto.DadosProduto(dados);

            numQuantidade.Value = 0;
            numQuantidade.Minimum = - 100;
            numQuantidade.Maximum = 100;

            txtTotal.Text = dados.Total.ToString();
            txtDescricao.Text = dados.Descricao;
            txtPreco.Text = dados.Preco.ToString();
            txtFornecedor.Text = dados.Fornecedor;
            txtCategoria.Text = dados.Categoria;
            txtId.Text = dados.Id.ToString();
        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            dados.Quantidade = numQuantidade.Value;
            txtTotal.Text = dados.TotalEstoque(dados, dados.Total).ToString();

            if (Convert.ToInt32(txtTotal.Text) == 0)
            {
                numQuantidade.Minimum = numQuantidade.Value;
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            PegarDados movimentacao = new PegarDados();

            dados.Quantidade = numQuantidade.Value;
            dados.Data = dtpData.Value;
            dados.Total = Convert.ToInt32(txtTotal.Text);

            if (dados.Quantidade < 0)
            {
                dados.Tipo = "Saída";
            }
            else
            {
                dados.Tipo = "Entrada";
            }

            movimentacao.Movimentacao(dados);
            movimentacao.MovimentacaoAtualizacao(dados);
            MessageBox.Show(dados.Mensagem, "AVISO", MessageBoxButtons.OK);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos tela = new frmCadastroProdutos();
            tela.Show();
            this.Hide();
        }
    }
}
